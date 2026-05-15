import axios from "axios";
import type { AxiosInstance } from "axios";
import Cookies from "js-cookie";

let sharedInstance: AxiosInstance | null = null;

export function getApiClientWithAuth(): AxiosInstance {
  if (sharedInstance) return sharedInstance;

  const instance = axios.create();

  instance.interceptors.request.use((config) => {
    try {
      const token = Cookies.get("auth_token");
      const has = !!token;
      // debug: indicate whether Authorization will be added
      // eslint-disable-next-line no-console
      console.debug("apiClient.request - hasAuthToken:", has);
      if (has) {
        if (!config.headers) config.headers = {} as any;
        (config.headers as any)["Authorization"] = `Bearer ${token}`;
      }
    } catch {
      // ignore cookie read errors
    }
    return config;
  });

  sharedInstance = instance;
  return instance;
}
