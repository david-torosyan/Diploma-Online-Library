import { BookDto } from "../api/LibraryClient";
import config from "../config/config.json";

export type BrowseSort =
  | "newest"
  | "relevance"
  | "top-rated"
  | "most-reviewed"
  | "title";

export interface BrowseBooksQuery {
  q?: string;
  category?: string;
  minRating?: number;
  maxPages?: number;
  sortBy?: BrowseSort;
  page?: number;
  pageSize?: number;
}

export interface BrowseBooksResponse {
  items: BookDto[];
  totalCount: number;
  page: number;
  pageSize: number;
  totalPages: number;
  hasNextPage: boolean;
}

const normalizeBaseUrl = (value: string): string => value.replace(/\/+$/, "");

const toBookDtoArray = (payload: unknown): BookDto[] => {
  if (!Array.isArray(payload)) {
    return [];
  }

  return payload.map((entry) => BookDto.fromJS(entry));
};

const toSafeNumber = (value: unknown, fallback: number): number => {
  return typeof value === "number" && Number.isFinite(value) ? value : fallback;
};

export const browseBooks = async (
  query: BrowseBooksQuery
): Promise<BrowseBooksResponse> => {
  const baseUrl = normalizeBaseUrl(config.baseUrl);
  const searchParams = new URLSearchParams();

  if (query.q?.trim()) {
    searchParams.set("q", query.q.trim());
  }

  if (query.category?.trim()) {
    searchParams.set("category", query.category.trim());
  }

  if (typeof query.minRating === "number") {
    searchParams.set("minRating", query.minRating.toString());
  }

  if (typeof query.maxPages === "number") {
    searchParams.set("maxPages", query.maxPages.toString());
  }

  searchParams.set("sortBy", query.sortBy ?? "newest");
  searchParams.set("page", (query.page ?? 1).toString());
  searchParams.set("pageSize", (query.pageSize ?? 18).toString());

  const response = await fetch(
    `${baseUrl}/api/books/browse?${searchParams.toString()}`,
    {
      method: "GET",
      headers: {
        Accept: "application/json",
      },
    }
  );

  if (!response.ok) {
    throw new Error("Browse request failed");
  }

  const payload = (await response.json()) as Record<string, unknown>;

  return {
    items: toBookDtoArray(payload.items),
    totalCount: toSafeNumber(payload.totalCount, 0),
    page: toSafeNumber(payload.page, 1),
    pageSize: toSafeNumber(payload.pageSize, 18),
    totalPages: toSafeNumber(payload.totalPages, 0),
    hasNextPage: Boolean(payload.hasNextPage),
  };
};
