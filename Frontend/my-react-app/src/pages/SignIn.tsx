import React, { useState } from "react";
import { LibraryClient, LoginModel } from "../api/LibraryClient";
import { handleLoginResponse } from "../services/loginService.tsx";
import { useTranslation } from "react-i18next";
import config from "../config/config.json";

const SignIn: React.FC = () => {
  const { t } = useTranslation();

  const [email, setEmail] = useState<string>("");
  const [password, setPassword] = useState<string>("");
  const [error, setError] = useState<string | null>(null);
  const [loading, setLoading] = useState<boolean>(false);

  const handleSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    setError(null);
    setLoading(true);

    try {
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
        <form onSubmit={handleSubmit}>
          {/* Email Field */}
          <div className="mb-3">
            <label htmlFor="email" className="form-label">
              {t("emailAddress")}
            </label>
            <input
              type="email"
              className="form-control"
              id="email"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
              placeholder={t("enterEmail")}
              required
            />
          </div>

          {/* Password Field */}
          <div className="mb-3">
            <label htmlFor="password" className="form-label">
              {t("password")}
            </label>
            <input
              type="password"
              className="form-control"
              id="password"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
              placeholder={t("enterPassword")}
              required
            />
          </div>

          {/* Error Message */}
          {error && <div className="text-danger mb-2">{error}</div>}

          {/* Submit Button */}
          <button
            type="submit"
            className="btn btn-primary w-100"
            disabled={loading}
          >
            {loading ? t("signingIn") : t("signIn")}
          </button>

          {/* Register Link */}
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
