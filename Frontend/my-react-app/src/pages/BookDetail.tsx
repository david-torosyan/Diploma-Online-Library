import React, { useEffect, useState } from "react";
import { useParams, useNavigate } from "react-router-dom";
import { LibraryClient, BookWithDetailsDto } from "../api/LibraryClient";
import { useTranslation } from "react-i18next";
import config from "../config/config.json";

const BookDetail: React.FC = () => {
  const { id } = useParams<{ id: string }>();
  const navigate = useNavigate();
  const [book, setBook] = useState<BookWithDetailsDto>();
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
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
              <h2 className="fw-bold mb-3">{book.title}</h2>
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
