import React, { useState, useEffect, useMemo } from "react";
import { useTranslation } from "react-i18next";
import { LibraryClient, CategoryDto } from "../api/LibraryClient";
import config from "../config/config";
import { useNavigate } from "react-router-dom";
import { Offcanvas } from "bootstrap";
import Cookies from "js-cookie";
import { moveAnotherToEnd } from "../utils/categoryOrdering";

const isPdfFile = (file: File): boolean => {
  const mimeType = (file.type || "").toLowerCase();
  const fileName = (file.name || "").toLowerCase();

  // Some browsers provide an empty MIME type for local files,
  // so we accept either valid MIME type or .pdf extension.
  return mimeType === "application/pdf" || fileName.endsWith(".pdf");
};

const extractBackendMessages = (raw: string): string[] => {
  const pickMessage = (input: unknown): string[] => {
    if (!input || typeof input !== "object") return [];

    const payload = input as {
      title?: string;
      detail?: string;
      message?: string;
      Message?: string;
      errors?: Record<string, string[]>;
    };

    const modelErrors = payload.errors
      ? Object.values(payload.errors).flat().filter(Boolean)
      : [];

    if (modelErrors.length > 0) return modelErrors;

    const single = payload.detail || payload.title || payload.message || payload.Message;
    return single ? [single] : [];
  };

  try {
    const parsed = JSON.parse(raw) as unknown;
    const direct = pickMessage(parsed);
    if (direct.length > 0) return direct;

    if (typeof parsed === "string") {
      try {
        const nested = JSON.parse(parsed) as unknown;
        const nestedMessages = pickMessage(nested);
        if (nestedMessages.length > 0) return nestedMessages;
      } catch {
        return [parsed];
      }

      return [parsed];
    }
  } catch {
    // Raw text fallback below.
  }

  return raw ? [raw] : [];
};

