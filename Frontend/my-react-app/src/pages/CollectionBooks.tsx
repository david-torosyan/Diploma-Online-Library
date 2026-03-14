import React, { useEffect, useMemo, useState } from "react";
import { Link, useNavigate, useParams } from "react-router-dom";
import { useTranslation } from "react-i18next";
import { BookDto } from "../api/LibraryClient";
import { getFeaturedBooks, getNewArrivals } from "../services/discoveryService";

const CollectionBooks: React.FC = () => {
  const { collectionType } = useParams<{ collectionType: string }>();
  const navigate = useNavigate();
  const { t } = useTranslation();

  const [books, setBooks] = useState<BookDto[]>([]);
  const [loading, setLoading] = useState(true);

  const isFeatured = collectionType === "featured";
  const isNewArrivals = collectionType === "new-arrivals";

  const title = useMemo(() => {
    if (isFeatured) {
      return t("featuredBooks", "Featured Books");
    }

    if (isNewArrivals) {
      return t("newArrivals", "New Arrivals");
    }

    return t("library");
  }, [isFeatured, isNewArrivals, t]);

  useEffect(() => {
    const loadCollection = async () => {
      try {
        if (isFeatured) {
          setBooks(await getFeaturedBooks(40));
          return;
        }

        if (isNewArrivals) {
          setBooks(await getNewArrivals(40));
          return;
        }

        setBooks([]);
      } finally {
        setLoading(false);
      }
    };

    loadCollection();
  }, [isFeatured, isNewArrivals]);

  if (!isFeatured && !isNewArrivals) {
    return (
      <div className="container category-shell app-section">
        <p className="text-danger">{t("fetchError")}</p>
        <Link to="/" className="btn btn-outline-primary rounded-pill px-3">
          {t("library")}
        </Link>
      </div>
    );
  }

  return (
    <div className="container category-shell app-section">
      <div className="mb-3 d-flex flex-wrap gap-2">
        <button
          className="btn btn-outline-secondary btn-sm rounded-pill px-3"
          onClick={() => navigate(-1)}
        >
          ← {t("close")}
        </button>
        <Link to="/" className="btn btn-outline-secondary btn-sm rounded-pill px-3">
          {t("library")}
        </Link>
      </div>

      <div className="category-header mb-4">
        <h1 className="h3 fw-bold mb-1">{title}</h1>
        <p className="text-muted mb-0">{t("library")}</p>
      </div>

      {loading ? (
        <p className="loading-text text-center my-4">{t("loadingBooks")}</p>
      ) : books.length === 0 ? (
        <p className="empty-state text-center my-4">{t("fetchError")}</p>
      ) : (
        <div className="row g-3">
          {books.map((book) => (
            <div
              key={`${book.id ?? "book"}-${book.title ?? "item"}`}
              className="col-6 col-sm-4 col-md-3 col-lg-2"
            >
              <article className="book-card h-100">
                {book.imageURL && (
                  <img
                    src={book.imageURL}
                    alt={book.title}
                    className="book-cover"
                    style={{ height: "220px" }}
                  />
                )}

                <div className="card-body text-center p-2 d-flex flex-column">
                  <h6 className="card-title text-truncate book-title" title={book.title}>
                    {book.title || t("unknown")}
                  </h6>

                  <button
                    className="btn btn-sm btn-outline-primary w-100 mt-1 book-action-btn"
                    onClick={() => book.id && navigate(`/bookdetails/${book.id}`)}
                    disabled={!book.id}
                  >
                    {t("read")}
                  </button>
                </div>
              </article>
            </div>
          ))}
        </div>
      )}
    </div>
  );
};

export default CollectionBooks;
