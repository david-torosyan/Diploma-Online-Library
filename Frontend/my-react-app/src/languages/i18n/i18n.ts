import i18n from "i18next";
import { initReactI18next } from "react-i18next";
import LanguageDetector from "i18next-browser-languagedetector";

// ✅ Import JSON files
import en from "../locales/en/translation.json";
import hy from "../locales/hy/translation.json";
import ru from "../locales/ru/translation.json";
import de from "../locales/de/translation.json";
import es from "../locales/es/translation.json";
import fr from "../locales/fr/translation.json";
import sa from "../locales/sa/translation.json";

i18n
  .use(LanguageDetector)
  .use(initReactI18next)
  .init({
    resources: {
      en: { translation: en },
      hy: { translation: hy },
      ru: { translation: ru },
      de: { translation: de },
      es: { translation: es },
      fr: { translation: fr },
      sa: { translation: sa }
    },
    fallbackLng: "en",
    interpolation: { escapeValue: false },
  });

export default i18n;
