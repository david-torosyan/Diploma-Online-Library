import React from "react";
import BooksGrid from "../components/BooksGrid";
import SearchDrawer from "../components/SearchDrawer";
import { useTranslation } from "react-i18next";

const Home: React.FC = () => {
    const { t } = useTranslation();
  const genres = [
    "fiction",
    "romance",
    "science",
    "fantasy",
    "history",
    "biography",
    "technology",
    "art",
    "travel",
  ];

  return (
    <div>
      <section className="bg-light py-5 text-center">
        <div className="container">
          <h1 className="display-4">{t("welcome")}</h1>
          <p className="lead">
            {t("description")}
          </p>
          <SearchDrawer />
        </div>
      </section>

      {/* Books Grid Section */}
      {genres.map((genre) => (
        <section key={genre}>
          <BooksGrid genre={genre} />
        </section>
      ))}
    </div>
  );
};

export default Home;
