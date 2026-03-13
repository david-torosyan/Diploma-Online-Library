import React, { useEffect, useState, useCallback } from "react";
import { useParams, useNavigate } from "react-router-dom";
import { LibraryClient, BookWithDetailsDto } from "../api/LibraryClient";
import { useTranslation } from "react-i18next";
import config from "../config/config.json";
import Cookies from "js-cookie";

const BookDetail: React.FC = () => {
  const { id } = useParams<{ id: string }>();
  const navigate = useNavigate();
  const [book, setBook] = useState<BookWithDetailsDto>();
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [isAuthenticated, setIsAuthenticated] = useState(false);
  const [isFavorite, setIsFavorite] = useState(false);
  const [favoriteLoading, setFavoriteLoading] = useState(false);
  const { t } = useTranslation();

  useEffect(() => {
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
    <div className="container my-5">
      <button className="btn btn-secondary mb-4" onClick={() => navigate(-1)}>
        ← {t("close")}
      </button>

      <div className="card p-4 shadow-sm border-0">
        <div className="row g-4 align-items-start">
          {/* Book Cover */}
          {book.imageURL && (
            <div className="col-md-4 col-lg-3 text-center">
              <img
                src={book.imageURL}
                alt={book.title}
                className="img-fluid rounded shadow-sm"
                style={{ maxHeight: "400px", objectFit: "cover" }}
              />
            </div>
          )}

          {/* Book Details */}
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
                  {book.categoryName
                    ? t(`genres.${book.categoryName.toLowerCase()}`, book.categoryName)
                    : t("uncategorized")}
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
              </ul>

              {book.description && (
                <p className="text-muted mb-3">{book.description}</p>
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
              {book.bookURL ? (
                <a
                  className="btn btn-primary w-100 w-sm-auto"
                  href={book.bookURL}
                  target="_blank"
                  rel="noopener noreferrer"
                >
                  📘 {t("downloadPdf")}
                </a>
              ) : (
                <button
                  className="btn btn-outline-secondary w-100 w-sm-auto"
                  disabled
                >
                  {t("noPdfAvailable")}
                </button>
              )}
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default BookDetail;
