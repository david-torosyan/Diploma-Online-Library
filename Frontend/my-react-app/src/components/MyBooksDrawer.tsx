import React, { useCallback, useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import Cookies from "js-cookie";
import { useTranslation } from "react-i18next";
import { LibraryClient, BookDto } from "../api/LibraryClient";
import config from "../config/config";

const MyBooksDrawer: React.FC = () => {
  const { t } = useTranslation();
  const navigate = useNavigate();
  const [books, setBooks] = useState<BookDto[]>([]);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);

  const openBookDetail = (id?: number) => {
    if (!id) return;
    navigate(`/bookdetails/${id}`);
  };

  const fetchFavorites = useCallback(async () => {
    const token = Cookies.get("auth_token");
    if (!token) {
      setBooks([]);
      return;
    }

    setLoading(true);
    setError(null);

    try {
      const api = new LibraryClient(config.baseUrl);
      const result = await api.myFavoritesAll(token);
      setBooks(Array.isArray(result) ? result : []);
    } catch {
      setError(t("fetchError"));
    } finally {
      setLoading(false);
    }
  }, [t]);

  useEffect(() => {
    fetchFavorites();
  }, [fetchFavorites]);

  useEffect(() => {
    const drawer = document.getElementById("myBooksDrawer");
    if (!drawer) return;

    drawer.addEventListener("show.bs.offcanvas", fetchFavorites);
    return () => {
      drawer.removeEventListener("show.bs.offcanvas", fetchFavorites);
    };
  }, [fetchFavorites]);

  return (
    <div
      className="offcanvas offcanvas-end app-drawer my-books-drawer"
      tabIndex={-1}
      id="myBooksDrawer"
      aria-labelledby="myBooksDrawerLabel"
    >
      <div className="offcanvas-header">
        <h5 id="myBooksDrawerLabel" className="offcanvas-title">
          ❤️ {t("myBooks")} ({books.length})
        </h5>
        <button
          type="button"
          className="btn-close text-reset"
          data-bs-dismiss="offcanvas"
          aria-label={t("close")}
        ></button>
      </div>

      <div className="offcanvas-body drawer-body">
        {loading ? (
          <div className="d-flex justify-content-center align-items-center gap-2 loading-text mt-3">
            <div className="spinner-border spinner-border-sm" />
            <span>{t("loadingBooks")}</span>
          </div>
        ) : error ? (
          <p className="text-danger mt-2">{error}</p>
        ) : books.length === 0 ? (
          <p className="empty-state mb-0">{t("noMyBooksYet")}</p>
        ) : (
          <ul className="list-group search-results-list drawer-list my-books-list">
            {books.map((book) => (
              <li
                key={`${book.id ?? "book"}-${book.title ?? "item"}`}
                className="list-group-item d-flex align-items-center drawer-list-item"
              >
                {book.imageURL ? (
                  <img
                    src={book.imageURL}
                    alt={book.title}
                    className="rounded drawer-thumb"
                    style={{ width: "40px", height: "56px", objectFit: "cover", flexShrink: 0 }}
                  />
                ) : (
                  <div className="drawer-thumb-fallback" aria-hidden="true">
                    📘
                  </div>
                )}

                <div className="flex-grow-1 drawer-item-content">
                  <button
                    type="button"
                    className="btn btn-link fw-semibold text-decoration-none text-primary p-0 drawer-title-link"
                    data-bs-dismiss="offcanvas"
                    onClick={() => openBookDetail(book.id)}
                  >
                    {book.title}
                  </button>
                  <div className="small text-secondary drawer-meta">
                    {book.categoryName || t("uncategorized")}
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

export default MyBooksDrawer;