const AddBookDrawer: React.FC = () => {
  const { t } = useTranslation();
  const [categories, setCategories] = useState<CategoryDto[]>([]);
  const [selectedGenre, setSelectedGenre] = useState<string>("");
  const [imageSourceType, setImageSourceType] = useState<"url" | "file">("url");
  const [bookSourceType, setBookSourceType] = useState<"url" | "file">("url");
  const [loading, setLoading] = useState<boolean>(false);
  const [formErrors, setFormErrors] = useState<string[]>([]);
  const navigate = useNavigate();

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

  const orderedCategories = useMemo(
    () => moveAnotherToEnd(categories.map((category) => category.name || "")),
    [categories]
  );

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    setFormErrors([]);

    const form = e.target as HTMLFormElement;
    const formData = new FormData(form);

    const title = (formData.get("title") as string)?.trim() ?? "";
    const authorName = (formData.get("authorName") as string)?.trim() ?? "";
    const categoryId = Number(selectedGenre);
    const description = (formData.get("description") as string)?.trim() ?? "";
    const publishedDateString = formData.get("releasedDay") as string | null;
    const imageUrl = (formData.get("imageUrl") as string)?.trim() ?? "";
    const bookUrl = (formData.get("bookUrl") as string)?.trim() ?? "";
    const imageFile = formData.get("imageFile");
    const bookFile = formData.get("bookFile");

    const hasImageFile = imageSourceType === "file" && imageFile instanceof File && imageFile.size > 0;
    const hasBookFile = bookSourceType === "file" && bookFile instanceof File && bookFile.size > 0;
    const hasImageUrl = imageSourceType === "url" && imageUrl.length > 0;
    const hasBookUrl = bookSourceType === "url" && bookUrl.length > 0;

    if (!title || !authorName || !categoryId) {
      setFormErrors([t("pleaseFillAllRequiredFields")]);
      return;
    }

    if (imageSourceType === "url" && !hasImageUrl) {
      setFormErrors([t("imageSourceRequired")]);
      return;
    }

    if (imageSourceType === "file" && !hasImageFile) {
      setFormErrors([t("imageSourceRequired")]);
      return;
    }

    if (bookSourceType === "url" && !hasBookUrl) {
      setFormErrors([t("bookSourceRequired")]);
      return;
    }

    if (bookSourceType === "file" && !hasBookFile) {
      setFormErrors([t("bookSourceRequired")]);
      return;
    }

    if (bookSourceType === "file" && hasBookFile && !isPdfFile(bookFile as File)) {
      setFormErrors([t("bookPdfOnly")]);
      return;
    }

    const token = Cookies.get("auth_token");
    if (!token) {
      setFormErrors([t("notLoggedIn")]);
      return;
    }

    const payload = new FormData();
    payload.append("title", title);
    payload.append("authorName", authorName);
    payload.append("categoryId", String(categoryId));
    if (description) {
      payload.append("description", description);
    }

    if (publishedDateString) {
      payload.append("publishedDate", new Date(publishedDateString).toISOString());
    }

    if (hasImageUrl) {
      payload.append("imageUrl", imageUrl);
    }

    if (hasBookUrl) {
      payload.append("bookUrl", bookUrl);
    }

    if (hasImageFile) {
      payload.append("imageFile", imageFile as File);
    }

    if (hasBookFile) {
      payload.append("bookFile", bookFile as File);
    }

    try {
      setLoading(true);
      const response = await fetch(`${config.baseUrl}/api/Book/addBookWithAuthor`, {
        method: "POST",
        headers: {
          Authorization: `Bearer ${token}`,
        },
        body: payload,
      });

      if (!response.ok) {
        const defaultMessage = t("failedToAddBook");

        try {
          const payloadText = await response.text();
          const messages = extractBackendMessages(payloadText);
          if (messages.length > 0) {
            setFormErrors(messages);
            return;
          }
        } catch {
          // fallback handled below
        }

        throw new Error(defaultMessage);
      }

      const responseId = (await response.json()) as number;

      if (responseId && typeof responseId === "number") {
        const storedUser = Cookies.get("user");

        if (storedUser) {
          try {
            const parsedUser = JSON.parse(storedUser) as { email?: string };
            const email = (parsedUser.email ?? "").trim().toLowerCase();

            if (email) {
              const storageKey = `my_books_${email}`;
              const existingBooksRaw = localStorage.getItem(storageKey);
              const existingBooks = existingBooksRaw
                ? (JSON.parse(existingBooksRaw) as Array<{ id?: number }>)
                : [];

              const selectedCategoryName =
                categories.find((category) => category.id === categoryId)?.name ||
                "";

              const updatedBooks = [
                {
                  id: responseId,
                  title,
                  authorName,
                  categoryName: selectedCategoryName,
                  imageURL: hasImageUrl ? imageUrl : "",
                  bookURL: hasBookUrl ? bookUrl : "",
                  addedAt: new Date().toISOString(),
                },
                ...existingBooks.filter((book) => book.id !== responseId),
              ];

              localStorage.setItem(storageKey, JSON.stringify(updatedBooks));
            }
          } catch (parseError) {
            console.warn("Failed to parse stored user data while saving my books cache.", parseError);
          }
        }

        const drawer = document.getElementById("addBookDrawer");
        if (drawer) {
          let offcanvas = Offcanvas.getInstance(drawer);
          if (!offcanvas) {
            offcanvas = new Offcanvas(drawer);
          }
          offcanvas.hide();
        }

        form.reset();
        setSelectedGenre("");
        setImageSourceType("url");
        setBookSourceType("url");
        setFormErrors([]);
        navigate(`/bookdetails/${responseId}`);
      }
    } catch (error) {
      console.error("Error adding book:", error);
      const message = error instanceof Error ? error.message : t("pleaseFillAllRequiredFields");
      setFormErrors([message]);
    } finally {
      setLoading(false);
    }
  };

  return (
    <div
      className="offcanvas offcanvas-end app-drawer add-book-drawer"
      tabIndex={-1}
      id="addBookDrawer"
      aria-labelledby="addBookDrawerLabel"
    >
      <div className="offcanvas-header">
        <h5 id="addBookDrawerLabel" className="offcanvas-title">
          {t("addNewBook")}
        </h5>
        <button
          type="button"
          className="btn-close text-reset"
          data-bs-dismiss="offcanvas"
          aria-label={t("close")}
        ></button>
      </div>

      <div className="offcanvas-body drawer-body">
        <form className="d-flex flex-column gap-3 drawer-form" onSubmit={handleSubmit}>
          {formErrors.length > 0 && (
            <div className="alert alert-danger add-book-validation" role="alert">
              <div className="fw-semibold mb-1">{t("pleaseFixFollowing")}</div>
              <ul className="mb-0 ps-3">
                {formErrors.map((message, index) => (
                  <li key={`${message}-${index}`}>{message}</li>
                ))}
              </ul>
            </div>
          )}

          <div className="drawer-field">
            <label className="form-label">{t("bookTitle")}</label>
            <input
              name="title"
              type="text"
              className="form-control"
              placeholder={t("enterBookTitle")!}
              required
            />
          </div>

          <div className="drawer-field">
            <label className="form-label">{t("authorName")}</label>
            <input
              name="authorName"
              type="text"
              className="form-control"
              placeholder={t("enterAuthorName")!}
              required
            />
          </div>

          <div className="drawer-field">
            <label className="form-label">{t("genre")}</label>
            <select
              name="genre"
              className="form-select"
              value={selectedGenre}
              onChange={(e) => setSelectedGenre(e.target.value)}
              required
            >
              <option value="">{t("selectGenre")}</option>
              {orderedCategories.map((categoryName, index) => {
                const translatedGenre = t(
                  `genres.${categoryName.toLowerCase()}`,
                  categoryName
                );
                return (
                  <option key={`${categoryName}-${index}`} value={categories.find((category) => category.name === categoryName)?.id}>
                    {translatedGenre}
                  </option>
                );
              })}
            </select>
          </div>

          <div className="drawer-field">
            <label className="form-label">{t("bookDescription")}</label>
            <textarea
              name="description"
              className="form-control"
              rows={3}
              placeholder={t("enterDescription")!}
            ></textarea>
          </div>

          <div className="drawer-field">
            <label className="form-label">{t("releasedDay")}</label>
            <input name="releasedDay" type="date" className="form-control" />
          </div>

          <div className="drawer-field">
            <label className="form-label">{t("pictureUrl")}</label>
            <div className="d-flex gap-3 mb-2">
              <div className="form-check">
                <input
                  className="form-check-input"
                  type="radio"
                  name="imageSourceType"
                  id="imageSourceUrl"
                  checked={imageSourceType === "url"}
                  onChange={() => setImageSourceType("url")}
                />
                <label className="form-check-label" htmlFor="imageSourceUrl">
                  URL
                </label>
              </div>
              <div className="form-check">
                <input
                  className="form-check-input"
                  type="radio"
                  name="imageSourceType"
                  id="imageSourceFile"
                  checked={imageSourceType === "file"}
                  onChange={() => setImageSourceType("file")}
                />
                <label className="form-check-label" htmlFor="imageSourceFile">
                  File
                </label>
              </div>
            </div>

            {imageSourceType === "url" ? (
              <input
                name="imageUrl"
                type="url"
                className="form-control"
                placeholder={t("enterPictureUrl")!}
                required
              />
            ) : (
              <input
                name="imageFile"
                type="file"
                accept="image/*"
                className="form-control"
                required
              />
            )}
          </div>

          <div className="drawer-field">
            <label className="form-label">{t("bookUrl")}</label>
            <div className="d-flex gap-3 mb-2">
              <div className="form-check">
                <input
                  className="form-check-input"
                  type="radio"
                  name="bookSourceType"
                  id="bookSourceUrl"
                  checked={bookSourceType === "url"}
                  onChange={() => setBookSourceType("url")}
                />
                <label className="form-check-label" htmlFor="bookSourceUrl">
                  URL
                </label>
              </div>
              <div className="form-check">
                <input
                  className="form-check-input"
                  type="radio"
                  name="bookSourceType"
                  id="bookSourceFile"
                  checked={bookSourceType === "file"}
                  onChange={() => setBookSourceType("file")}
                />
                <label className="form-check-label" htmlFor="bookSourceFile">
                  PDF
                </label>
              </div>
            </div>

            {bookSourceType === "url" ? (
              <input
                name="bookUrl"
                type="url"
                className="form-control"
                placeholder={t("enterBookUrl")!}
                required
              />
            ) : (
              <input
                name="bookFile"
                type="file"
                accept="application/pdf"
                className="form-control"
                required
              />
            )}
          </div>

          <button
            type="submit"
            className="btn btn-primary rounded-pill mt-2 py-2 drawer-submit-btn"
            disabled={loading}
          >
            {loading ? t("saving") + "..." : t("saveBook")}
          </button>
        </form>
      </div>
    </div>
  );
};

export default AddBookDrawer;
