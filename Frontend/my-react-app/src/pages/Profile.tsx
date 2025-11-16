import React, { useEffect, useState } from "react";
import { useTranslation } from "react-i18next";
import Cookies from "js-cookie";
import { Offcanvas } from "bootstrap";

interface User {
  firstName?: string;
  lastName?: string;
  email?: string;
}

const Profile: React.FC = () => {
  const { t } = useTranslation();
  const [user, setUser] = useState<User | null>(null);

  useEffect(() => {
    const storedUser = Cookies.get("user");
    if (storedUser) {
      try {
        const parsedUser = JSON.parse(storedUser);
        setUser(parsedUser);
      } catch {
        setUser(null);
      }
    }
  }, []);

  useEffect(() => {
    function handleOutsideClick(event: MouseEvent) {
      const drawer = document.getElementById("profileDrawer");
      if (!drawer) return;

      const isOpen = drawer.classList.contains("show");
      const clickedInside = drawer.contains(event.target as Node);

      if (isOpen && !clickedInside) {
        let instance = Offcanvas.getInstance(drawer);
        if (!instance) instance = new Offcanvas(drawer);
        instance.hide();
      }
    }

    document.addEventListener("click", handleOutsideClick);

    return () => {
      document.removeEventListener("click", handleOutsideClick);
    };
  }, []);

  const handleLogout = () => {
    Cookies.remove("auth_token");
    Cookies.remove("user");
    window.location.reload();
  };

  if (!user) {
    return (
      <div
        className="offcanvas offcanvas-end"
        tabIndex={-1}
        id="profileDrawer"
        aria-labelledby="profileDrawerLabel"
        data-bs-backdrop="false"
        data-bs-scroll="true"
      >
        <div className="offcanvas-header">
          <h5 id="profileDrawerLabel" className="offcanvas-title">
            {t("profile")}
          </h5>
          <button
            type="button"
            className="btn-close text-reset"
            data-bs-dismiss="offcanvas"
            aria-label={t("close")}
          ></button>
        </div>
        <div className="offcanvas-body">
          <p>{t("notLoggedIn")}</p>
        </div>
      </div>
    );
  }

  return (
    <div
      className="offcanvas offcanvas-end"
      tabIndex={-1}
      id="profileDrawer"
      aria-labelledby="profileDrawerLabel"
    >
      <div className="offcanvas-header">
        <h5 id="profileDrawerLabel" className="offcanvas-title">
          {t("myProfile")}
        </h5>
        <button
          type="button"
          className="btn-close text-reset"
          data-bs-dismiss="offcanvas"
          aria-label={t("close")}
        ></button>
      </div>

      <div className="offcanvas-body">
        <div className="d-flex flex-column gap-2">
          <div>
            <strong>{t("firstName")}:</strong> {user.firstName || "N/A"}
          </div>
          <div>
            <strong>{t("lastName")}:</strong> {user.lastName || "N/A"}
          </div>
          <div>
            <strong>{t("emailAddress")}:</strong> {user.email || "N/A"}
          </div>
        </div>

        <div className="mt-4 d-flex flex-column gap-2">
          {/* Open Add Book Drawer */}
          <button
            className="btn btn-outline-success w-100"
            data-bs-toggle="offcanvas"
            data-bs-target="#addBookDrawer"
          >
            ➕ {t("addBook")}
          </button>

          <button
            className="btn btn-outline-danger w-100"
            onClick={handleLogout}
          >
            {t("logout")}
          </button>
        </div>
      </div>
    </div>
  );
};

export default Profile;
