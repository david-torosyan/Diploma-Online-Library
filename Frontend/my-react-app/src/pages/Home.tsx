import React, { useState, useEffect } from "react";
import { LibraryClient, CategoryDto } from "../api/LibraryClient";
import { useTranslation } from "react-i18next";
import BooksGrid from "../components/BooksGrid";
import SearchDrawer from "../components/SearchDrawer";
import config from "../config/config.json";

const Home: React.FC = () => {
  const { t } = useTranslation();
  const [categories, setCategories] = useState<CategoryDto[]>([]);

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

  const genres = Array.from(
    new Set(categories.map((c) => c.name).filter(Boolean))
  );

  return (
    <div>
      {/* Header Section */}
      <section className="bg-light py-5 text-center">
        <div className="container">
          <h1 className="display-4">{t("welcome")}</h1>
          <p className="lead">{t("description")}</p>
          <SearchDrawer />
        </div>
      </section>

      {/* Books Grid Section */}
      {genres.length > 0 ? (
        genres.map((genre) => (
          <section key={genre}>
            <BooksGrid genre={genre} />
          </section>
        ))
      ) : (
        <p className="text-center my-4 text-muted">{t("fetchError")}</p>
      )}
    </div>
  );
};

export default Home;
