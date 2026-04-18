import type { TFunction } from "i18next";

type AuthMode = "login" | "register";

export type RegisterFieldKey = "firstName" | "lastName" | "email" | "password";
export type LoginFieldKey = "email" | "password";

export type RegisterFieldErrors = Partial<Record<RegisterFieldKey, string>>;
export type LoginFieldErrors = Partial<Record<LoginFieldKey, string>>;

type AuthFieldErrors = Partial<Record<RegisterFieldKey, string>>;

const MIN_NAME_LENGTH = 2;
const MIN_PASSWORD_LENGTH = 8;

const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
const nameRegex = /^[\p{L}][\p{L}\s'-]*$/u;
const hasLowerLatin = /[a-z]/;
const hasUpperLatin = /[A-Z]/;
const hasDigit = /\d/;
const hasSymbol = /[^A-Za-z0-9\s]/;

const registerFieldByTranslationKey: Partial<Record<string, RegisterFieldKey>> = {
  validationFirstNameRequired: "firstName",
  validationFirstNameMinLength: "firstName",
  validationFirstNameLettersOnly: "firstName",
  validationLastNameRequired: "lastName",
  validationLastNameMinLength: "lastName",
  validationLastNameLettersOnly: "lastName",
  validationEmailRequired: "email",
  validationEmailInvalid: "email",
  authEmailAlreadyTaken: "email",
  validationPasswordRequired: "password",
  validationPasswordMinLength: "password",
  validationPasswordLatinLowercase: "password",
  validationPasswordLatinUppercase: "password",
  validationPasswordDigit: "password",
  validationPasswordSymbol: "password",
  validationPasswordNoSpaces: "password",
};

export function validateSignIn(
  email: string,
  password: string,
  t: TFunction
): LoginFieldErrors {
  const errors: LoginFieldErrors = {};

  if (!email.trim()) {
    errors.email = t("validationEmailRequired");
  } else if (!emailRegex.test(email.trim())) {
    errors.email = t("validationEmailInvalid");
  }

  if (!password) {
    errors.password = t("validationPasswordRequired");
  }

  return errors;
}

export function validateSignUp(
  firstName: string,
  lastName: string,
  email: string,
  password: string,
  t: TFunction
): RegisterFieldErrors {
  const errors: RegisterFieldErrors = {};
  const normalizedFirstName = firstName.trim();
  const normalizedLastName = lastName.trim();
  const normalizedEmail = email.trim();

  if (!normalizedFirstName) {
    errors.firstName = t("validationFirstNameRequired");
  } else if (normalizedFirstName.length < MIN_NAME_LENGTH) {
    errors.firstName = t("validationFirstNameMinLength", { min: MIN_NAME_LENGTH });
  } else if (!nameRegex.test(normalizedFirstName)) {
    errors.firstName = t("validationFirstNameLettersOnly");
  }

  if (!normalizedLastName) {
    errors.lastName = t("validationLastNameRequired");
  } else if (normalizedLastName.length < MIN_NAME_LENGTH) {
    errors.lastName = t("validationLastNameMinLength", { min: MIN_NAME_LENGTH });
  } else if (!nameRegex.test(normalizedLastName)) {
    errors.lastName = t("validationLastNameLettersOnly");
  }

  if (!normalizedEmail) {
    errors.email = t("validationEmailRequired");
  } else if (!emailRegex.test(normalizedEmail)) {
    errors.email = t("validationEmailInvalid");
  }

  if (!password) {
    errors.password = t("validationPasswordRequired");
  } else if (password.length < MIN_PASSWORD_LENGTH) {
    errors.password = t("validationPasswordMinLength", { min: MIN_PASSWORD_LENGTH });
  } else if (!hasLowerLatin.test(password)) {
    errors.password = t("validationPasswordLatinLowercase");
  } else if (!hasUpperLatin.test(password)) {
    errors.password = t("validationPasswordLatinUppercase");
  } else if (!hasDigit.test(password)) {
    errors.password = t("validationPasswordDigit");
  } else if (!hasSymbol.test(password)) {
    errors.password = t("validationPasswordSymbol");
  } else if (/\s/.test(password)) {
    errors.password = t("validationPasswordNoSpaces");
  }

  return errors;
}

export function resolveAuthError(
  error: unknown,
  t: TFunction,
  mode: AuthMode
): { globalError: string; fieldErrors: AuthFieldErrors } {
  const fallbackKey = mode === "login" ? "loginErrorDefault" : "registerErrorDefault";
  const rawMessage = extractErrorMessage(error);

  if (!rawMessage) {
    return { globalError: t(fallbackKey), fieldErrors: {} };
  }

  const key = mapAuthMessageToTranslationKey(rawMessage);

  if (key) {
    const mappedField = mode === "register" ? registerFieldByTranslationKey[key] : undefined;

    if (mappedField) {
      return {
        globalError: "",
        fieldErrors: {
          [mappedField]: t(key),
        },
      };
    }

    return {
      globalError: t(key),
      fieldErrors: {},
    };
  }

  return {
    globalError: rawMessage,
    fieldErrors: {},
  };
}

function extractErrorMessage(error: unknown): string {
  if (typeof error === "string") {
    return error.trim();
  }

  if (!error || typeof error !== "object") {
    return "";
  }

  const value = error as Record<string, unknown>;
  const directMessage =
    pickString(value.error) ||
    pickString(value.message) ||
    pickString(value.title) ||
    pickString(value.detail);

  if (directMessage) {
    return directMessage;
  }

  const errorsMessage = pickErrorCollection(value.errors);
  if (errorsMessage) {
    return errorsMessage;
  }

  const nestedResult = extractErrorMessage(value.result);
  if (nestedResult) {
    return nestedResult;
  }

  const nestedResponse = extractErrorMessage(value.response);
  if (nestedResponse) {
    return nestedResponse;
  }

  const nestedData = extractErrorMessage(value.data);
  if (nestedData) {
    return nestedData;
  }

  return "";
}

function pickString(value: unknown): string {
  if (typeof value === "string") {
    return value.trim();
  }

  return "";
}

function pickErrorCollection(value: unknown): string {
  if (!value || typeof value !== "object") {
    return "";
  }

  const entries = Object.values(value as Record<string, unknown>);

  for (const entry of entries) {
    if (typeof entry === "string") {
      return entry.trim();
    }

    if (Array.isArray(entry)) {
      const firstString = entry.find((item) => typeof item === "string");
      if (typeof firstString === "string" && firstString.trim()) {
        return firstString.trim();
      }
    }
  }

  return "";
}

function mapAuthMessageToTranslationKey(message: string): string | null {
  const normalized = message.toLowerCase();

  if (
    normalized.includes("username or password is incorrect") ||
    normalized.includes("wrong login") ||
    normalized.includes("invalid credentials")
  ) {
    return "authWrongLoginOrPassword";
  }

  if (normalized.includes("invalid login data")) {
    return "authInvalidLoginData";
  }

  if (normalized.includes("invalid registration data")) {
    return "authInvalidRegistrationData";
  }

  if (
    normalized.includes("email") &&
    (normalized.includes("already") || normalized.includes("exists") || normalized.includes("taken"))
  ) {
    return "authEmailAlreadyTaken";
  }

  if (normalized.includes("first name") && normalized.includes("required")) {
    return "validationFirstNameRequired";
  }

  if (normalized.includes("last name") && normalized.includes("required")) {
    return "validationLastNameRequired";
  }

  if (normalized.includes("email") && normalized.includes("required")) {
    return "validationEmailRequired";
  }

  if (normalized.includes("password") && normalized.includes("required")) {
    return "validationPasswordRequired";
  }

  if (normalized.includes("password") && normalized.includes("at least")) {
    return "validationPasswordMinLength";
  }

  if (normalized.includes("password") && normalized.includes("lowercase")) {
    return "validationPasswordLatinLowercase";
  }

  if (normalized.includes("password") && normalized.includes("uppercase")) {
    return "validationPasswordLatinUppercase";
  }

  if (normalized.includes("password") && normalized.includes("digit")) {
    return "validationPasswordDigit";
  }

  if (
    normalized.includes("password") &&
    (normalized.includes("non alphanumeric") ||
      normalized.includes("special") ||
      normalized.includes("symbol"))
  ) {
    return "validationPasswordSymbol";
  }

  if (normalized.includes("password") && normalized.includes("space")) {
    return "validationPasswordNoSpaces";
  }

  return null;
}