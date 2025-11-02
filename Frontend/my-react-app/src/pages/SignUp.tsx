import React, { useState } from "react";
import { LibraryClient, RegisterModel, LoginModel } from "../api/LibraryClient";
import { handleLoginResponse } from "../services/loginService.tsx";
import { useTranslation } from "react-i18next";
import config from "../config/config.json";

const SignUp: React.FC = () => {
  const { t } = useTranslation();

  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const [success, setSuccess] = useState(false);

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    setError(null);
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
      console.error(err);
      setError(t("registerErrorDefault"));
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
        <form onSubmit={handleSubmit}>
          <div className="row">
            <div className="col-md-6 mb-3">
              <label htmlFor="firstName" className="form-label">
                {t("firstName")}
              </label>
              <input
                type="text"
                className="form-control"
                id="firstName"
                value={firstName}
                onChange={(e) => setFirstName(e.target.value)}
                placeholder={t("enterFirstName")}
                required
              />
            </div>
            <div className="col-md-6 mb-3">
              <label htmlFor="lastName" className="form-label">
                {t("lastName")}
              </label>
              <input
                type="text"
                className="form-control"
                id="lastName"
                value={lastName}
                onChange={(e) => setLastName(e.target.value)}
                placeholder={t("enterLastName")}
                required
              />
            </div>
          </div>

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

          {error && <p className="text-danger small">{error}</p>}
          {success && (
            <p className="text-success small">{t("registrationSuccess")}</p>
          )}

          <button
            type="submit"
            className="btn btn-primary w-100"
            disabled={loading}
          >
            {loading ? t("registering") : t("register")}
          </button>

          <p className="mt-3 text-center">
            {t("alreadyHaveAccount")}{" "}
            <a
              href="#signinDrawer"
              data-bs-toggle="offcanvas"
              role="button"
              aria-controls="signinDrawer"
            >
              {t("signIn")}
            </a>
          </p>
        </form>
      </div>
    </div>
  );
};

export default SignUp;
