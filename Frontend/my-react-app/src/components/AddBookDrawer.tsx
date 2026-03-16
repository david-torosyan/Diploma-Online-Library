import React, { useState, useEffect } from "react";
import { useTranslation } from "react-i18next";
import { LibraryClient, CategoryDto, AddBookDto } from "../api/LibraryClient";
import config from "../config/config.json";
import { useNavigate } from "react-router-dom";
import { Offcanvas } from "bootstrap";
import Cookies from "js-cookie";

const AddBookDrawer: React.FC = () => {
  const { t } = useTranslation();
  const [categories, setCategories] = useState<CategoryDto[]>([]);
  const [selectedGenre, setSelectedGenre] = useState<string>("");
  const [loading, setLoading] = useState<boolean>(false);
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

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();

    const form = e.target as HTMLFormElement;
    const formData = new FormData(form);

    const title = (formData.get("title") as string)?.trim() ?? "";
    const authorName = (formData.get("authorName") as string)?.trim() ?? "";
    const categoryId = Number(selectedGenre);
    const description = (formData.get("description") as string)?.trim() ?? "";
    const isbn = (formData.get("isbn") as string)?.trim() ?? "";
    const publishedDateString = formData.get("releasedDay") as string | null;
    const imageUrl = (formData.get("pictureUrl") as string)?.trim() ?? "";
    const bookUrl = (formData.get("bookUrl") as string)?.trim() ?? "";

    if (!title || !authorName || !categoryId || !bookUrl) {
      alert(t("pleaseFillAllRequiredFields"));
      return;
    }

    const publishedDate = publishedDateString
      ? new Date(publishedDateString)
      : new Date();

    const newBook = new AddBookDto({
      title,
      authorName,
      categoryId,
      description,
      isbn,
      publishedDate,
      bookUrl,
      imageUrl,
    });

    const token = Cookies.get("auth_token");
    if (!token) {
      alert(t("notLoggedIn"));
      return;
    }

    try {
      setLoading(true);
      const api = new LibraryClient(config.baseUrl);

      const responseId = await api.addBookWithAuthor(newBook, token);

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
                  imageURL: imageUrl,
                  bookURL: bookUrl,
                  addedAt: new Date().toISOString(),
                },
                ...existingBooks.filter((book) => book.id !== responseId),
              ];

              localStorage.setItem(storageKey, JSON.stringify(updatedBooks));
            }
          } catch {
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
        navigate(`/bookdetails/${responseId}`);
      }
    } catch (error) {
      console.error("Error adding book:", error);
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
              {categories.map((category) => {
                const genreKey = (category.name || "").toLowerCase();
                const translatedGenre = t(`genres.${genreKey}`, category.name || "");
                return (
                  <option key={category.id} value={category.id}>
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
            <label className="form-label">{t("isbnNumber")}</label>
            <input
              name="isbn"
              type="text"
              className="form-control"
              placeholder={t("enterIsbn")!}
            />
          </div>

          <div className="drawer-field">
            <label className="form-label">{t("releasedDay")}</label>
            <input name="releasedDay" type="date" className="form-control" />
          </div>

          <div className="drawer-field">
            <label className="form-label">{t("pictureUrl")}</label>
            <input
              name="pictureUrl"
              type="url"
              className="form-control"
              placeholder={t("enterPictureUrl")!}
            />
          </div>

          <div className="drawer-field">
            <label className="form-label">{t("bookUrl")}</label>
            <input
              name="bookUrl"
              type="url"
              className="form-control"
              placeholder={t("enterBookUrl")!}
              required
            />
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
