import React, { useEffect, useRef, useState } from "react";
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
import { getAuthToken, isAdminUser } from "../utils/auth";
import { Collapse, Offcanvas } from "bootstrap";
import { LibraryClient } from "../api/LibraryClient";
import { createChatHubConnection, getUnreadCount } from "../services/chatService";
import config from "../config/config";

const Header: React.FC = () => {
  const [isAuthenticated, setIsAuthenticated] = useState(false);
  const [isAdmin, setIsAdmin] = useState(false);
  const [unapprovedCount, setUnapprovedCount] = useState(0);
  const [chatUnreadCount, setChatUnreadCount] = useState(0);
  const [userName, setUserName] = useState<string>("");
  const [isNavbarExpanded, setIsNavbarExpanded] = useState(false);
  const { t } = useTranslation();
  const isSwitchingOffcanvasRef = useRef(false);

  const hideNavbarMenu = () => {
    const navbar = document.getElementById("navbarNav");
    if (!navbar || !navbar.classList.contains("show")) {
      return;
    }

    const collapse = Collapse.getOrCreateInstance(navbar, { toggle: false });
    collapse.hide();
  };

  const handleNavbarToggle = () => {
    const navbar = document.getElementById("navbarNav");
    if (!navbar) {
      return;
    }

    const collapse = Collapse.getOrCreateInstance(navbar, { toggle: false });
    if (navbar.classList.contains("show")) {
      collapse.hide();
      return;
    }

    collapse.show();
  };

  const handleCloseDrawers = () => {
    hideNavbarMenu();
    document.querySelectorAll<HTMLElement>(".offcanvas.show").forEach((drawer) => {
      const instance = Offcanvas.getOrCreateInstance(drawer);
      instance.hide();
    });
  };

  useEffect(() => {
    let unreadPollingInterval: number | undefined;
    const navbar = document.getElementById("navbarNav");

    const handleNavbarShown = () => setIsNavbarExpanded(true);
    const handleNavbarHidden = () => setIsNavbarExpanded(false);

    if (navbar) {
      navbar.addEventListener("shown.bs.collapse", handleNavbarShown);
      navbar.addEventListener("hidden.bs.collapse", handleNavbarHidden);
    }

    const loadUnapprovedCount = async () => {
      if (!isAdmin) {
        setUnapprovedCount(0);
        return;
      }

      const token = getAuthToken();
      if (!token) {
        setUnapprovedCount(0);
        return;
      }

      try {
        const api = new LibraryClient(config.baseUrl);
        const result = await api.unapproved(token);
        setUnapprovedCount(Array.isArray(result) ? result.length : 0);
      } catch {
        setUnapprovedCount(0);
      }
    };

    const loadChatUnreadCount = async () => {
      const token = getAuthToken();
      if (!token) {
        setChatUnreadCount(0);
        return;
      }

      try {
        const unread = await getUnreadCount(token);
        setChatUnreadCount(unread);
      } catch {
        setChatUnreadCount(0);
      }
    };

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
        setUnapprovedCount(0);
        setChatUnreadCount(0);
        setUserName("");
      }
    };

    const handleUnapprovedCountChanged = (event: Event) => {
      const customEvent = event as CustomEvent<number>;
      const nextCount = typeof customEvent.detail === "number" ? customEvent.detail : 0;
      setUnapprovedCount(nextCount);
    };

    const handleChatUnreadCountChanged = (event: Event) => {
      const customEvent = event as CustomEvent<number>;
      const nextCount = typeof customEvent.detail === "number" ? customEvent.detail : 0;
      setChatUnreadCount(nextCount);
    };

    const handleOffcanvasSwitch = (event: Event) => {
      const target = event.target as HTMLElement | null;
      if (!target) return;

      const trigger = target.closest<HTMLElement>("[data-bs-toggle='offcanvas']");
      if (!trigger) return;

      const selector =
        trigger.getAttribute("data-bs-target") ||
        trigger.getAttribute("href");

      if (!selector || !selector.startsWith("#")) return;

      const nextDrawer = document.querySelector<HTMLElement>(selector);
      if (!nextDrawer) return;

      const currentDrawer = document.querySelector<HTMLElement>(".offcanvas.show");
      if (!currentDrawer || currentDrawer === nextDrawer) return;

      if (isSwitchingOffcanvasRef.current) {
        event.preventDefault();
        return;
      }

      event.preventDefault();
      hideNavbarMenu();

      const currentInstance = Offcanvas.getOrCreateInstance(currentDrawer);
      const nextInstance = Offcanvas.getOrCreateInstance(nextDrawer);

      isSwitchingOffcanvasRef.current = true;

      const openNext = () => {
        nextInstance.show();
        isSwitchingOffcanvasRef.current = false;
      };

      currentDrawer.addEventListener("hidden.bs.offcanvas", openNext, {
        once: true,
      });
      currentInstance.hide();
    };

    const handleWindowFocus = () => {
      syncAuthState();
      loadUnapprovedCount();
      loadChatUnreadCount();
    };

    syncAuthState();
    loadUnapprovedCount();
    loadChatUnreadCount();

    const token = getAuthToken();
    const hub = token ? createChatHubConnection(token) : null;

    if (hub) {
      hub.on("MessageReceived", () => {
        loadChatUnreadCount();
      });

      hub.onreconnected(() => {
        loadChatUnreadCount();
      });

      hub.start().catch(() => {
        setChatUnreadCount(0);
      });
    }

    // Keep unread badge fresh even outside Messenger route.
    unreadPollingInterval = window.setInterval(() => {
      loadChatUnreadCount();
    }, 10000);

    window.addEventListener("focus", handleWindowFocus);
    document.addEventListener("click", handleOffcanvasSwitch);
    window.addEventListener("admin-unapproved-count-changed", handleUnapprovedCountChanged as EventListener);
    window.addEventListener("chat-unread-count-changed", handleChatUnreadCountChanged as EventListener);

    return () => {
      if (hub) {
        hub.stop().catch(() => undefined);
      }
      if (unreadPollingInterval) {
        window.clearInterval(unreadPollingInterval);
      }
      window.removeEventListener("focus", handleWindowFocus);
      document.removeEventListener("click", handleOffcanvasSwitch);
      window.removeEventListener("admin-unapproved-count-changed", handleUnapprovedCountChanged as EventListener);
      window.removeEventListener("chat-unread-count-changed", handleChatUnreadCountChanged as EventListener);
      if (navbar) {
        navbar.removeEventListener("shown.bs.collapse", handleNavbarShown);
        navbar.removeEventListener("hidden.bs.collapse", handleNavbarHidden);
      }
    };
  }, [isAdmin, t]);

  return (
    <>
      <header className="navbar navbar-expand-lg navbar-dark app-navbar px-3 px-lg-4 py-2 py-lg-3">
        <Link className="navbar-brand fw-bold text-white app-brand" to="/">
          <img src="/biblosLogo.png" alt="Biblos logo" className="app-brand-logo" />
          <span className="app-brand-text">{t("appName")}</span>
        </Link>

        <button
          className="navbar-toggler"
          type="button"
          aria-controls="navbarNav"
          aria-expanded={isNavbarExpanded}
          aria-label="Toggle navigation"
          onClick={handleNavbarToggle}
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
                onClick={hideNavbarMenu}
              >
                🤖 {t("aiAssistant")}
              </button>
            </li>

            <li className="nav-item">
              <Link 
                className="btn btn-outline-light nav-chip px-3 py-1" 
                to="/"
                onClick={handleCloseDrawers}
              >
                {t("library")}
              </Link>
            </li>

            {isAuthenticated ? (
              <>
                {isAdmin && (
                  <li className="nav-item">
                    <button
                      className="btn btn-outline-light nav-chip px-3 py-1 position-relative"
                      data-bs-toggle="offcanvas"
                      data-bs-target="#adminMessagesDrawer"
                      aria-controls="adminMessagesDrawer"
                      onClick={hideNavbarMenu}
                    >
                      🔔 {t("messages")}
                      {unapprovedCount > 0 && (
                        <span className="messages-badge" aria-label={t("pendingApprovalsAria", { count: unapprovedCount })}>
                          {unapprovedCount}
                        </span>
                      )}
                    </button>
                  </li>
                )}

                <li className="nav-item">
                  <button
                    className="btn btn-outline-light nav-chip px-3 py-1"
                    data-bs-toggle="offcanvas"
                    data-bs-target="#myBooksDrawer"
                    aria-controls="myBooksDrawer"
                    onClick={hideNavbarMenu}
                  >
                    📚 {t("myBooks")}
                  </button>
                </li>

                <li className="nav-item">
                  <Link className="btn btn-outline-light nav-chip px-3 py-1 position-relative" to="/messenger" onClick={handleCloseDrawers}>
                    💬 {t("messenger")}
                    {chatUnreadCount > 0 && (
                      <span className="messages-badge" aria-label={`You have ${chatUnreadCount} unread chat messages`}>
                        {chatUnreadCount}
                      </span>
                    )}
                  </Link>
                </li>

                <li className="nav-item">
                  <button
                    type="button"
                    className="btn btn-outline-light nav-chip px-3 py-1"
                    data-bs-toggle="offcanvas"
                    data-bs-target="#profileDrawer"
                    onClick={hideNavbarMenu}
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
                  onClick={hideNavbarMenu}
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
