import Cookies from "js-cookie";

function parseJwtPayload(token: string): Record<string, unknown> | null {
  try {
    const payload = token.split(".")[1];
    if (!payload) return null;

    const base64 = payload.replace(/-/g, "+").replace(/_/g, "/");
    const padded = base64.padEnd(Math.ceil(base64.length / 4) * 4, "=");
    const decoded = atob(padded);
    return JSON.parse(decoded) as Record<string, unknown>;
  } catch {
    return null;
  }
}

function extractRoles(source: Record<string, unknown> | null): string[] {
  if (!source) return [];

  const candidates = [
    source.role,
    source.roles,
    source["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"],
    source["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/role"],
  ];

  return candidates.flatMap((value) => {
    if (typeof value === "string") return [value.toLowerCase()];
    if (Array.isArray(value)) {
      return value
        .filter((item): item is string => typeof item === "string")
        .map((item) => item.toLowerCase());
    }
    return [];
  });
}

function extractClaim(
  source: Record<string, unknown> | null,
  claimKeys: string[]
): string | undefined {
  if (!source) return undefined;

  for (const key of claimKeys) {
    const value = source[key];
    if (typeof value === "string" && value.trim()) {
      return value;
    }
  }

  return undefined;
}

export function getAuthToken(): string | undefined {
  return Cookies.get("auth_token");
}

export function getCurrentUserId(): string | undefined {
  const token = getAuthToken();
  if (!token) return undefined;

  return extractClaim(parseJwtPayload(token), [
    "sub",
    "nameid",
    "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier",
    "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name",
  ]);
}

export function isAdminUser(): boolean {
  const userCookie = Cookies.get("user");
  if (userCookie) {
    try {
      const parsed = JSON.parse(userCookie) as Record<string, unknown>;
      if (extractRoles(parsed).includes("admin")) {
        return true;
      }
    } catch {
      // ignore invalid cookie payload
    }
  }

  const token = getAuthToken();
  if (!token) return false;

  return extractRoles(parseJwtPayload(token)).includes("admin");
}
