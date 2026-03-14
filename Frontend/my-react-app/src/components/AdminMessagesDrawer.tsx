import React, { useCallback, useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { LibraryClient, BookDto } from "../api/LibraryClient";
import { useTranslation } from "react-i18next";
import config from "../config/config.json";
import { getAuthToken } from "../utils/auth";

const AdminMessagesDrawer: React.FC = () => {
  const { t } = useTranslation();
  const navigate = useNavigate();
  const [books, setBooks] = useState<BookDto[]>([]);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);

  const loadUnapproved = useCallback(async () => {
    const token = getAuthToken();
    if (!token) {
      setBooks([]);
      return;
    }

    setLoading(true);
    setError(null);

    try {
      const api = new LibraryClient(config.baseUrl);
      const result = await api.unapproved(token);
      setBooks(Array.isArray(result) ? result : []);
    } catch {
      setError(t("fetchError"));
    } finally {
      setLoading(false);
    }
  }, [t]);

  useEffect(() => {
    const drawer = document.getElementById("adminMessagesDrawer");
    if (!drawer) return;

    drawer.addEventListener("show.bs.offcanvas", loadUnapproved);

    return () => {
      drawer.removeEventListener("show.bs.offcanvas", loadUnapproved);
    };
  }, [loadUnapproved]);

  const openBook = (id?: number) => {
    if (!id) return;
    navigate(`/bookdetails/${id}`);
  };

  return (
    <div
      className="offcanvas offcanvas-end"
      tabIndex={-1}
      id="adminMessagesDrawer"
      aria-labelledby="adminMessagesDrawerLabel"
    >
      <div className="offcanvas-header">
        <h5 id="adminMessagesDrawerLabel" className="offcanvas-title">
          🔔 {t("messages")}
        </h5>
        <button
          type="button"
          className="btn-close text-reset"
          data-bs-dismiss="offcanvas"
          aria-label={t("close")}
        ></button>
      </div>

      <div className="offcanvas-body">
        <h6 className="mb-3">{t("unapprovedBooks")}</h6>

        {loading ? (
          <div className="d-flex justify-content-center align-items-center gap-2 loading-text mt-3">
            <div className="spinner-border spinner-border-sm" />
            <span>{t("loadingBooks")}</span>
          </div>
        ) : error ? (
          <p className="text-danger mt-2">{error}</p>
        ) : books.length === 0 ? (
          <p className="empty-state mb-0">{t("noUnapprovedBooks")}</p>
        ) : (
          <ul className="list-group search-results-list">
            {books.map((book) => (
              <li
                key={`${book.id ?? "book"}-${book.title ?? "item"}`}
                className="list-group-item d-flex align-items-center"
                style={{ gap: "0.75rem" }}
              >
                {book.imageURL ? (
                  <img
                    src={book.imageURL}
                    alt={book.title}
                    className="rounded"
                    style={{ width: "40px", height: "56px", objectFit: "cover", flexShrink: 0 }}
                  />
                ) : null}

                <div className="flex-grow-1">
                  <button
                    type="button"
                    className="btn btn-link fw-semibold text-decoration-none text-primary p-0"
                    data-bs-dismiss="offcanvas"
                    onClick={() => openBook(book.id)}
                  >
                    {book.title}
                  </button>
                  <div className="small text-secondary">
                    {t("pendingApproval")}
                  </div>
                </div>
              </li>
            ))}
          </ul>
        )}
      </div>
    </div>
  );
};

export default AdminMessagesDrawer;
