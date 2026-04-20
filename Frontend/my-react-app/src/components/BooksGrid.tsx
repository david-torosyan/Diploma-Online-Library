import React, { useRef, useEffect, useState, useCallback } from "react";
import { useMemo } from "react";
import { Link, useNavigate } from "react-router-dom";
import { LibraryClient, BookDto } from "../api/LibraryClient";
import { useTranslation } from "react-i18next";
import config from "../config/config";
import Cookies from "js-cookie";
import { createGenreTheme } from "../utils/genreTheme";

interface Book {
  id: string;
  title: string;
  img: string;
}

interface BooksGridProps {
  genre?: string;
  layout?: "slider" | "matrix";
  searchQuery?: string;
  sortOrder?: "default" | "title-asc" | "title-desc";
}

const BooksGrid: React.FC<BooksGridProps> = ({
  genre = "fiction",
  layout = "slider",
  searchQuery = "",
  sortOrder = "default",
}) => {
  const { t } = useTranslation();
  const genreTheme = createGenreTheme(genre);
  const containerRef = useRef<HTMLDivElement>(null);
  const navigate = useNavigate();
  const [books, setBooks] = useState<Book[]>([]);
  const [loading, setLoading] = useState(true);
  const [favoriteIds, setFavoriteIds] = useState<Set<number>>(new Set());
  const [isAuthenticated, setIsAuthenticated] = useState(false);
  const [togglingId, setTogglingId] = useState<number | null>(null);

  useEffect(() => {
    const fetchBooks = async () => {
      // const cacheKey = `booksGridData_${genre}`;
      // const storedBooks = sessionStorage.getItem(cacheKey);
      // if (storedBooks) {
      //   setBooks(JSON.parse(storedBooks));
      //   setLoading(false);
      //   return;
      // }

      try {
        const api = new LibraryClient(config.baseUrl);
        const result: BookDto[] = await api.category(genre);

        const fetchedBooks: Book[] = result.map((item) => ({
          id: item.id?.toString() || "",
          title: item.title || t("unknown"),
          img:
            item.imageURL ||
            `https://via.placeholder.com/150x220?text=${encodeURIComponent(
              item.title || t("noImage")
            )}`,
        }));

        setBooks(fetchedBooks);
        //sessionStorage.setItem(cacheKey, JSON.stringify(fetchedBooks));
      } catch (error) {
        console.error("Error fetching books:", error);
      } finally {
        setLoading(false);
      }
    };

    fetchBooks();
  }, [genre, t]);

  const loadFavorites = useCallback(async () => {
    const token = Cookies.get("auth_token");
    if (!token) return;
    setIsAuthenticated(true);
    try {
      const api = new LibraryClient(config.baseUrl);
      const favorites = await api.myFavoritesAll();
      const ids = new Set(
        favorites
          .map((f) => f.id)
          .filter((id): id is number => id !== undefined)
      );
      setFavoriteIds(ids);
    } catch {
      // silently ignore
    }
  }, []);

  useEffect(() => {
    loadFavorites();
  }, [loadFavorites]);

  const handleFavorite = async (bookId: number) => {
    const token = Cookies.get("auth_token");
    if (!token || togglingId !== null) return;

    const isFavorite = favoriteIds.has(bookId);
    const nextFavoriteState = !isFavorite;

    setTogglingId(bookId);
    try {
      const api = new LibraryClient(config.baseUrl);
      await api.myFavorites(bookId, nextFavoriteState);
      setFavoriteIds((prev) => {
        const updated = new Set(prev);
        if (nextFavoriteState) {
          updated.add(bookId);
        } else {
          updated.delete(bookId);
        }
        return updated;
      });
    } catch {
      // silently ignore
    } finally {
      setTogglingId(null);
    }
  };

  const scroll = (direction: "left" | "right") => {
    const distance = direction === "left" ? -300 : 300;
    containerRef.current?.scrollBy({ left: distance, behavior: "smooth" });
  };

  const openBookDetail = (id: string) => {
    if (!id) return;
    navigate(`/bookdetails/${id}`);
  };

  const processedBooks = useMemo(() => {
    const normalizedQuery = searchQuery.trim().toLowerCase();

    let nextBooks = books;

    if (normalizedQuery) {
      nextBooks = nextBooks.filter((book) =>
        (book.title || "").toLowerCase().includes(normalizedQuery)
      );
    }

    if (sortOrder === "title-asc") {
      return [...nextBooks].sort((left, right) =>
        (left.title || "").localeCompare(right.title || "")
      );
    }

    if (sortOrder === "title-desc") {
      return [...nextBooks].sort((left, right) =>
        (right.title || "").localeCompare(left.title || "")
      );
    }

    return nextBooks;
  }, [books, searchQuery, sortOrder]);

  if (loading)
    return <p className="text-center mt-5 loading-text">{t("loadingBooks")}</p>;

  const displayGenre = t(`genres.${genre.toLowerCase()}`, genre);

  return (
    <div
      className={`container my-5 app-section genre-section ${
        layout === "matrix" ? "genre-section--matrix" : "genre-section--slider"
      }`}
      style={
        {
          "--genre-accent": genreTheme.accent,
          "--genre-accent-deep": genreTheme.accentDeep,
          "--genre-soft": genreTheme.soft,
          "--genre-border": genreTheme.border,
        } as React.CSSProperties
      }
    >
      <h2 className="fw-bold text-capitalize genre-section-title">
        <Link
          to={`/category/${encodeURIComponent(genre)}`}
          className="genre-link"
        >
          {displayGenre}
        </Link>
      </h2>

      {layout === "slider" ? (
        <div className="position-relative">
          <button
            className="btn btn-primary position-absolute top-50 start-0 translate-middle-y shadow-sm slider-nav-btn"
            onClick={() => scroll("left")}
            aria-label={t("scrollLeft")}
            style={{ zIndex: 1 }}
          >
            ⮨
          </button>

          <div
            ref={containerRef}
            className="d-flex overflow-auto gap-3 px-2 px-md-5 py-2 books-track"
            style={{ scrollBehavior: "smooth" }}
          >
            {processedBooks.map((book) => (
              <div
                key={book.id}
                className="card flex-shrink-0 book-card"
                style={{ width: "150px" }}
                role="button"
                tabIndex={0}
                aria-label={t("openBookDetails", { title: book.title })}
                onClick={() => openBookDetail(book.id)}
                onKeyDown={(event) => {
                  if (event.key === "Enter" || event.key === " ") {
                    event.preventDefault();
                    openBookDetail(book.id);
                  }
                }}
              >
                {book.img && (
                  <img
                    src={book.img}
                    className="card-img-top rounded-top book-cover"
                    alt={book.title}
                    height={220}
                  />
                )}
                <div className="card-body text-center p-2">
                  <h6
                    className="card-title text-truncate book-title"
                    title={book.title}
                    style={{ height: "1.5rem" }}
                  >
                    {book.title}
                  </h6>

                  {isAuthenticated && (
                    <button
                      className="btn btn-sm w-100 mt-1 p-0"
                      style={{ fontSize: "1.1rem", lineHeight: 1.4, border: "none", background: "none" }}
                      onClick={(e) => {
                        e.stopPropagation();
                        handleFavorite(Number(book.id));
                      }}
                      disabled={togglingId === Number(book.id)}
                      title={
                        favoriteIds.has(Number(book.id))
                          ? t("alreadyFavorited")
                          : t("addToFavorites")
                      }
                    >
                      {togglingId === Number(book.id) ? (
                        <span className="spinner-border spinner-border-sm" />
                      ) : favoriteIds.has(Number(book.id)) ? (
                        "❤️"
                      ) : (
                        "🤍"
                      )}
                    </button>
                  )}

                  <button
                    className="btn btn-sm btn-outline-primary w-100 mt-1 book-action-btn"
                    onClick={(event) => {
                      event.stopPropagation();
                      openBookDetail(book.id);
                    }}
                  >
                    {t("read")}
                  </button>
                </div>
              </div>
            ))}
          </div>

          <button
            className="btn btn-primary position-absolute top-50 end-0 translate-middle-y shadow-sm slider-nav-btn"
            onClick={() => scroll("right")}
            aria-label={t("scrollRight")}
            style={{ zIndex: 1 }}
          >
            ⮩
          </button>
        </div>
      ) : (
        <div className="row g-3 books-matrix">
          {processedBooks.map((book) => (
            <div key={book.id} className="col-6 col-sm-4 col-md-3 col-lg-2">
              <div
                className="card book-card h-100"
                role="button"
                tabIndex={0}
                aria-label={t("openBookDetails", { title: book.title })}
                onClick={() => openBookDetail(book.id)}
                onKeyDown={(event) => {
                  if (event.key === "Enter" || event.key === " ") {
                    event.preventDefault();
                    openBookDetail(book.id);
                  }
                }}
              >
                {book.img && (
                  <img
                    src={book.img}
                    className="card-img-top rounded-top book-cover"
                    alt={book.title}
                    height={220}
                  />
                )}
                <div className="card-body text-center p-2 d-flex flex-column">
                  <h6
                    className="card-title text-truncate book-title"
                    title={book.title}
                    style={{ height: "1.5rem" }}
                  >
                    {book.title}
                  </h6>

                  {isAuthenticated && (
                    <button
                      className="btn btn-sm w-100 mt-1 p-0"
                      style={{ fontSize: "1.1rem", lineHeight: 1.4, border: "none", background: "none" }}
                      onClick={(e) => {
                        e.stopPropagation();
                        handleFavorite(Number(book.id));
                      }}
                      disabled={togglingId === Number(book.id)}
                      title={
                        favoriteIds.has(Number(book.id))
                          ? t("alreadyFavorited")
                          : t("addToFavorites")
                      }
                    >
                      {togglingId === Number(book.id) ? (
                        <span className="spinner-border spinner-border-sm" />
                      ) : favoriteIds.has(Number(book.id)) ? (
                        "❤️"
                      ) : (
                        "🤍"
                      )}
                    </button>
                  )}

                  <button
                    className="btn btn-sm btn-outline-primary w-100 mt-1 book-action-btn"
                    onClick={(event) => {
                      event.stopPropagation();
                      openBookDetail(book.id);
                    }}
                  >
                    {t("read")}
                  </button>
                </div>
              </div>
            </div>
          ))}
        </div>
      )}

      {processedBooks.length === 0 && (
        <p className="text-center mt-3 empty-state">
          {t("noBooksMatch", "No books match current filters.")}
        </p>
      )}
    </div>
  );
};

export default BooksGrid;
