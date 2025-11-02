import React, { useEffect, useState, useCallback } from "react";
import { Link } from "react-router-dom";
import { LibraryClient, BookWithDetailsDto } from "../api/LibraryClient";
import { Offcanvas } from "bootstrap";
import { useTranslation } from "react-i18next";
import config from "../config/config.json";
import BookDetailFromAi from "../pages/BookDetailFromAi";

import backgroundImage from "../assets/grand-library.jpg";

const SearchDrawer: React.FC = () => {
  const { t } = useTranslation();

  const [query, setQuery] = useState("");
  const [results, setResults] = useState<BookWithDetailsDto[]>([]);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const [isAiResult, setIsAiResult] = useState(false);
  const [aiBook, setAiBook] = useState<BookWithDetailsDto | null>(null);
  const [aiThinking, setAiThinking] = useState(false);

  const api = new LibraryClient(config.baseUrl);

  // --- Debounce logic for auto-search ---
  useEffect(() => {
    if (query.length < 3) {
      setResults([]);
      return;
    }
    const delay = setTimeout(() => handleSearch(query, false), 500);
    return () => clearTimeout(delay);
  }, [query]);

  // --- Search Function ---
  const handleSearch = useCallback(
    async (text: string, force = true) => {
      if (!text || text.length < 3) return;

      setLoading(true);
      setError(null);
      setAiThinking(false);

      try {
        const found = await api.bookName(text);

        if (found && found.length > 0) {
          setResults(found);
          setIsAiResult(false);
          setAiBook(null);
        } else if (force) {
          setAiThinking(true);
          const aiBookResult = await api.getBook(text);

          if (aiBookResult) {
            setResults([aiBookResult]);
            setIsAiResult(true);
            setAiBook(aiBookResult);
            setTimeout(() => {
              const drawerEl = document.getElementById("bookDetailFromAiDrawer");
              if (drawerEl) {
                const offcanvas = Offcanvas.getOrCreateInstance(drawerEl);
                offcanvas.show();
              }
            }, 300);
          } else {
            setResults([]);
            setIsAiResult(false);
            setAiBook(null);
          }
        } else {
          setResults([]);
          setIsAiResult(false);
          setAiBook(null);
        }
      } catch {
        setError(t("fetchError"));
      } finally {
        setLoading(false);
        setAiThinking(false);
      }
    },
    [api, t]
  );

  const handleClear = () => {
    setQuery("");
    setResults([]);
  };

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    handleSearch(query, true);
  };

  return (
    <section
      className="position-relative text-center text-white rounded shadow my-4 py-4 px-3"
      style={{
        backgroundImage: `url(${backgroundImage})`,
        backgroundSize: "cover",
        backgroundPosition: "center",
        backgroundRepeat: "no-repeat",
        overflow: "hidden",
      }}
    >
      {/* Overlay */}
      <div
        className="position-absolute top-0 start-0 w-100 h-100 bg-dark opacity-50"
        style={{ zIndex: 0 }}
      ></div>

      <div className="position-relative" style={{ zIndex: 1 }}>
        {/* --- Search Form --- */}
        <form
          onSubmit={handleSubmit}
          className="d-flex align-items-center justify-content-center flex-wrap gap-2"
        >
          <input
            type="text"
            className="form-control w-auto"
            placeholder={t("searchPlaceholder")}
            value={query}
            onChange={(e) => setQuery(e.target.value)}
            style={{ maxWidth: "350px" }}
          />
          {query && (
            <button
              type="button"
              onClick={handleClear}
              className="btn btn-outline-light"
            >
              ×
            </button>
          )}
          <button type="submit" className="btn btn-success">
            {t("searchWithAi")}
          </button>
        </form>

        {/* --- Feedback Section --- */}
        {loading && !aiThinking && (
          <div className="mt-3 d-flex justify-content-center align-items-center gap-2 text-light">
            <div className="spinner-border spinner-border-sm text-light" />
            <span>{t("serverThinking")}</span>
          </div>
        )}

        {aiThinking && (
          <div className="mt-3 d-flex justify-content-center align-items-center gap-2 text-warning">
            <div className="spinner-grow spinner-grow-sm text-warning" />
            <span>{t("aiThinking")}</span>
          </div>
        )}

        {error && <p className="text-danger mt-3">{error}</p>}

        {/* --- Results --- */}
        <div className="mt-4 container" style={{ maxWidth: "600px" }}>
          {results.length > 0 ? (
            <ul className="list-group shadow">
              {results.map((book) => (
                <li
                  key={book.id}
                  className="list-group-item d-flex align-items-center"
                  style={{ gap: "0.75rem" }}
                >
                  {book.imageURL && (
                    <img
                      src={book.imageURL}
                      alt={book.title}
                      className="rounded"
                      style={{
                        width: "40px",
                        height: "56px",
                        objectFit: "cover",
                        flexShrink: 0,
                      }}
                    />
                  )}

                  <div className="text-start flex-grow-1">
                    {!isAiResult ? (
                      <Link
                        to={`/bookdetails/${book.id}`}
                        className="fw-semibold text-decoration-none text-primary"
                      >
                        {book.title}
                      </Link>
                    ) : (
                      <button
                        className="btn btn-link fw-semibold text-primary text-decoration-none p-0"
                        data-bs-toggle="offcanvas"
                        data-bs-target="#bookDetailFromAiDrawer"
                        onClick={() => setAiBook(book)}
                      >
                        {book.title}
                      </button>
                    )}

                    <div className="text-muted small">
                      {book.authorFullName || t("unknownAuthor")}
                    </div>
                    <div className="text-secondary small">
                      {book.categoryName || t("uncategorized")}
                    </div>
                  </div>

                  {!isAiResult && book.bookURL && (
                    <a
                      href={book.bookURL}
                      target="_blank"
                      rel="noopener noreferrer"
                      className="btn btn-sm btn-outline-primary px-2 py-0"
                      style={{ fontSize: "0.75rem", height: "26px" }}
                    >
                      PDF
                    </a>
                  )}
                </li>
              ))}
            </ul>
          ) : (
            query.length >= 3 &&
            !loading && (
              <p className="mt-3">
                {t("noResultsStart")} <strong>{query}</strong>.{" "}
                {t("noResultsEnd")}
              </p>
            )
          )}
        </div>

        {/* --- AI Drawer --- */}
        <BookDetailFromAi book={aiBook} />
      </div>
    </section>
  );
};

export default SearchDrawer;
