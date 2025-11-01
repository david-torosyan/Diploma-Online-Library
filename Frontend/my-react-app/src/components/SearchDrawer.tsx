import React, { useEffect, useState, useCallback } from "react";
import { Link } from "react-router-dom";
import { LibraryClient, BookWithDetailsDto } from "../api/LibraryClient";
import config from "../config/config.json";
import BookDetailFromAi from "../pages/BookDetailFromAi";
import { Offcanvas } from "bootstrap";
import { useTranslation } from "react-i18next";

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

  // 🔎 Debounce logic for auto-search
  useEffect(() => {
    if (query.length < 3) {
      setResults([]);
      return;
    }

    const delayDebounce = setTimeout(() => {
      handleSearch(query, false);
    }, 500);

    return () => clearTimeout(delayDebounce);
  }, [query]);

  // 🔍 Main search function
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
          // 🤖 AI mode
          setAiThinking(true);
          const aiBookResult = await api.getBook(text);

          if (aiBookResult) {
            setResults([aiBookResult]);
            setIsAiResult(true);
            setAiBook(aiBookResult);

            // 🎬 Automatically open the AI drawer
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
      } catch (err) {
        console.error(err);
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
    <div className="mt-3 text-center">
      {/* --- Search Form --- */}
      <form
        onSubmit={handleSubmit}
        className="d-flex align-items-center justify-content-center"
        style={{ gap: "0.5rem" }}
      >
        <input
          type="text"
          className="form-control"
          placeholder={t("searchPlaceholder")}
          value={query}
          onChange={(e) => setQuery(e.target.value)}
          style={{ maxWidth: "350px" }}
          autoFocus
        />

        {query && (
          <button
            type="button"
            onClick={handleClear}
            className="btn btn-outline-secondary"
          >
            ×
          </button>
        )}

        <button type="submit" className="btn btn-primary">
          {t("searchWithAi")}
        </button>
      </form>

      {/* --- Feedback Section --- */}
      {loading && !aiThinking && (
        <p className="mt-3 text-secondary d-flex align-items-center justify-content-center gap-2">
          <div className="spinner-border spinner-border-sm text-secondary" />
          <span>{t("serverThinking")}</span>
        </p>
      )}

      {aiThinking && (
        <p className="mt-3 text-primary fw-semibold d-flex align-items-center justify-content-center gap-2">
          <div className="spinner-grow spinner-grow-sm text-primary" />
          <span>{t("aiThinking")}</span>
        </p>
      )}

      {error && <p className="text-danger mt-3">{error}</p>}

      {/* --- Results --- */}
      <div className="mt-4 container" style={{ maxWidth: "600px" }}>
        {results.length > 0 ? (
          <ul className="list-group shadow-sm">
            {results.map((book) => (
              <li
                key={book.id}
                className="list-group-item d-flex align-items-center"
                style={{
                  gap: "0.75rem",
                  padding: "0.4rem 0.6rem",
                }}
              >
                {/* Thumbnail */}
                {book.imageURL && (
                  <img
                    src={book.imageURL}
                    alt={book.title}
                    style={{
                      width: "40px",
                      height: "56px",
                      objectFit: "cover",
                      borderRadius: "4px",
                      flexShrink: 0,
                    }}
                  />
                )}

                {/* Book Info + Link */}
                <div
                  className="text-start flex-grow-1"
                  style={{ lineHeight: "1.1rem" }}
                >
                  {!isAiResult ? (
                    <Link
                      to={`/bookdetails/${book.id}`}
                      className="fw-semibold text-decoration-none text-primary"
                      style={{ fontSize: "0.95rem" }}
                    >
                      {book.title}
                    </Link>
                  ) : (
                    <button
                      className="btn btn-link fw-semibold text-primary text-decoration-none p-0"
                      style={{ fontSize: "0.95rem" }}
                      data-bs-toggle="offcanvas"
                      data-bs-target="#bookDetailFromAiDrawer"
                      onClick={() => setAiBook(book)}
                    >
                      {book.title}
                    </button>
                  )}

                  <div className="text-muted" style={{ fontSize: "0.8rem" }}>
                    {book.authorFullName || t("unknownAuthor")}
                  </div>
                  <div
                    className="text-secondary"
                    style={{ fontSize: "0.75rem" }}
                  >
                    {book.categoryName || t("uncategorized")}
                  </div>
                </div>

                {/* Optional external link */}
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
            <p className="text-muted">
              {t("noResultsStart")} <strong>{query}</strong>.{" "}
              {t("noResultsEnd")}
            </p>
          )
        )}
      </div>

      {/* --- AI Drawer --- */}
      <BookDetailFromAi book={aiBook} />
    </div>
  );
};

export default SearchDrawer;
