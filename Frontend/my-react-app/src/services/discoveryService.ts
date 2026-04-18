import { BookDto, LibraryClient } from "../api/LibraryClient";
import config from "../config/config";

const normalizeBaseUrl = (value: string): string => value.replace(/\/+$/, "");

const toBookDtoArray = (payload: unknown): BookDto[] => {
  if (!Array.isArray(payload)) {
    return [];
  }

  return payload.map((item) => BookDto.fromJS(item));
};

const safeFetchJson = async <T>(url: string): Promise<T | null> => {
  try {
    const response = await fetch(url, {
      method: "GET",
      headers: {
        Accept: "application/json",
      },
    });

    if (!response.ok) {
      return null;
    }

    return (await response.json()) as T;
  } catch {
    return null;
  }
};

const dedupeBooks = (books: BookDto[]): BookDto[] => {
  const seenIds = new Set<number>();
  const uniqueBooks: BookDto[] = [];

  for (const book of books) {
    if (!book.id) {
      continue;
    }

    if (seenIds.has(book.id)) {
      continue;
    }

    seenIds.add(book.id);
    uniqueBooks.push(book);
  }

  return uniqueBooks;
};

const loadBooksFromCategories = async (
  client: LibraryClient,
  categoryNames: string[],
  limit: number
): Promise<BookDto[]> => {
  const categoryCalls = categoryNames.map((categoryName) =>
    client.category(categoryName).catch(() => [])
  );

  const bookGroups = await Promise.all(categoryCalls);
  const books = dedupeBooks(bookGroups.flat());

  return books.slice(0, limit);
};

// Major phase-3 update: this service calls future backend endpoints first, then
// gracefully falls back to existing API methods so the UI keeps working today.
export const getFeaturedBooks = async (limit = 10): Promise<BookDto[]> => {
  const baseUrl = normalizeBaseUrl(config.baseUrl);
  const endpointData = await safeFetchJson<unknown>(
    `${baseUrl}/api/books/featured?limit=${limit}`
  );
  const endpointBooks = toBookDtoArray(endpointData);

  if (endpointBooks.length > 0) {
    return endpointBooks.slice(0, limit);
  }

  const client = new LibraryClient(config.baseUrl);
  const categories = await client.allCategories().catch(() => []);
  const names = categories
    .map((category) => (category.name || "").trim())
    .filter(Boolean)
    .slice(0, 4);

  return loadBooksFromCategories(client, names, limit);
};

export const getNewArrivals = async (limit = 10): Promise<BookDto[]> => {
  const baseUrl = normalizeBaseUrl(config.baseUrl);
  const endpointData = await safeFetchJson<unknown>(
    `${baseUrl}/api/books/new-arrivals?limit=${limit}`
  );
  const endpointBooks = toBookDtoArray(endpointData);

  if (endpointBooks.length > 0) {
    return endpointBooks.slice(0, limit);
  }

  const client = new LibraryClient(config.baseUrl);
  const categories = await client.allCategories().catch(() => []);
  const names = categories
    .map((category) => (category.name || "").trim())
    .filter(Boolean)
    .slice(0, 6);

  const books = await loadBooksFromCategories(client, names, limit * 2);
  return [...books]
    .sort((left, right) => (right.id || 0) - (left.id || 0))
    .slice(0, limit);
};

export const getMostRatedBooks = async (limit = 10): Promise<BookDto[]> => {
  const baseUrl = normalizeBaseUrl(config.baseUrl);
  const endpointData = await safeFetchJson<unknown>(
    `${baseUrl}/api/books/most-rated?limit=${limit}`
  );
  const endpointBooks = toBookDtoArray(endpointData);

  if (endpointBooks.length > 0) {
    return endpointBooks.slice(0, limit);
  }

  const fallback = await getFeaturedBooks(limit * 2);

  return [...fallback]
    .sort(
      (left, right) =>
        (right.averageRating || 0) - (left.averageRating || 0) ||
        (right.reviewsCount || 0) - (left.reviewsCount || 0)
    )
    .slice(0, limit);
};

export const getRelatedBooks = async (
  bookId: number,
  categoryName?: string,
  limit = 8
): Promise<BookDto[]> => {
  const baseUrl = normalizeBaseUrl(config.baseUrl);
  const endpointData = await safeFetchJson<unknown>(
    `${baseUrl}/api/books/${bookId}/related?limit=${limit}`
  );
  const endpointBooks = toBookDtoArray(endpointData).filter(
    (book) => book.id !== bookId
  );

  if (endpointBooks.length > 0) {
    return endpointBooks.slice(0, limit);
  }

  if (!categoryName) {
    return [];
  }

  const client = new LibraryClient(config.baseUrl);
  const fallbackBooks = await client.category(categoryName).catch(() => []);

  return dedupeBooks(fallbackBooks)
    .filter((book) => book.id !== bookId)
    .slice(0, limit);
};

export const getSearchSuggestions = async (
  query: string,
  limit = 6
): Promise<string[]> => {
  if (query.trim().length < 2) {
    return [];
  }

  const baseUrl = normalizeBaseUrl(config.baseUrl);
  const endpointData = await safeFetchJson<unknown>(
    `${baseUrl}/api/books/search/suggestions?q=${encodeURIComponent(
      query
    )}&limit=${limit}`
  );

  if (Array.isArray(endpointData)) {
    const suggestions = endpointData
      .map((entry) => {
        if (typeof entry === "string") {
          return entry;
        }

        if (
          typeof entry === "object" &&
          entry !== null &&
          "title" in entry &&
          typeof (entry as { title?: unknown }).title === "string"
        ) {
          return (entry as { title: string }).title;
        }

        return "";
      })
      .filter(Boolean)
      .slice(0, limit);

    if (suggestions.length > 0) {
      return suggestions;
    }
  }

  const client = new LibraryClient(config.baseUrl);
  const fallbackBooks = await client.bookName(query).catch(() => []);

  return Array.from(
    new Set(
      fallbackBooks
        .map((book) => (book.title || "").trim())
        .filter(Boolean)
        .slice(0, limit)
    )
  );
};
