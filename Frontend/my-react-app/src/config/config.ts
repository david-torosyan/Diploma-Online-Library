import rawConfig from "./config.json";

const envBaseUrl = import.meta.env.VITE_API_BASE_URL?.trim();

const config = {
  baseUrl: envBaseUrl || (import.meta.env.PROD
    ? rawConfig.productionBaseUrl
    : rawConfig.developmentBaseUrl),
};

export default config;
