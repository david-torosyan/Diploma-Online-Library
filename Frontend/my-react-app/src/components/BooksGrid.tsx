import React, { useRef, useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { LibraryClient, BookDto } from "../api/LibraryClient";
import { useTranslation } from "react-i18next";
import config from "../config/config.json";

interface Book {
  id: string;
  title: string;
  img: string;
}

interface BooksGridProps {
  genre?: string;
}

const BooksGrid: React.FC<BooksGridProps> = ({ genre = "fiction" }) => {
  const { t } = useTranslation();
  const containerRef = useRef<HTMLDivElement>(null);
  const navigate = useNavigate();
  const [books, setBooks] = useState<Book[]>([]);
  const [loading, setLoading] = useState(true);

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
  }, [genre]);

  const scroll = (direction: "left" | "right") => {
    const distance = direction === "left" ? -300 : 300;
    containerRef.current?.scrollBy({ left: distance, behavior: "smooth" });
  };

  const openBookDetail = (id: string) => {
    navigate(`/bookdetails/${id}`);
  };

  if (loading)
    return <p className="text-center mt-5 text-muted">{t("loadingBooks")}</p>;

  const displayGenre = t(`genres.${genre}`);

  return (
    <div className="container my-5">
      <h2 className="fw-bold mb-3 text-capitalize">{displayGenre}</h2>

      <div className="position-relative">
        {/* Left Scroll Button */}
        <button
          className="btn btn-primary position-absolute top-50 start-0 translate-middle-y shadow-sm"
          onClick={() => scroll("left")}
          aria-label={t("scrollLeft")}
          style={{ zIndex: 1 }}
        >
          ⮨
        </button>

        {/* Books Scroll Row */}
        <div
          ref={containerRef}
          className="d-flex overflow-auto gap-3 px-5 py-2"
          style={{ scrollBehavior: "smooth" }}
        >
          {books.map((book) => (
            <div
              key={book.id}
              className="card flex-shrink-0 border-0 shadow-sm"
              style={{ width: "150px" }}
            >
              {book.img && (
                <img
                  src={book.img}
                  className="card-img-top rounded-top"
                  alt={book.title}
                  height={220}
                  style={{ objectFit: "cover" }}
                />
              )}
              <div className="card-body text-center p-2">
                <h6
                  className="card-title text-truncate"
                  title={book.title}
                  style={{ height: "1.5rem" }}
                >
                  {book.title}
                </h6>
                <button
                  className="btn btn-sm btn-outline-primary w-100 mt-2"
                  onClick={() => openBookDetail(book.id)}
                >
                  {t("read")}
                </button>
              </div>
            </div>
          ))}
        </div>

        {/* Right Scroll Button */}
        <button
          className="btn btn-primary position-absolute top-50 end-0 translate-middle-y shadow-sm"
          onClick={() => scroll("right")}
          aria-label={t("scrollRight")}
          style={{ zIndex: 1 }}
        >
          ⮩
        </button>
      </div>
    </div>
  );
};

export default BooksGrid;
