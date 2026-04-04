import React, { useEffect, useState } from "react";
import { useTranslation } from "react-i18next";
import { Link } from "react-router-dom";
import SignIn from "../pages/SignIn";
import SignUp from "../pages/SignUp";
import Cookies from "js-cookie";
import Profile from "../pages/Profile";
import AiAssistant from "../pages/AiAssistant";
import LanguageSwitcher from "../languages/LanguageSwitcher";
import AddBookDrawer from "../components/AddBookDrawer";
import MyBooksDrawer from "../components/MyBooksDrawer";
import AdminMessagesDrawer from "../components/AdminMessagesDrawer";
import { isAdminUser } from "../utils/auth";

const Header: React.FC = () => {
  const [isAuthenticated, setIsAuthenticated] = useState(false);
  const [isAdmin, setIsAdmin] = useState(false);
  const [userName, setUserName] = useState<string>("");
  const { t } = useTranslation();

  useEffect(() => {
    const syncAuthState = () => {
      const user = Cookies.get("user");

      if (user) {
        setIsAuthenticated(true);
        setIsAdmin(isAdminUser());
        try {
          const parsedUser = JSON.parse(user);
          setUserName(
            "👋 " + (parsedUser.firstName || parsedUser.email || t("profile"))
          );
        } catch {
          setUserName(t("profile"));
        }
      } else {
        setIsAuthenticated(false);
        setIsAdmin(false);
        setUserName("");
      }
    };

    syncAuthState();
    window.addEventListener("focus", syncAuthState);

    return () => {
      window.removeEventListener("focus", syncAuthState);
    };
  }, [t]);

  return (
    <>
      <header className="navbar navbar-expand-lg navbar-dark app-navbar px-3 px-lg-4 py-2 py-lg-3">
        <Link className="navbar-brand fw-bold text-white app-brand" to="/">
          {t("appName")}
        </Link>

        <button
          className="navbar-toggler"
          type="button"
          data-bs-toggle="collapse"
          data-bs-target="#navbarNav"
          aria-controls="navbarNav"
          aria-expanded="false"
          aria-label="Toggle navigation"
        >
          <span className="navbar-toggler-icon"></span>
        </button>

        <div
          className="collapse navbar-collapse justify-content-end"
          id="navbarNav"
        >
          <ul className="navbar-nav align-items-center gap-2 flex-wrap">
            <li className="nav-item">
              <button
                className="btn btn-outline-light nav-chip px-3 py-1"
                data-bs-toggle="offcanvas"
                data-bs-target="#aiAssistantDrawer"
                aria-controls="aiAssistantDrawer"
              >
                🤖 {t("aiAssistant")}
              </button>
            </li>

            <li className="nav-item">
              <Link className="btn btn-outline-light nav-chip px-3 py-1" to="/">
                {t("library")}
              </Link>
            </li>

            <li className="nav-item">
              <Link className="btn btn-outline-light nav-chip px-3 py-1" to="/explore">
                {t("explore", "Explore")}
              </Link>
            </li>

            {isAuthenticated ? (
              <>
                {isAdmin && (
                  <li className="nav-item">
                    <button
                      className="btn btn-outline-light nav-chip px-3 py-1"
                      data-bs-toggle="offcanvas"
                      data-bs-target="#adminMessagesDrawer"
                      aria-controls="adminMessagesDrawer"
                    >
                      🔔 {t("messages")}
                    </button>
                  </li>
                )}

                <li className="nav-item">
                  <button
                    className="btn btn-outline-light nav-chip px-3 py-1"
                    data-bs-toggle="offcanvas"
                    data-bs-target="#myBooksDrawer"
                    aria-controls="myBooksDrawer"
                  >
                    📚 {t("myBooks")}
                  </button>
                </li>

                <li className="nav-item">
                  <button
                    type="button"
                    className="btn btn-outline-light nav-chip px-3 py-1"
                    data-bs-toggle="offcanvas"
                    data-bs-target="#profileDrawer"
                  >
                    {userName}
                  </button>
                </li>
              </>
            ) : (
              <li className="nav-item">
                <button
                  className="btn btn-outline-light nav-chip px-3 py-1"
                  data-bs-toggle="offcanvas"
                  data-bs-target="#signinDrawer"
                  aria-controls="signinDrawer"
                >
                  {t("signIn")}
                </button>
              </li>
            )}

            <li className="nav-item">
              <LanguageSwitcher />
            </li>
          </ul>
        </div>
      </header>

      <SignIn />
      <SignUp />
      <Profile />
      <AddBookDrawer />
      <MyBooksDrawer />
      <AdminMessagesDrawer />
      <AiAssistant />
    </>
  );
};

export default Header;
