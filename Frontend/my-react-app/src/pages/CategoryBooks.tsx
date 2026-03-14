import React, { useState } from "react";
import { Link, useParams } from "react-router-dom";
import { useTranslation } from "react-i18next";
import BooksGrid from "../components/BooksGrid";
import { createGenreTheme } from "../utils/genreTheme";

const CategoryBooks: React.FC = () => {
  const { categoryName } = useParams<{ categoryName: string }>();
  const { t } = useTranslation();
  const [searchQuery, setSearchQuery] = useState("");
  const [sortOrder, setSortOrder] = useState<"default" | "title-asc" | "title-desc">("default");

  const category = decodeURIComponent(categoryName || "");
  const genreTheme = createGenreTheme(category);

  if (!category) {
    return (
      <div className="container category-shell app-section">
        <p className="text-danger">{t("fetchError")}</p>
        <Link to="/" className="btn btn-outline-primary mt-2 rounded-pill px-3">
          {t("library")}
        </Link>
      </div>
    );
  }

  return (
    <div className="container category-shell app-section">
      <div className="mb-3">
        <Link to="/" className="btn btn-outline-secondary btn-sm rounded-pill px-3">
          ← {t("library")}
        </Link>
      </div>

      <div
        className="category-header mb-4"
        style={
          {
            borderColor: genreTheme.border,
            background: `linear-gradient(135deg, ${genreTheme.soft}, #ffffff)`,
          } as React.CSSProperties
        }
      >
        <h1 className="h3 fw-bold text-capitalize mb-2">{t(`genres.${category.toLowerCase()}`, category)}</h1>
        <p className="text-muted mb-0" style={{ color: genreTheme.accentDeep }}>
          {t("library")}
        </p>
      </div>

      <section className="category-filters mb-3">
        <div className="row g-2 align-items-end">
          <div className="col-12 col-md-8">
            <label className="form-label mb-1 fw-semibold">
              {t("filterByTitle", "Filter by title")}
            </label>
            <input
              type="text"
              className="form-control"
              placeholder={t("searchInCategory", "Search inside this category...")}
              value={searchQuery}
              onChange={(event) => setSearchQuery(event.target.value)}
            />
          </div>

          <div className="col-12 col-md-4">
            <label className="form-label mb-1 fw-semibold">
              {t("sortBy", "Sort by")}
            </label>
            <select
              className="form-select"
              value={sortOrder}
              onChange={(event) =>
                setSortOrder(event.target.value as "default" | "title-asc" | "title-desc")
              }
            >
              <option value="default">{t("relevance", "Relevance")}</option>
              <option value="title-asc">{t("titleAZ", "Title A–Z")}</option>
              <option value="title-desc">{t("titleZA", "Title Z–A")}</option>
            </select>
          </div>
        </div>
      </section>

      <BooksGrid
        genre={category}
        layout="matrix"
        searchQuery={searchQuery}
        sortOrder={sortOrder}
      />
    </div>
  );
};

export default CategoryBooks;