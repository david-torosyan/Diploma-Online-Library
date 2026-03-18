import React, { useCallback, useEffect, useMemo, useState } from "react";
import { useSearchParams, useNavigate } from "react-router-dom";
import { BookDto, CategoryDto, LibraryClient } from "../api/LibraryClient";
import { useTranslation } from "react-i18next";
import config from "../config/config.json";
import {
  browseBooks,
} from "../services/browseService";
import type { BrowseSort, BrowseBooksResponse } from "../services/browseService";

const PAGE_SIZE = 18;

const sortOptions: { value: BrowseSort; label: string }[] = [
  { value: "newest", label: "exploreSortNewest" },
  { value: "top-rated", label: "exploreSortTopRated" },
  { value: "most-reviewed", label: "exploreSortMostReviewed" },
  { value: "title", label: "exploreSortTitle" },
  { value: "relevance", label: "exploreSortRelevance" },
];

const parsePositiveInt = (value: string | null): number | undefined => {
  if (!value) {
    return undefined;
  }

  const parsed = Number.parseInt(value, 10);
  return Number.isFinite(parsed) && parsed > 0 ? parsed : undefined;
};

const parseRating = (value: string | null): number | undefined => {
  if (!value) {
    return undefined;
  }

  const parsed = Number.parseFloat(value);
  return Number.isFinite(parsed) && parsed >= 0 && parsed <= 5 ? parsed : undefined;
};

