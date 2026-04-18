import React, { useState } from "react";
import { LibraryClient, RegisterModel, LoginModel } from "../api/LibraryClient";
import { handleLoginResponse } from "../services/loginService.tsx";
import { useTranslation } from "react-i18next";
import config from "../config/config";

const SignUp: React.FC = () => {
  const { t } = useTranslation();

  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const [success, setSuccess] = useState(false);
  const [fieldErrors, setFieldErrors] = useState<Record<string, string>>({});

  const handleSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    setError(null);
    setFieldErrors({});
    setLoading(true);

    try {
      const api = new LibraryClient(config.baseUrl);
      const body = new RegisterModel({
        firstName,
        lastName,
        email,
        password,
      });

      const response = await api.register(body);

      if (response?.message === "Registration successful.") {
        setSuccess(true);
        const loginModel = new LoginModel({ email, password });
        const loginResponse = await api.login(loginModel);
        handleLoginResponse(loginResponse);
      }
    } catch (err) {
      setFieldErrors({});
      setError(t("authWrongLoginOrPassword"));
      console.error("Registration error:", err);
    } finally {
      setLoading(false);
    }
  };

  return (
    <div
      className="offcanvas offcanvas-end"
      tabIndex={-1}
      id="signupDrawer"
      aria-labelledby="signupDrawerLabel"
    >
      <div className="offcanvas-header">
        <h5 id="signupDrawerLabel" className="offcanvas-title">
          {t("register")}
        </h5>
        <button
          type="button"
          className="btn-close text-reset"
          data-bs-dismiss="offcanvas"
          aria-label={t("close")}
        ></button>
      </div>

      <div className="offcanvas-body">
        <form onSubmit={handleSubmit} className="d-flex flex-column gap-1">
          <div className="row">
            {/* First Name */}
            <div className="col-md-6 mb-3">
              <label htmlFor="firstName" className="form-label">
                {t("firstName")}
              </label>
              <input
                type="text"
                className={`form-control ${
                  fieldErrors.firstname ? "is-invalid" : ""
                }`}
                id="firstName"
                value={firstName}
                onChange={(e) => {
                  setFirstName(e.target.value);
                  setFieldErrors((prev) => ({ ...prev, firstname: "" }));
                }}
                placeholder={t("enterFirstName")}
                required
              />
              {fieldErrors.firstname && (
                <div className="invalid-feedback">{fieldErrors.firstname}</div>
              )}
            </div>

            {/* Last Name */}
            <div className="col-md-6 mb-3">
              <label htmlFor="lastName" className="form-label">
                {t("lastName")}
              </label>
              <input
                type="text"
                className={`form-control ${
                  fieldErrors.lastname ? "is-invalid" : ""
                }`}
                id="lastName"
                value={lastName}
                onChange={(e) => {
                  setLastName(e.target.value);
                  setFieldErrors((prev) => ({ ...prev, lastname: "" }));
                }}
                placeholder={t("enterLastName")}
                required
              />
              {fieldErrors.lastname && (
                <div className="invalid-feedback">{fieldErrors.lastname}</div>
              )}
            </div>
          </div>

          {/* Email */}
          <div className="mb-3">
            <label htmlFor="email" className="form-label">
              {t("emailAddress")}
            </label>
            <input
              type="email"
              className={`form-control ${
                fieldErrors.email ? "is-invalid" : ""
              }`}
              id="email"
              value={email}
              onChange={(e) => {
                setEmail(e.target.value);
                setFieldErrors((prev) => ({ ...prev, email: "" }));
              }}
              placeholder={t("enterEmail")}
              required
            />
            {fieldErrors.email && (
              <div className="invalid-feedback">{fieldErrors.email}</div>
            )}
          </div>

          {/* Password */}
          <div className="mb-3">
            <label htmlFor="password" className="form-label">
              {t("password")}
            </label>
            <input
              type="password"
              className={`form-control ${
                fieldErrors.password ? "is-invalid" : ""
              }`}
              id="password"
              value={password}
              onChange={(e) => {
                setPassword(e.target.value);
                setFieldErrors((prev) => ({ ...prev, password: "" }));
              }}
              placeholder={t("enterPassword")}
              required
            />
            {fieldErrors.password && (
              <div className="invalid-feedback">{fieldErrors.password}</div>
            )}
          </div>

          {/* Global message */}
          {error && <p className="text-danger small">{error}</p>}
          {success && (
            <p className="text-success small">{t("registrationSuccess")}</p>
          )}

          <button
            type="submit"
            className="btn btn-primary rounded-pill w-100 py-2"
            disabled={loading}
          >
            {loading ? t("registering") : t("register")}
          </button>

          <p className="mt-3 text-center">
            {t("alreadyHaveAccount")}{" "}
            <button
              type="button"
              className="btn btn-link p-0 align-baseline"
              data-bs-toggle="offcanvas"
              data-bs-target="#signinDrawer"
              role="button"
              aria-controls="signinDrawer"
            >
              {t("signIn")}
            </button>
          </p>
        </form>
      </div>
    </div>
  );
};

export default SignUp;
