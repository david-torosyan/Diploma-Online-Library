import React, { useEffect, useState, useCallback } from "react";
import { Link, useLocation, useParams, useNavigate } from "react-router-dom";
import {
  LibraryClient,
  BookDto,
  BookWithDetailsDto,
  ReviewDto,
  UpsertReviewDto,
} from "../api/LibraryClient";
import { useTranslation } from "react-i18next";
import config from "../config/config";
import Cookies from "js-cookie";
import { getCurrentUserId, isAdminUser } from "../utils/auth";
import { getRelatedBooks } from "../services/discoveryService";
import { startPrivateConversation } from "../services/chatService";
import { improveText } from "../services/aiWritingService.ts";

const isLocalMediaUrl = (url?: string) => !!url && url.includes("/media/");

const BookDetail: React.FC = () => {
  const { id } = useParams<{ id: string }>();
  const location = useLocation();
  const navigate = useNavigate();
  const [book, setBook] = useState<BookWithDetailsDto>();
  const [loading, setLoading] = useState(true);
  const [isAuthenticated, setIsAuthenticated] = useState(false);
  const [isAdmin, setIsAdmin] = useState(false);
  const [isFavorite, setIsFavorite] = useState(false);
  const [favoriteLoading, setFavoriteLoading] = useState(false);
  const [isPendingApproval, setIsPendingApproval] = useState(false);
  const [approvalLoading, setApprovalLoading] = useState(false);
  const [declineLoading, setDeclineLoading] = useState(false);
  const [relatedBooks, setRelatedBooks] = useState<BookDto[]>([]);
  const [relatedLoading, setRelatedLoading] = useState(false);
  const [reviewSubmitting, setReviewSubmitting] = useState(false);
  const [reviewError, setReviewError] = useState<string | null>(null);
  const [reviewSuccess, setReviewSuccess] = useState<string | null>(null);
  const [hoveredRating, setHoveredRating] = useState<number | null>(null);
  const [reviewForm, setReviewForm] = useState({ rating: 0, content: "" });
  const [aiImproving, setAiImproving] = useState(false);
  const [aiWriting, setAiWriting] = useState(false);
  const { t } = useTranslation();
  const currentUserId = getCurrentUserId();

  const renderStars = useCallback((rating: number) => {
    return Array.from({ length: 5 }, (_, index) => (
      <span
        key={`star-${rating}-${index}`}
        className={`review-star ${index < rating ? "is-filled" : ""}`}
        aria-hidden="true"
      >
        ★
      </span>
    ));
  }, []);

  const loadBook = useCallback(
    async (showLoading = true) => {
      if (!id) {
        navigate("/", { replace: true });
        return;
      }

      const bookId = Number(id);
      if (!Number.isFinite(bookId) || bookId <= 0) {
        navigate("/", { replace: true });
        return;
      }

      if (showLoading) {
        setLoading(true);
      }

      try {
        const api = new LibraryClient(config.baseUrl);
        const result = await api.id(bookId);

        if (result) {
          setBook(result);
        } else {
          navigate("/", { replace: true });
        }
      } catch (err) {
        console.error(err);
        navigate("/", { replace: true });
      } finally {
        if (showLoading) {
          setLoading(false);
        }
      }
    },
    [id, navigate]
  );

  useEffect(() => {
    setIsAdmin(isAdminUser());
    loadBook();
  }, [loadBook]);

  const loadApprovalState = useCallback(async () => {
    if (!id) return;

    const token = Cookies.get("auth_token");
    if (!token || !isAdminUser()) {
      setIsPendingApproval(false);
      return;
    }

    try {
      const api = new LibraryClient(config.baseUrl);
      const unapprovedBooks = await api.unapproved(token);
      const currentBookId = Number(id);
      setIsPendingApproval(
        unapprovedBooks.some((item) => item.id === currentBookId)
      );
    } catch {
      setIsPendingApproval(false);
    }
  }, [id]);

  const loadFavoriteState = useCallback(async () => {
    if (!id) return;

    const token = Cookies.get("auth_token");
    if (!token) {
      setIsAuthenticated(false);
      setIsFavorite(false);
      return;
    }

    setIsAuthenticated(true);

    try {
      const api = new LibraryClient(config.baseUrl);
      const favorites = await api.myFavoritesAll(token);
      const currentBookId = Number(id);
      const exists = favorites.some((item) => item.id === currentBookId);
      setIsFavorite(exists);
    } catch {
      setIsFavorite(false);
    }
  }, [id]);

  useEffect(() => {
    const state = location.state as { refreshAfterCreate?: boolean } | null;
    if (!id || !state?.refreshAfterCreate) {
      return;
    }

    const refreshKey = `bookdetails-create-refresh-${id}`;
    if (sessionStorage.getItem(refreshKey) === "1") {
      navigate(location.pathname, { replace: true, state: null });
      return;
    }

    sessionStorage.setItem(refreshKey, "1");
    const refreshTimer = window.setTimeout(() => {
      loadBook(false);
    }, 150);

    navigate(location.pathname, { replace: true, state: null });

    return () => {
      window.clearTimeout(refreshTimer);
    };
  }, [id, loadBook, location.pathname, location.state, navigate]);

  useEffect(() => {
    loadFavoriteState();
  }, [loadFavoriteState]);

  useEffect(() => {
    loadApprovalState();
  }, [loadApprovalState]);

  useEffect(() => {
    const currentBookId = Number(id);
    if (!currentBookId || !book) {
      return;
    }

    let isCurrent = true;

    const loadRelated = async () => {
      if (isCurrent) {
        setRelatedLoading(true);
      }
      try {
        const items = await getRelatedBooks(
          currentBookId,
          book.categoryName,
          8
        );
        if (isCurrent) {
          setRelatedBooks(items);
        }
      } finally {
        if (isCurrent) {
          setRelatedLoading(false);
        }
      }
    };

    loadRelated();

    return () => {
      isCurrent = false;
    };
  }, [book, id]);

  useEffect(() => {
    const existingReview = book?.reviews?.find(
      (review) => review.applicationUserId === currentUserId
    );

    setReviewForm({
      rating: existingReview?.rating ?? 0,
      content: existingReview?.content ?? "",
    });
  }, [book, currentUserId]);

  const handleFavoriteToggle = async () => {
    if (!id || favoriteLoading) return;

    const token = Cookies.get("auth_token");
    if (!token) return;

    const bookId = Number(id);
    const nextFavoriteState = !isFavorite;

    setFavoriteLoading(true);
    try {
      const api = new LibraryClient(config.baseUrl);
      await api.myFavorites(bookId, nextFavoriteState, token);
      setIsFavorite(nextFavoriteState);

      // Update favorites count dynamically without page reload
      if (book) {
        setBook((prevBook) => {
          if (!prevBook) {
            return prevBook;
          }

          const currentFavorites = prevBook.favorites ?? [];
          const newCount = nextFavoriteState
            ? currentFavorites.length + 1
            : Math.max(0, currentFavorites.length - 1);

          return BookWithDetailsDto.fromJS({
            ...prevBook,
            favorites: Array.from({ length: newCount }, () => ({} as any)),
          });
        });
      }
    } finally {
      setFavoriteLoading(false);
    }
  };

  const handleApprove = async () => {
    if (!id || approvalLoading) return;

    const token = Cookies.get("auth_token");
    if (!token) return;

    setApprovalLoading(true);
    try {
      const api = new LibraryClient(config.baseUrl);
      await api.approve(Number(id), token);
      setIsPendingApproval(false);

      try {
        const unapprovedBooks = await api.unapproved(token);
        const nextCount = Array.isArray(unapprovedBooks) ? unapprovedBooks.length : 0;
        window.dispatchEvent(
          new CustomEvent("admin-unapproved-count-changed", {
            detail: nextCount,
          })
        );
      } catch {
        window.dispatchEvent(
          new CustomEvent("admin-unapproved-count-changed", {
            detail: 0,
          })
        );
      }
    } finally {
      setApprovalLoading(false);
    }
  };

  const handleDecline = async () => {
    if (!id || declineLoading) return;

    const token = Cookies.get("auth_token");
    if (!token) return;

    setDeclineLoading(true);
    try {
      const api = new LibraryClient(config.baseUrl);
      await api.decline(Number(id), token);

      const unapprovedBooks = await api.unapproved(token);
      const nextCount = Array.isArray(unapprovedBooks) ? unapprovedBooks.length : 0;
      window.dispatchEvent(
        new CustomEvent("admin-unapproved-count-changed", {
          detail: nextCount,
        })
      );

      navigate("/");
    } catch {
      window.dispatchEvent(
        new CustomEvent("admin-unapproved-count-changed", {
          detail: 0,
        })
      );
    } finally {
      setDeclineLoading(false);
    }
  };

  const handleReviewSubmit = async () => {
    if (!id || reviewSubmitting) return;

    const token = Cookies.get("auth_token");
    if (!token) {
      setReviewError(t("reviewSignIn", "Sign in to rate and review this book."));
      return;
    }

    const normalizedContent = reviewForm.content.trim();
    if (reviewForm.rating < 1 || reviewForm.rating > 5) {
      setReviewError(t("reviewRatingRequired", "Choose a rating from 1 to 5 stars."));
      return;
    }

    if (normalizedContent.length < 3) {
      setReviewError(t("reviewCommentRequired", "Please write at least a short comment."));
      return;
    }

    setReviewSubmitting(true);
    setReviewError(null);
    setReviewSuccess(null);

    try {
      const api = new LibraryClient(config.baseUrl);
      await api.upsertReview(
        Number(id),
        new UpsertReviewDto({
          rating: reviewForm.rating,
          content: normalizedContent,
        }),
        token
      );

      await loadBook(false);
      setReviewSuccess(
        t("reviewSaved", "Your review has been saved successfully.")
      );
    } catch (err) {
      console.error(err);
      setReviewError(
        t("reviewSaveFailed", "Could not save your review. Please try again.")
      );
    } finally {
      setReviewSubmitting(false);
    }
  };

  const handleMessageReviewer = async (reviewerUserId?: string) => {
    if (!reviewerUserId || reviewerUserId === currentUserId) {
      return;
    }

    const token = Cookies.get("auth_token");
    if (!token) {
      setReviewError(t("reviewSignIn", "Sign in to rate and review this book."));
      return;
    }

    try {
      const conversation = await startPrivateConversation(token, reviewerUserId);
      navigate("/messenger", {
        state: {
          conversationId: conversation.id,
          recipientUserId: reviewerUserId,
        },
      });
    } catch {
      setReviewError(t("chatStartFailed", "Could not start chat. Please try again."));
    }
  };

  const handleImproveReview = async () => {
    if (!reviewForm.content.trim()) {
      setReviewError(t("reviewCommentRequired", "Please write at least a short comment."));
      return;
    }

    setAiImproving(true);
    setReviewError(null);
    setReviewSuccess(null);

    try {
      const improved = await improveText(reviewForm.content, "review comment");
      setReviewForm((current) => ({ ...current, content: improved }));
      setReviewSuccess(null);
    } catch (err) {
      console.error(err);
      setReviewError(t("aiUnreachable", "AI Assistant is temporarily unavailable due to maintenance. Please try again later."));
    } finally {
      setAiImproving(false);
    }
  };

  const handleWriteReviewWithAI = async () => {
    setAiWriting(true);
    setReviewError(null);
    setReviewSuccess(null);

    try {
      const context = `${book?.title} is a ${book?.categoryName || "book"} by ${book?.authorFullName || "an author"}`;
      const ratingInfo = reviewForm.rating > 0 ? `based on a rating of ${reviewForm.rating} stars` : "";
      const prompt = `Write a brief professional book review ${ratingInfo} for "${context}".`.trim();
      const generated = await improveText(prompt, "book review");
      setReviewForm((current) => ({ ...current, content: generated }));
      setReviewSuccess(null);
    } catch (err) {
      console.error(err);
      setReviewError(t("aiUnreachable", "AI Assistant is temporarily unavailable due to maintenance. Please try again later."));
    } finally {
      setAiWriting(false);
    }
  };

  const reviews = book?.reviews ?? [];
  const reviewsCount = book?.reviewsCount ?? reviews.length;
  const averageRating = book?.averageRating ?? 0;

  if (loading)
    return (
      <p className="text-center mt-5 fw-semibold">{t("loadingBooks")}</p>
    );
  if (!book) return null;

  return (
    <div className="container detail-shell app-section">
      <button className="btn btn-outline-secondary rounded-pill px-3 mb-4" onClick={() => navigate(-1)}>
        ← {t("close")}
      </button>

      <div className="card p-4 detail-card">
        <div className="row g-4 align-items-start">
          {book.imageURL && (
            <div className="col-md-4 col-lg-3 text-center">
              <img
                src={book.imageURL}
                alt={book.title}
                className="img-fluid rounded shadow-sm book-cover"
                style={{ maxHeight: "400px", objectFit: "cover" }}
              />
            </div>
          )}

          <div className="col-md-8 col-lg-9 d-flex flex-column justify-content-between">
            <div>
              <div className="d-flex align-items-center justify-content-between mb-3">
                <h2 className="fw-bold mb-0">{book.title}</h2>
                {isAuthenticated && (
                  <button
                    type="button"
                    className="btn btn-sm p-0"
                    style={{ fontSize: "1.4rem", lineHeight: 1.2, border: "none", background: "none" }}
                    onClick={handleFavoriteToggle}
                    disabled={favoriteLoading}
                    title={isFavorite ? t("alreadyFavorited") : t("addToFavorites")}
                  >
                    {favoriteLoading ? (
                      <span className="spinner-border spinner-border-sm" />
                    ) : isFavorite ? (
                      "❤️"
                    ) : (
                      "🤍"
                    )}
                  </button>
                )}
              </div>
              <ul className="list-unstyled mb-3">
                <li>
                  <strong>{t("author")}:</strong>{" "}
                  {book.authorFullName || t("unknownAuthor")}
                </li>
                <li>
                  <strong>ISBN:</strong> {book.isbn || "N/A"}
                </li>
                <li>
                  <strong>{t("category")}:</strong>{" "}
                  {book.categoryName ? (
                    <Link
                      to={`/category/${encodeURIComponent(
                        book.categoryName.toLowerCase()
                      )}`}
                      className="text-decoration-none"
                    >
                      {t(
                        `genres.${book.categoryName.toLowerCase()}`,
                        book.categoryName
                      )}
                    </Link>
                  ) : (
                    t("uncategorized")
                  )}
                </li>
                <li>
                  <strong>{t("pages")}:</strong> {book.pages || "N/A"}
                </li>
                <li>
                  <strong>{t("published")}:</strong>{" "}
                  {book.publishedDate
                    ? new Date(book.publishedDate).toLocaleDateString()
                    : "N/A"}
                </li>
                {isAuthenticated && (
                  <li>
                    <strong>{t("statusLabel")}:</strong>{" "}
                    <span
                      className={`badge ${isPendingApproval ? "bg-warning text-dark" : "bg-success"}`}
                    >
                      {isPendingApproval
                        ? t("pendingApproval")
                        : t("approvedByAdmin")}
                    </span>
                  </li>
                )}
              </ul>

              {book.description && (
                <p className="text-muted mb-3 lh-lg">{book.description}</p>
              )}

              <div className="review-summary-card mb-3">
                <div>
                  <p className="review-summary-label mb-1">
                    {t("communityRating", "Community rating")}
                  </p>
                  <div className="d-flex align-items-center gap-2 flex-wrap">
                    <div className="review-stars" aria-label={`${averageRating} out of 5`}>
                      {renderStars(Math.round(averageRating))}
                    </div>
                    <strong>{averageRating.toFixed(1)}</strong>
                    <span className="text-muted">
                      ({reviewsCount} {t("reviews", "Reviews")})
                    </span>
                  </div>
                </div>
              </div>

              {book.favorites && (
                <p>
                  <strong>{t("favorites", "Favorites")}:</strong>{" "}
                  {book.favorites.length}
                </p>
              )}
            </div>

            <div className="mt-3">
              {isAdmin && isPendingApproval && (
                <div className="d-flex align-items-center gap-2 flex-wrap mb-2">
                  <button
                    type="button"
                    className="btn btn-success rounded-pill px-4 flex-fill"
                    onClick={handleApprove}
                    disabled={approvalLoading || declineLoading}
                  >
                    {approvalLoading ? t("approving") : t("approveBook")}
                  </button>
                  <button
                    type="button"
                    className="btn btn-outline-danger rounded-pill px-4 flex-fill"
                    onClick={handleDecline}
                    disabled={approvalLoading || declineLoading}
                  >
                    {declineLoading ? t("declining") : t("declineBook")}
                  </button>
                </div>
              )}

              {book.bookURL ? (
                 isLocalMediaUrl(book.bookURL) || book.isBookOnS3 ? (
                  <a
                    className="btn btn-primary rounded-pill px-4 w-100"
                    href={`${config.baseUrl}/api/books/${book.id}/download-pdf`}
                    download
                  >
                    📘 {t("downloadPdf")}
                  </a>
                ) : (
                  <a
                    className="btn btn-primary rounded-pill px-4 w-100"
                    href={book.bookURL}
                    target="_blank"
                    rel="noopener noreferrer"
                  >
                    🔗 {t("openLink")}
                  </a>
                )
              ) : (
                <button
                  className="btn btn-outline-secondary rounded-pill px-4 w-100"
                  disabled
                >
                  {t("noPdfAvailable")}
                </button>
              )}
            </div>
          </div>
        </div>
      </div>

      <section className="mt-4 card p-3 p-md-4 detail-card app-section">
        <div className="d-flex flex-column flex-lg-row gap-4">
          <div className="review-form-panel flex-grow-1">
            <h3 className="h5 fw-bold mb-2">
              {t("writeReview", "Rate this book")}
            </h3>
            <p className="text-muted mb-3">
              {t(
                "writeReviewHint",
                "Choose 1 to 5 stars and share a short comment about your reading experience."
              )}
            </p>

            {isAuthenticated ? (
              <>
                <div className="mb-3">
                  <label className="form-label fw-semibold d-block">
                    {t("yourRating", "Your rating")}
                  </label>
                  <div
                    className="star-picker"
                    role="radiogroup"
                    aria-label={t("yourRating", "Your rating")}
                    onMouseLeave={() => setHoveredRating(null)}
                  >
                    {Array.from({ length: 5 }, (_, index) => {
                      const value = index + 1;
                      const effectiveRating = hoveredRating ?? reviewForm.rating;
                      const isFilled = value <= effectiveRating;
                      const isPreview = hoveredRating !== null;

                      return (
                        <button
                          key={`pick-${value}`}
                          type="button"
                          className={`star-picker-btn ${isFilled ? "is-active" : ""} ${
                            isPreview ? "is-preview" : ""
                          }`}
                          aria-label={`${value} ${t("stars", "stars")}`}
                          onMouseEnter={() => setHoveredRating(value)}
                          onFocus={() => setHoveredRating(value)}
                          onBlur={() => setHoveredRating(null)}
                          onClick={() =>
                            setReviewForm((current) => ({ ...current, rating: value }))
                          }
                        >
                          ★
                        </button>
                      );
                    })}
                  </div>
                </div>

                <div className="mb-3">
                  <label htmlFor="reviewContent" className="form-label fw-semibold">
                    {t("yourComment", "Your comment")}
                  </label>
                  <textarea
                    id="reviewContent"
                    className="form-control"
                    rows={5}
                    maxLength={1000}
                    value={reviewForm.content}
                    onChange={(event) => {
                      setReviewForm((current) => ({
                        ...current,
                        content: event.target.value,
                      }));
                      if (reviewError) {
                        setReviewError(null);
                      }
                    }}
                    placeholder={t(
                      "reviewPlaceholder",
                      "What did you like or dislike about this book?"
                    )}
                  />
                  <div className="review-help-text mt-2 text-muted">
                    {reviewForm.content.trim().length}/1000
                  </div>
                </div>

                {reviewError && (
                  <div 
                    className={`alert py-2 ${reviewError.includes("temporarily unavailable") || reviewError.includes("maintenance") ? "alert-warning small" : "alert-danger"}`}
                    role="alert"
                  >
                    {reviewError}
                  </div>
                )}
                {reviewSuccess && !reviewError && (
                  <div className="alert alert-success py-2" role="alert">
                    {reviewSuccess}
                  </div>
                )}

                <div className="d-flex gap-2 mb-3 flex-wrap">
                  <button
                    type="button"
                    className="btn btn-outline-secondary rounded-pill px-3"
                    onClick={handleWriteReviewWithAI}
                    disabled={aiWriting}
                    title={t("aiWriteReview", "Generate review using AI")}
                  >
                    ✨ {aiWriting ? t("generating", "Generating...") : t("aiWrite", "Write with AI")}
                  </button>
                  {reviewForm.content.trim().length > 0 && (
                    <button
                      type="button"
                      className="btn btn-outline-secondary rounded-pill px-3"
                      onClick={handleImproveReview}
                      disabled={aiImproving}
                      title={t("aiImproveReview", "Improve review with AI")}
                    >
                      ✨ {aiImproving ? t("improving", "Improving...") : t("aiImprove", "Improve with AI")}
                    </button>
                  )}
                </div>

                <button
                  type="button"
                  className="btn btn-primary rounded-pill px-4"
                  onClick={handleReviewSubmit}
                  disabled={reviewSubmitting}
                >
                  {reviewSubmitting
                    ? t("savingReview", "Saving...")
                    : reviews.some((review) => review.applicationUserId === currentUserId)
                      ? t("updateReview", "Update review")
                      : t("submitReview", "Submit review")}
                </button>
              </>
            ) : (
              <div className="alert alert-info mb-0" role="alert">
                {t("reviewSignIn", "Sign in to rate and review this book.")}
              </div>
            )}
          </div>

          <div className="review-list-panel flex-grow-1">
            <div className="d-flex align-items-center justify-content-between mb-3">
              <h3 className="h5 fw-bold mb-0">
                {t("reviews", "Reviews")}
              </h3>
              <span className="badge bg-light text-dark rounded-pill px-3 py-2">
                {reviewsCount}
              </span>
            </div>

            {reviews.length > 0 ? (
              <div className="review-list d-flex flex-column gap-3">
                {reviews.map((review: ReviewDto) => (
                  <article
                    key={review.id ?? `${review.applicationUserId}-${review.createdAt?.toISOString()}`}
                    className={`review-item ${review.applicationUserId === currentUserId ? "is-mine" : ""}`}
                  >
                    <div className="d-flex flex-wrap align-items-center justify-content-between gap-2 mb-2">
                      <div>
                        <strong>{review.reviewerName || t("anonymousReader", "Anonymous reader")}</strong>
                        {review.applicationUserId === currentUserId && (
                          <span className="badge bg-primary-subtle text-primary-emphasis ms-2">
                            {t("yourReview", "Your review")}
                          </span>
                        )}
                      </div>

                      <div className="d-flex align-items-center gap-2 text-muted small">
                        {review.applicationUserId && review.applicationUserId !== currentUserId && (
                          <button
                            type="button"
                            className="btn btn-sm btn-outline-primary rounded-pill"
                            onClick={() => handleMessageReviewer(review.applicationUserId)}
                          >
                            {t("messageUser", "Message")}
                          </button>
                        )}
                        <span className="review-stars" aria-hidden="true">
                          {renderStars(review.rating ?? 0)}
                        </span>
                        <span>
                          {review.createdAt
                            ? new Date(review.createdAt).toLocaleDateString()
                            : ""}
                        </span>
                      </div>
                    </div>

                    <p className="mb-0 text-muted lh-lg">{review.content}</p>
                  </article>
                ))}
              </div>
            ) : (
              <p className="empty-state mb-0">
                {t("noReviewsYet", "No reviews yet. Be the first to share your thoughts.")}
              </p>
            )}
          </div>
        </div>
      </section>

      <section className="mt-4 card p-3 p-md-4 detail-card app-section">
        <h3 className="h5 fw-bold mb-3">
          {t("relatedBooks", "You may also like")}
        </h3>

        {relatedLoading ? (
          <p className="loading-text mb-0">{t("loadingBooks")}</p>
        ) : relatedBooks.length === 0 ? (
          <p className="empty-state mb-0">
            {t("noRelatedBooks", "No related books available yet.")}
          </p>
        ) : (
          <div className="row g-3">
            {relatedBooks.map((relatedBook) => (
              <div
                key={`${relatedBook.id ?? "book"}-${relatedBook.title ?? "item"}`}
                className="col-6 col-md-4 col-lg-3"
              >
                <article className="book-card h-100">
                  {relatedBook.imageURL && (
                    <img
                      src={relatedBook.imageURL}
                      alt={relatedBook.title}
                      className="book-cover"
                      style={{ height: "210px" }}
                    />
                  )}

                  <div className="p-2 p-md-3 d-flex flex-column gap-2">
                    <h4 className="h6 mb-0 book-title text-truncate" title={relatedBook.title}>
                      {relatedBook.title || t("unknown")}
                    </h4>

                    <button
                      type="button"
                      className="btn btn-outline-primary btn-sm rounded-pill mt-auto"
                      onClick={() =>
                        relatedBook.id && navigate(`/bookdetails/${relatedBook.id}`)
                      }
                    >
                      {t("read")}
                    </button>
                  </div>
                </article>
              </div>
            ))}
          </div>
        )}
      </section>
    </div>
  );
};

export default BookDetail;
