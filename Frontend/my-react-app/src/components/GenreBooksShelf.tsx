import React, { useEffect, useState } from "react";
import { BookDto, LibraryClient } from "../api/LibraryClient";
import { useTranslation } from "react-i18next";
import config from "../config/config";
import CuratedBooksShelf from "./CuratedBooksShelf";

interface GenreBooksShelfProps {
  genre: string;
}

const GenreBooksShelf: React.FC<GenreBooksShelfProps> = ({ genre }) => {
  const { t } = useTranslation();
  const [books, setBooks] = useState<BookDto[]>([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    let isMounted = true;

    const fetchBooks = async () => {
      setLoading(true);

      try {
        const api = new LibraryClient(config.baseUrl);
        const result = await api.category(genre);

        if (!isMounted) {
          return;
        }

        setBooks(result);
      } catch (error) {
        console.error(`Error fetching books for category ${genre}:`, error);

        if (isMounted) {
          setBooks([]);
        }
      } finally {
        if (isMounted) {
          setLoading(false);
        }
      }
    };

    fetchBooks();

    return () => {
      isMounted = false;
    };
  }, [genre]);

  if (loading) {
    return (
      <CuratedBooksShelf
        title={t(`genres.${genre.toLowerCase()}`, genre)}
        subtitle={t(
          "genreShelfSubtitle",
          "Browse books from this genre."
        )}
        books={[]}
        loading
        openAllHref={`/category/${encodeURIComponent(genre)}`}
      />
    );
  }

  if (books.length === 0) {
    return null;
  }

  return (
    <CuratedBooksShelf
      title={t(`genres.${genre.toLowerCase()}`, genre)}
      subtitle={t(
        "genreShelfSubtitle",
        "Browse books from this genre."
      )}
      books={books}
      loading={false}
      openAllHref={`/category/${encodeURIComponent(genre)}`}
    />
  );
};

export default GenreBooksShelf;