import React, { useEffect, useState, useCallback, useRef } from "react";
import { Link } from "react-router-dom";
import { LibraryClient, BookWithDetailsDto } from "../api/LibraryClient";
import { Offcanvas } from "bootstrap";
import { useTranslation } from "react-i18next";
import config from "../config/config";
import BookDetailFromAi from "../pages/BookDetailFromAi";
import { getSearchSuggestions } from "../services/discoveryService";

import backgroundImage from "../assets/grand-library.jpg";

const isLocalMediaUrl = (url?: string) => !!url && url.includes("/media/");

const SearchDrawer: React.FC = () => {
  const { t } = useTranslation();

  const [query, setQuery] = useState("");
  const [results, setResults] = useState<BookWithDetailsDto[]>([]);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const [isAiResult, setIsAiResult] = useState(false);
  const [aiBook, setAiBook] = useState<BookWithDetailsDto | null>(null);
  const [aiThinking, setAiThinking] = useState(false);
  const [suggestions, setSuggestions] = useState<string[]>([]);
  const [showSuggestions, setShowSuggestions] = useState(false);
  const aiDrawerTimeoutRef = useRef<ReturnType<typeof setTimeout> | null>(null);
  const blurTimeoutRef = useRef<ReturnType<typeof setTimeout> | null>(null);

  useEffect(() => {
    return () => {
      if (aiDrawerTimeoutRef.current) {
        clearTimeout(aiDrawerTimeoutRef.current);
      }
      if (blurTimeoutRef.current) {
        clearTimeout(blurTimeoutRef.current);
      }
    };
  }, []);

  useEffect(() => {
    if (query.trim().length < 2) {
      setSuggestions([]);
      return;
    }

    let isCurrent = true;

    const delay = setTimeout(async () => {
      const nextSuggestions = await getSearchSuggestions(query, 6);
      if (isCurrent) {
        setSuggestions(nextSuggestions);
      }
    }, 250);

    return () => {
      isCurrent = false;
      clearTimeout(delay);
    };
  }, [query]);

  // --- Search Function ---
  const handleSearch = useCallback(
    async (text: string, force = true) => {
      if (!text || text.length < 3) return;

      const api = new LibraryClient(config.baseUrl);

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

            if (aiDrawerTimeoutRef.current) {
              clearTimeout(aiDrawerTimeoutRef.current);
            }

            aiDrawerTimeoutRef.current = setTimeout(() => {
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
    [t]
  );

  // --- Debounce logic for auto-search ---
  useEffect(() => {
    if (query.length < 3) {
      setResults([]);
      return;
    }

    const delay = setTimeout(() => handleSearch(query, false), 500);
    return () => clearTimeout(delay);
  }, [query, handleSearch]);

  const handleClear = () => {
    setQuery("");
    setResults([]);
    setSuggestions([]);
    setShowSuggestions(false);
  };

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    setShowSuggestions(false);
    handleSearch(query, true);
  };

  const applySuggestion = (value: string) => {
    setQuery(value);
    setShowSuggestions(false);
    handleSearch(value, false);
  };

  return (
    <section
      className="position-relative text-center text-white rounded-4 shadow my-4 py-4 px-3"
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
        <form onSubmit={handleSubmit} className="d-flex justify-content-center w-100">
          <div className="search-box-wrap d-flex align-items-center justify-content-center flex-wrap gap-2">
            <div className="position-relative search-input-wrap">
              <input
                type="text"
                className="form-control"
                placeholder={t("searchPlaceholder")}
                value={query}
                onChange={(e) => {
                  setQuery(e.target.value);
                  setShowSuggestions(true);
                }}
                onFocus={() => setShowSuggestions(true)}
                onBlur={() => {
                  if (blurTimeoutRef.current) {
                    clearTimeout(blurTimeoutRef.current);
                  }
                  blurTimeoutRef.current = setTimeout(() => setShowSuggestions(false), 120);
                }}
                style={{ maxWidth: "350px" }}
              />

              {showSuggestions && suggestions.length > 0 && (
                <div className="search-suggestions-menu shadow-sm">
                  {suggestions.map((suggestion) => (
                    <button
                      key={suggestion}
                      type="button"
                      className="search-suggestion-btn"
                      onMouseDown={(event) => event.preventDefault()}
                      onClick={() => applySuggestion(suggestion)}
                    >
                      {suggestion}
                    </button>
                  ))}
                </div>
              )}
            </div>

          {query && (
            <button
              type="button"
              onClick={handleClear}
              className="btn btn-outline-light rounded-pill"
            >
              ×
            </button>
          )}
          <button type="submit" className="btn btn-success rounded-pill px-4">
            {t("searchWithAi")}
          </button>
          </div>
        </form>

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

        <div className="mt-4 container" style={{ maxWidth: "600px" }}>
          {results.length > 0 ? (
            <ul className={`list-group shadow search-results-list ${isAiResult ? "ai-search-results-list" : ""}`}>
              {results.map((book) => (
                <li
                  key={book.id}
                  className="list-group-item d-flex align-items-center search-result-item"
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

                  {!isAiResult && book.bookURL &&
                      (isLocalMediaUrl(book.bookURL) || book.isBookOnS3 ? (
                      <a
                        href={
                          book.id && book.id > 0
                            ? `${config.baseUrl}/api/books/${book.id}/download-pdf`
                            : book.bookURL
                        }
                        download
                        className="btn btn-sm btn-outline-primary px-2 py-0 rounded-pill"
                        style={{ fontSize: "0.75rem", height: "26px" }}
                      >
                        PDF
                      </a>
                    ) : (
                      <a
                        href={book.bookURL}
                        target="_blank"
                        rel="noopener noreferrer"
                        className="btn btn-sm btn-outline-primary px-2 py-0 rounded-pill"
                        style={{ fontSize: "0.75rem", height: "26px" }}
                      >
                        🔗 {t("openLink")}
                      </a>
                    ))}
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

        <BookDetailFromAi book={aiBook} />
      </div>
    </section>
  );
};

export default SearchDrawer;
