import React, { useMemo, useState, useEffect } from "react";
import { Link } from "react-router-dom";
import { BookDto, LibraryClient, CategoryDto } from "../api/LibraryClient";
import { useTranslation } from "react-i18next";
import BooksGrid from "../components/BooksGrid";
import SearchDrawer from "../components/SearchDrawer";
import CuratedBooksShelf from "../components/CuratedBooksShelf";
import {
  getFeaturedBooks,
  getMostRatedBooks,
  getNewArrivals,
} from "../services/discoveryService";
import config from "../config/config";
import { orderCategoriesForHome } from "../utils/categoryOrdering";

const Home: React.FC = () => {
  const { t } = useTranslation();
  const [categories, setCategories] = useState<CategoryDto[]>([]);
  const [featuredBooks, setFeaturedBooks] = useState<BookDto[]>([]);
  const [mostRatedBooks, setMostRatedBooks] = useState<BookDto[]>([]);
  const [newArrivals, setNewArrivals] = useState<BookDto[]>([]);
  const [discoveryLoading, setDiscoveryLoading] = useState(true);

  useEffect(() => {
    const fetchCategories = async () => {
      try {
        const api = new LibraryClient(config.baseUrl);
        const result: CategoryDto[] = await api.allCategories();
        setCategories(result);
      } catch (error) {
        console.error("Error fetching categories:", error);
      }
    };

    fetchCategories();
  }, []);

  useEffect(() => {
    const loadDiscoveryShelves = async () => {
      try {
        const [featured, rated, arrivals] = await Promise.all([
          getFeaturedBooks(10),
          getMostRatedBooks(10),
          getNewArrivals(10),
        ]);

        setFeaturedBooks(featured);
        setMostRatedBooks(rated);
        setNewArrivals(arrivals);
      } finally {
        setDiscoveryLoading(false);
      }
    };

    loadDiscoveryShelves();
  }, []);

  const genres = useMemo(() => {
    return orderCategoriesForHome(categories.map((category) => category.name || ""));
  }, [categories]);

  return (
    <div className="app-section">
      <section className="hero-shell text-center">
        <div className="container">
          <div className="hero-card">
            <h1 className="hero-title">{t("welcome")}</h1>
            <p className="hero-subtitle">{t("description")}</p>
            <div className="d-flex justify-content-center mt-3 mb-2">
              <Link to="/explore" className="btn btn-primary rounded-pill px-4">
                {t("explore", "Explore smarter")}
              </Link>
            </div>
            <SearchDrawer />
          </div>
        </div>
      </section>

      <CuratedBooksShelf
        title={t("newArrivals", "New Arrivals")}
        subtitle={t(
          "newArrivalsSubtitle",
          "Freshly added books ready to explore."
        )}
        books={newArrivals}
        loading={discoveryLoading}
        openAllHref="/collection/new-arrivals"
      />

      <CuratedBooksShelf
        title={t("mostRatedBooks", "Top books ranked")}
        subtitle={t(
          "mostRatedBooksSubtitle",
          "Top books ranked by community star ratings."
        )}
        books={mostRatedBooks}
        loading={discoveryLoading}
        openAllHref="/collection/most-rated"
        showRatings
      />

      {genres.length > 0 ? (
        genres.map((genre) => (
          <section key={genre} className="app-section">
            <BooksGrid genre={genre} />
          </section>
        ))
      ) : (
        <p className="text-center my-4 empty-state">{t("fetchError")}</p>
      )}
    </div>
  );
};

export default Home;
