import React, { useRef, useState } from "react";
import { LibraryClient, LoginModel } from "../api/LibraryClient";
import { handleLoginResponse } from "../services/loginService.tsx";
import { useTranslation } from "react-i18next";
import config from "../config/config";

const SignIn: React.FC = () => {
  const { t } = useTranslation();

  const [error, setError] = useState<string | null>(null);
  const [loading, setLoading] = useState<boolean>(false);
  const emailRef = useRef<HTMLInputElement>(null);
  const passwordRef = useRef<HTMLInputElement>(null);

  const handleSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    setError(null);
    setLoading(true);

    try {
      const email = emailRef.current?.value.trim() ?? "";
      const password = passwordRef.current?.value ?? "";

      if (!email || !password) {
        setError(t("loginErrorDefault"));
        return;
      }

      const api = new LibraryClient(config.baseUrl);
      const loginModel = new LoginModel({ email, password });

      const response = await api.login(loginModel);
      handleLoginResponse(response);
    } catch (err) {
      const errorMsg =
        err instanceof Error ? err.message : t("loginErrorDefault");
      setError(errorMsg);
      console.error("Login error:", err);
    } finally {
      setLoading(false);
    }
  };

  return (
    <div
      className="offcanvas offcanvas-end"
      tabIndex={-1}
      id="signinDrawer"
      aria-labelledby="signinDrawerLabel"
    >
      <div className="offcanvas-header">
        <h5 id="signinDrawerLabel" className="offcanvas-title">
          {t("signIn")}
        </h5>
        <button
          type="button"
          className="btn-close text-reset"
          data-bs-dismiss="offcanvas"
          aria-label={t("close")}
        ></button>
      </div>

      <div className="offcanvas-body">
        <form onSubmit={handleSubmit} className="d-flex flex-column gap-2">
          <div className="mb-3">
            <label htmlFor="email" className="form-label">
              {t("emailAddress")}
            </label>
            <input
              type="email"
              className="form-control"
              id="email"
              ref={emailRef}
              autoComplete="username email"
              placeholder={t("enterEmail")}
              required
            />
          </div>

          <div className="mb-3">
            <label htmlFor="password" className="form-label">
              {t("password")}
            </label>
            <input
              type="password"
              className="form-control"
              id="password"
              ref={passwordRef}
              autoComplete="current-password"
              placeholder={t("enterPassword")}
              required
            />
          </div>

          {error && <div className="text-danger mb-2">{error}</div>}

          <button
            type="submit"
            className="btn btn-primary rounded-pill w-100 py-2"
            disabled={loading}
          >
            {loading ? t("signingIn") : t("signIn")}
          </button>

          <p className="mt-3 text-center">
            {t("noAccount")}{" "}
            <a
              href="#signupDrawer"
              data-bs-toggle="offcanvas"
              role="button"
              aria-controls="signupDrawer"
            >
              {t("register")}
            </a>
          </p>
        </form>
      </div>
    </div>
  );
};

export default SignIn;