const Explore: React.FC = () => {
  const { t } = useTranslation();
  const navigate = useNavigate();
  const [searchParams, setSearchParams] = useSearchParams();

  const [categories, setCategories] = useState<CategoryDto[]>([]);
  const [books, setBooks] = useState<BookDto[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [meta, setMeta] = useState<BrowseBooksResponse>({
    items: [],
    totalCount: 0,
    page: 1,
    pageSize: PAGE_SIZE,
    totalPages: 0,
    hasNextPage: false,
  });

  const query = searchParams.get("q") ?? "";
  const category = searchParams.get("category") ?? "";
  const sortBy = (searchParams.get("sortBy") as BrowseSort) ?? "newest";
  const page = parsePositiveInt(searchParams.get("page")) ?? 1;
  const minRating = parseRating(searchParams.get("minRating"));
  const maxPages = parsePositiveInt(searchParams.get("maxPages"));
  const [queryDraft, setQueryDraft] = useState(query);

  const updateParam = useCallback((name: string, value?: string) => {
    const next = new URLSearchParams(searchParams);

    if (!value) {
      next.delete(name);
    } else {
      next.set(name, value);
    }

    if (name !== "page") {
      next.set("page", "1");
    }

    setSearchParams(next);
  }, [searchParams, setSearchParams]);

  useEffect(() => {
    setQueryDraft(query);
  }, [query]);

  useEffect(() => {
    const delay = setTimeout(() => {
      const normalized = queryDraft.trim();
      if (normalized === query) {
        return;
      }

      updateParam("q", normalized || undefined);
    }, 320);

    return () => clearTimeout(delay);
  }, [queryDraft, query, updateParam]);

  useEffect(() => {
    const fetchCategories = async () => {
      const api = new LibraryClient(config.baseUrl);
      const result = await api.allCategories().catch(() => []);
      setCategories(result);
    };

    fetchCategories();
  }, []);

  useEffect(() => {
    const load = async () => {
      setLoading(true);
      setError(null);

      try {
        const response = await browseBooks({
          q: query || undefined,
          category: category || undefined,
          minRating,
          maxPages,
          sortBy,
          page,
          pageSize: PAGE_SIZE,
        });

        setBooks(response.items);
        setMeta(response);
      } catch {
        setBooks([]);
        setError(t("fetchError"));
      } finally {
        setLoading(false);
      }
    };

    load();
  }, [query, category, minRating, maxPages, sortBy, page, t]);

  const categoryNames = useMemo(
    () => Array.from(new Set(categories.map((entry) => (entry.name || "").trim()).filter(Boolean))),
    [categories]
  );

  const getCategoryLabel = (categoryName: string): string => {
    const normalized = categoryName
      .trim()
      .toLowerCase()
      .replace(/[^a-z0-9\s]/g, "")
      .replace(/\s+/g, " ");

    if (!normalized) {
      return categoryName;
    }

    const nestedGenreLabel = t(`genres.${normalized}`, { defaultValue: "" });
    if (nestedGenreLabel) {
      return nestedGenreLabel;
    }

    const flatGenreLabel = t(normalized, { defaultValue: "" });
    if (flatGenreLabel) {
      return flatGenreLabel;
    }

    return categoryName;
  };

  const hasFilters = Boolean(query || category || minRating || maxPages);

  return (
    <div className="container app-section explore-shell">
      <section className="explore-hero mb-4">
        <div>
          <p className="explore-tag mb-2">{t("explore")}</p>
          <h1 className="explore-title mb-2">{t("exploreTitle")}</h1>
          <p className="explore-subtitle mb-0">
            {t("exploreSubtitle")}
          </p>
        </div>
      </section>

      <section className="explore-controls mb-4">
        <div className="row g-3 align-items-end">
          <div className="col-12 col-md-6 col-lg-4">
            <label className="form-label mb-1">{t("exploreSearchLabel")}</label>
            <input
              value={queryDraft}
              onChange={(event) => setQueryDraft(event.target.value)}
              placeholder={t("searchPlaceholder")}
              className="form-control"
            />
          </div>

          <div className="col-6 col-md-3 col-lg-2">
            <label className="form-label mb-1">{t("exploreMinRating")}</label>
            <select
              className="form-select"
              value={minRating?.toString() ?? ""}
              onChange={(event) => updateParam("minRating", event.target.value || undefined)}
            >
              <option value="">{t("exploreAny")}</option>
              <option value="4.5">4.5+</option>
              <option value="4">4.0+</option>
              <option value="3.5">3.5+</option>
              <option value="3">3.0+</option>
            </select>
          </div>

          <div className="col-6 col-md-3 col-lg-2">
            <label className="form-label mb-1">{t("exploreMaxPages")}</label>
            <select
              className="form-select"
              value={maxPages?.toString() ?? ""}
              onChange={(event) => updateParam("maxPages", event.target.value || undefined)}
            >
              <option value="">{t("exploreAny")}</option>
              <option value="180">{t("exploreUpToPages", { pages: 180 })}</option>
              <option value="300">{t("exploreUpToPages", { pages: 300 })}</option>
              <option value="450">{t("exploreUpToPages", { pages: 450 })}</option>
              <option value="600">{t("exploreUpToPages", { pages: 600 })}</option>
            </select>
          </div>

          <div className="col-12 col-md-6 col-lg-2">
            <label className="form-label mb-1">{t("exploreSortBy")}</label>
            <select
              className="form-select"
              value={sortBy}
              onChange={(event) => updateParam("sortBy", event.target.value)}
            >
              {sortOptions.map((option) => (
                <option key={option.value} value={option.value}>
                  {t(option.label)}
                </option>
              ))}
            </select>
          </div>

          <div className="col-12 col-md-6 col-lg-2">
            <button
              className="btn btn-outline-secondary w-100"
              onClick={() => {
                setQueryDraft("");
                setSearchParams(new URLSearchParams());
              }}
              disabled={!hasFilters}
            >
              {t("exploreResetFilters")}
            </button>
          </div>

          <div className="col-12">
            <label className="form-label mb-2">{t("genre")}</label>
            <div className="d-flex flex-wrap gap-2">
              <button
                className={`btn btn-sm rounded-pill ${category === "" ? "btn-primary" : "btn-outline-primary"}`}
                onClick={() => updateParam("category", undefined)}
              >
                {t("exploreAllCategories")}
              </button>
              {categoryNames.map((categoryName) => (
                <button
                  key={categoryName}
                  className={`btn btn-sm rounded-pill ${
                    category === categoryName ? "btn-primary" : "btn-outline-primary"
                  }`}
                  onClick={() => updateParam("category", categoryName)}
                >
                  {getCategoryLabel(categoryName)}
                </button>
              ))}
            </div>
          </div>
        </div>
      </section>

      <section className="d-flex justify-content-between align-items-center mb-3 explore-meta">
        <div>
          <strong>{meta.totalCount}</strong> {t("exploreBooksFound")}
        </div>
        <div className="text-muted small">
          {t("explorePageOf", { page: meta.page, totalPages: Math.max(meta.totalPages, 1) })}
        </div>
      </section>

      {loading ? (
        <div className="text-center my-5 loading-text">{t("loadingBooks")}</div>
      ) : error ? (
        <div className="alert alert-danger">{error}</div>
      ) : books.length === 0 ? (
        <div className="text-center empty-state my-5">
          {t("exploreNoBooksMatch")}
        </div>
      ) : (
        <div className="row g-3">
          {books.map((book) => (
            <div key={`${book.id}-${book.title}`} className="col-6 col-sm-4 col-lg-3 col-xl-2">
              <article className="book-card h-100">
                {book.imageURL ? (
                  <img src={book.imageURL} alt={book.title} className="book-cover" style={{ height: "220px" }} />
                ) : (
                  <div className="book-cover d-flex align-items-center justify-content-center" style={{ height: "220px" }}>
                    <span className="text-muted">No cover</span>
                  </div>
                )}

                <div className="card-body p-2 d-flex flex-column">
                  <h6 className="book-title mb-1 text-truncate" title={book.title}>
                    {book.title || t("unknown")}
                  </h6>
                  <small className="text-muted text-truncate">{book.categoryName || t("uncategorized")}</small>
                  <small className="mb-2">⭐ {book.averageRating?.toFixed(1) ?? "0.0"}</small>

                  <button
                    className="btn btn-sm btn-outline-primary mt-auto"
                    onClick={() => navigate(`/bookdetails/${book.id}`)}
                    disabled={!book.id}
                  >
                    {t("read")}
                  </button>
                </div>
              </article>
            </div>
          ))}
        </div>
      )}

      <section className="d-flex justify-content-center align-items-center gap-2 mt-4 mb-5">
        <button
          className="btn btn-outline-secondary"
          disabled={page <= 1 || loading}
          onClick={() => updateParam("page", (page - 1).toString())}
        >
          {t("previous")}
        </button>
        <button
          className="btn btn-outline-secondary"
          disabled={!meta.hasNextPage || loading}
          onClick={() => updateParam("page", (page + 1).toString())}
        >
          {t("next")}
        </button>
      </section>
    </div>
  );
};

export default Explore;
