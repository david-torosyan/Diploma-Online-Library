import rawConfig from "./config.json";

const config = {
  baseUrl: import.meta.env.PROD
    ? rawConfig.productionBaseUrl
    : rawConfig.developmentBaseUrl,
};

export default config;
