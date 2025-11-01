import { useTranslation } from "react-i18next";
import Dropdown from "react-bootstrap/Dropdown";
import "flag-icons/css/flag-icons.min.css";

const languages = [
  { code: "en", label: "us", name: "English" },
  { code: "hy", label: "am", name: "Հայերեն" },
  { code: "ru", label: "ru", name: "Русский" },
  { code: "de", label: "de", name: "German" },
  { code: "es", label: "es", name: "Spanish" },
  { code: "fr", label: "fr", name: "French" },
  { code: "sa", label: "sa", name: "Arabic" },
];

const LanguageSwitcher: React.FC = () => {
  const { i18n } = useTranslation();
  const currentLang =
    languages.find((l) => l.code === i18n.language) || languages[0];

  return (
    <Dropdown align="end">
      <Dropdown.Toggle
        variant="outline-light"
        id="language-switcher"
        size="sm"
        className="rounded-2 px-3 py-1 d-flex align-items-center justify-content-center"
        style={{ height: "32px", minWidth: "45px" }} // ✅ keeps same size as other buttons
      >
        <span
          className={`fi fi-${currentLang.label} border rounded`}
          style={{
            width: "22px",
            height: "16px",
            objectFit: "cover",
          }}
        ></span>
      </Dropdown.Toggle>

      <Dropdown.Menu className="bg-white shadow-sm border-0 mt-1">
        {languages.map((lang) => (
          <Dropdown.Item
            key={lang.code}
            active={i18n.language === lang.code}
            onClick={() => i18n.changeLanguage(lang.code)}
            className="d-flex align-items-center gap-2 py-1"
          >
            <span
              className={`fi fi-${lang.label} border rounded`}
              style={{ width: "20px", height: "15px" }}
            ></span>
            <span>{lang.name}</span>
          </Dropdown.Item>
        ))}
      </Dropdown.Menu>
    </Dropdown>
  );
};

export default LanguageSwitcher;
