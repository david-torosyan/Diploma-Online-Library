import React, { useRef } from "react";
import { useTranslation } from "react-i18next";
import { Link, useNavigate } from "react-router-dom";
import { BookDto } from "../api/LibraryClient";
import { createGenreTheme } from "../utils/genreTheme";

interface CuratedBooksShelfProps {
  title: string;
  subtitle?: string;
  books: BookDto[];
  loading: boolean;
  openAllHref?: string;
}

const CuratedBooksShelf: React.FC<CuratedBooksShelfProps> = ({
  title,
  subtitle,
  books,
  loading,
  openAllHref,
}) => {
  const { t } = useTranslation();
  const listRef = useRef<HTMLDivElement>(null);
  const navigate = useNavigate();

  const scroll = (direction: "left" | "right") => {
    const distance = direction === "left" ? -320 : 320;
    listRef.current?.scrollBy({ left: distance, behavior: "smooth" });
  };

  if (loading) {
    return (
      <section className="container mb-4 app-section">
        <div className="curated-shelf p-3 p-md-4">
          <h3 className="h5 fw-bold mb-2">{title}</h3>
          {subtitle && <p className="text-muted mb-3">{subtitle}</p>}
          <div className="d-flex gap-3">
            {[...Array(5)].map((_, index) => (
              <div key={index} className="curated-skeleton" />
            ))}
          </div>
        </div>
      </section>
    );
  }

  if (books.length === 0) {
    return null;
  }

  return (
    <section className="container mb-4 app-section">
      <div className="curated-shelf p-3 p-md-4">
        <div className="d-flex justify-content-between align-items-start gap-3 mb-3">
          <div>
            <h3 className="h5 fw-bold mb-1">
              {openAllHref ? (
                <Link to={openAllHref} className="curated-title-link">
                  {title}
                </Link>
              ) : (
                title
              )}
            </h3>
            {subtitle && <p className="text-muted mb-0">{subtitle}</p>}
          </div>

          <div className="d-none d-md-flex gap-2">
            <button
              type="button"
              className="btn btn-outline-primary btn-sm rounded-pill px-3"
              onClick={() => scroll("left")}
              aria-label={t("scrollLeft")}
            >
              ←
            </button>
            <button
              type="button"
              className="btn btn-outline-primary btn-sm rounded-pill px-3"
              onClick={() => scroll("right")}
              aria-label={t("scrollRight")}
            >
              →
            </button>
          </div>
        </div>

        <div ref={listRef} className="d-flex gap-3 curated-track overflow-auto pb-1">
          {books.map((book) => {
            const theme = createGenreTheme(book.categoryName || "");

            return (
              <article
                key={book.id || `${book.title}-${book.categoryName}`}
                className="curated-item"
                style={{
                  borderColor: theme.border,
                  background: `linear-gradient(180deg, ${theme.soft}, #ffffff)`,
                }}
              >
                <div className="curated-cover-wrap">
                  {book.imageURL ? (
                    <img
                      src={book.imageURL}
                      alt={book.title}
                      className="curated-cover"
                    />
                  ) : (
                    <div className="curated-cover-placeholder">📚</div>
                  )}
                </div>

                <div className="p-2 p-md-3 d-flex flex-column gap-2">
                  <h4 className="h6 mb-0 curated-title" title={book.title || ""}>
                    {book.title || t("unknown")}
                  </h4>

                  {book.categoryName && (
                    <Link
                      className="curated-pill"
                      to={`/category/${encodeURIComponent(book.categoryName)}`}
                      style={{
                        color: theme.accentDeep,
                        backgroundColor: theme.soft,
                        borderColor: theme.border,
                      }}
                    >
                      {t(
                        `genres.${book.categoryName.toLowerCase()}`,
                        book.categoryName
                      )}
                    </Link>
                  )}

                  <button
                    type="button"
                    className="btn btn-sm btn-primary rounded-pill"
                    onClick={() => book.id && navigate(`/bookdetails/${book.id}`)}
                    disabled={!book.id}
                  >
                    {t("read")}
                  </button>
                </div>
              </article>
            );
          })}
        </div>
      </div>
    </section>
  );
};

export default CuratedBooksShelf;
