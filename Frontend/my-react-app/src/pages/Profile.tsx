import React, { useEffect, useState } from "react";
import Cookies from "js-cookie";
import { useTranslation } from "react-i18next";

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

  const handleLogout = () => {
    Cookies.remove("auth_token");
    Cookies.remove("user");
    window.location.reload();
  };

  // Not logged in
  if (!user) {
    return (
      <div
        className="offcanvas offcanvas-end"
        tabIndex={-1}
        id="profileDrawer"
        aria-labelledby="profileDrawerLabel"
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

  // Logged in view
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

        <div className="mt-4">
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
