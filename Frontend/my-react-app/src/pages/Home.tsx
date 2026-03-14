import React, { useState, useEffect } from "react";
import { BookDto, LibraryClient, CategoryDto } from "../api/LibraryClient";
import { useTranslation } from "react-i18next";
import BooksGrid from "../components/BooksGrid";
import SearchDrawer from "../components/SearchDrawer";
import CuratedBooksShelf from "../components/CuratedBooksShelf";
import { getFeaturedBooks, getNewArrivals } from "../services/discoveryService";
import config from "../config/config.json";

const Home: React.FC = () => {
  const { t } = useTranslation();
  const [categories, setCategories] = useState<CategoryDto[]>([]);
  const [featuredBooks, setFeaturedBooks] = useState<BookDto[]>([]);
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
        const [featured, arrivals] = await Promise.all([
          getFeaturedBooks(10),
          getNewArrivals(10),
        ]);

        setFeaturedBooks(featured);
        setNewArrivals(arrivals);
      } finally {
        setDiscoveryLoading(false);
      }
    };

    loadDiscoveryShelves();
  }, []);

  const genres = Array.from(
    new Set(categories.map((c) => c.name).filter(Boolean))
  );

  return (
    <div className="app-section">
      <section className="hero-shell text-center">
        <div className="container">
          <div className="hero-card">
            <h1 className="hero-title">{t("welcome")}</h1>
            <p className="hero-subtitle">{t("description")}</p>
            <SearchDrawer />
          </div>
        </div>
      </section>

      <CuratedBooksShelf
        title={t("featuredBooks", "Featured Books")}
        subtitle={t(
          "featuredBooksSubtitle",
          "Hand-picked titles readers are loving this week."
        )}
        books={featuredBooks}
        loading={discoveryLoading}
        openAllHref="/collection/featured"
      />

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
