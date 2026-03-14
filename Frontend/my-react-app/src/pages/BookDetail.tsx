import React, { useEffect, useState, useCallback } from "react";
import { Link, useParams, useNavigate } from "react-router-dom";
import { LibraryClient, BookDto, BookWithDetailsDto } from "../api/LibraryClient";
import { useTranslation } from "react-i18next";
import config from "../config/config.json";
import Cookies from "js-cookie";
import { isAdminUser } from "../utils/auth";
import { getRelatedBooks } from "../services/discoveryService";

const BookDetail: React.FC = () => {
  const { id } = useParams<{ id: string }>();
  const navigate = useNavigate();
  const [book, setBook] = useState<BookWithDetailsDto>();
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [isAuthenticated, setIsAuthenticated] = useState(false);
  const [isAdmin, setIsAdmin] = useState(false);
  const [isFavorite, setIsFavorite] = useState(false);
  const [favoriteLoading, setFavoriteLoading] = useState(false);
  const [isPendingApproval, setIsPendingApproval] = useState(false);
  const [approvalLoading, setApprovalLoading] = useState(false);
  const [relatedBooks, setRelatedBooks] = useState<BookDto[]>([]);
  const [relatedLoading, setRelatedLoading] = useState(false);
  const { t } = useTranslation();

  useEffect(() => {
    setIsAdmin(isAdminUser());

    const fetchBook = async () => {
      if (!id) return;

      try {
        const api = new LibraryClient(config.baseUrl);
        const result = await api.id(Number(id));

        if (result) {
          setBook(result);
        } else {
          setError(t("fetchError"));
        }
      } catch (err) {
        console.error(err);
        setError(t("fetchError"));
      } finally {
        setLoading(false);
      }
    };

    fetchBook();
  }, [id, t]);

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

    const loadRelated = async () => {
      setRelatedLoading(true);
      try {
        const items = await getRelatedBooks(
          currentBookId,
          book.categoryName,
          8
        );
        setRelatedBooks(items);
      } finally {
        setRelatedLoading(false);
      }
    };

    loadRelated();
  }, [book, id]);

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
    } finally {
      setApprovalLoading(false);
    }
  };

  if (loading)
    return (
      <p className="text-center mt-5 fw-semibold">{t("loadingBooks")}</p>
    );
  if (error || !book)
    return (
      <p className="text-center mt-5 text-danger">
        {error || t("bookNotFound", "Book not found.")}
      </p>
    );

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
              </ul>

              {book.description && (
                <p className="text-muted mb-3 lh-lg">{book.description}</p>
              )}

              {book.favorites && (
                <p>
                  <strong>{t("favorites", "Favorites")}:</strong>{" "}
                  {book.favorites.length}
                </p>
              )}
              {book.reviews && (
                <p>
                  <strong>{t("reviews", "Reviews")}:</strong>{" "}
                  {book.reviews.length}
                </p>
              )}
            </div>

            <div className="mt-3">
              {isAdmin && isPendingApproval && (
                <button
                  type="button"
                  className="btn btn-success rounded-pill px-4 w-100 w-sm-auto me-2 mb-2"
                  onClick={handleApprove}
                  disabled={approvalLoading}
                >
                  {approvalLoading ? t("approving") : t("approveBook")}
                </button>
              )}

              {book.bookURL ? (
                <a
                  className="btn btn-primary rounded-pill px-4 w-100 w-sm-auto"
                  href={book.bookURL}
                  target="_blank"
                  rel="noopener noreferrer"
                >
                  📘 {t("downloadPdf")}
                </a>
              ) : (
                <button
                  className="btn btn-outline-secondary rounded-pill px-4 w-100 w-sm-auto"
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
