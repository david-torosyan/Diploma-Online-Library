import React from "react";
import { Link, useParams } from "react-router-dom";
import { useTranslation } from "react-i18next";
import BooksGrid from "../components/BooksGrid";

const CategoryBooks: React.FC = () => {
  const { categoryName } = useParams<{ categoryName: string }>();
  const { t } = useTranslation();

  const category = decodeURIComponent(categoryName || "");

  if (!category) {
    return (
      <div className="container my-5">
        <p className="text-danger">{t("fetchError")}</p>
        <Link to="/" className="btn btn-outline-primary mt-2">
          {t("library")}
        </Link>
      </div>
    );
  }

  return (
    <div className="container my-4">
      <div className="mb-3">
        <Link to="/" className="btn btn-outline-secondary btn-sm">
          ← {t("library")}
        </Link>
      </div>

      <h1 className="h3 fw-bold text-capitalize mb-2">{t(`genres.${category.toLowerCase()}`, category)}</h1>
      <p className="text-muted mb-4">{t("library")}</p>

      <BooksGrid genre={category} layout="matrix" />
    </div>
  );
};

export default CategoryBooks;