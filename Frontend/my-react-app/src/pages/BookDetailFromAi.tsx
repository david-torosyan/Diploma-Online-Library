import React from "react";
import { BookWithDetailsDto } from "../api/LibraryClient";
import { useTranslation } from "react-i18next";

interface BookDetailFromAiProps {
  book: BookWithDetailsDto | null;
  detailsLink?: string;
}

const BookDetailFromAi: React.FC<BookDetailFromAiProps> = ({
  book,
  detailsLink,
}) => {
  const { t } = useTranslation();

  if (!book) return null;

  return (
    <div
      className="offcanvas offcanvas-end"
      tabIndex={-1}
      id="bookDetailFromAiDrawer"
      aria-labelledby="bookDetailFromAiLabel"
    >
      <div className="offcanvas-header bg-primary text-white">
        <h5 id="bookDetailFromAiLabel" className="offcanvas-title">
          📖 {book.title || t("bookDetails")}
        </h5>
        <button
          type="button"
          className="btn-close btn-close-white"
          data-bs-dismiss="offcanvas"
          aria-label={t("close")}
        ></button>
      </div>

      <div className="offcanvas-body">
        <div className="card border-0 shadow-sm p-3">
          {/* Book cover */}
          {book.imageURL && (
            <div className="text-center mb-3">
              <img
                src={book.imageURL}
                alt={book.title}
                className="img-fluid rounded shadow-sm"
                style={{ maxHeight: "350px", objectFit: "cover" }}
              />
            </div>
          )}

          {/* Book info */}
          <h5 className="fw-bold mb-3">{book.title}</h5>
          <ul className="list-unstyled mb-3">
            <li>
              <strong>{t("author")}:</strong>{" "}
              {book.authorFullName || t("unknown")}
            </li>
            <li>
              <strong>ISBN:</strong> {book.isbn || "N/A"}
            </li>
            <li>
              <strong>{t("category")}:</strong>{" "}
              {book.categoryName || t("unknown")}
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

          {/* View full details button */}
          {detailsLink && (
            <a
              href={detailsLink}
              className="btn btn-outline-primary w-100 mb-2"
            >
              🔗 {t("viewFullDetails")}
            </a>
          )}

          {/* PDF download */}
          {book.bookURL ? (
            <a
              href={book.bookURL}
              className="btn btn-primary w-100"
              target="_blank"
              rel="noopener noreferrer"
            >
              📘 {t("downloadPdf")}
            </a>
          ) : (
            <button className="btn btn-outline-secondary w-100" disabled>
              {t("noPdfAvailable")}
            </button>
          )}
        </div>
      </div>
    </div>
  );
};

export default BookDetailFromAi;
