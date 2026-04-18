import React, { useState } from "react";
import { LibraryClient, LoginModel } from "../api/LibraryClient";
import { handleLoginResponse } from "../services/loginService.tsx";
import { useTranslation } from "react-i18next";
import config from "../config/config";
import { resolveAuthError, validateSignIn } from "../utils/authValidation";

const SignIn: React.FC = () => {
  const { t } = useTranslation();

  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState<string | null>(null);
  const [fieldErrors, setFieldErrors] = useState<Partial<Record<"email" | "password", string>>>({});
  const [loading, setLoading] = useState<boolean>(false);

  const handleSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    setError(null);
    setFieldErrors({});
    setLoading(true);

    try {
      const normalizedEmail = email.trim();
      const localErrors = validateSignIn(normalizedEmail, password, t);

      if (Object.keys(localErrors).length > 0) {
        setFieldErrors(localErrors);
        setError(localErrors.email || localErrors.password || t("loginErrorDefault"));
        return;
      }

      const api = new LibraryClient(config.baseUrl);
      const loginModel = new LoginModel({ email: normalizedEmail, password });

      const response = await api.login(loginModel);
      handleLoginResponse(response);
    } catch (err) {
      const { globalError } = resolveAuthError(err, t, "login");
      setError(globalError || t("loginErrorDefault"));
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
        <form onSubmit={handleSubmit} noValidate className="d-flex flex-column gap-2">
          <div className="mb-3">
            <label htmlFor="email" className="form-label">
              {t("emailAddress")}
            </label>
            <input
              type="email"
              className={`form-control ${fieldErrors.email ? "is-invalid" : ""}`}
              id="email"
              value={email}
              onChange={(e) => {
                setEmail(e.target.value);
                setFieldErrors((prev) => ({ ...prev, email: "" }));
              }}
              autoComplete="username email"
              placeholder={t("enterEmail")}
              required
            />
            {fieldErrors.email && <div className="invalid-feedback">{fieldErrors.email}</div>}
          </div>

          <div className="mb-3">
            <label htmlFor="password" className="form-label">
              {t("password")}
            </label>
            <input
              type="password"
              className={`form-control ${fieldErrors.password ? "is-invalid" : ""}`}
              id="password"
              value={password}
              onChange={(e) => {
                setPassword(e.target.value);
                setFieldErrors((prev) => ({ ...prev, password: "" }));
              }}
              autoComplete="current-password"
              placeholder={t("enterPassword")}
              required
            />
            {fieldErrors.password && (
              <div className="invalid-feedback">{fieldErrors.password}</div>
            )}
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
            <button
              type="button"
              className="btn btn-link p-0 align-baseline"
              data-bs-toggle="offcanvas"
              data-bs-target="#signupDrawer"
              role="button"
              aria-controls="signupDrawer"
            >
              {t("register")}
            </button>
          </p>
        </form>
      </div>
    </div>
  );
};

export default SignIn;
