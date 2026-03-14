import React from "react";
import { useTranslation } from "react-i18next";

const Footer: React.FC = () => {
  const { t } = useTranslation();

  return (
    <footer className="footer-shell text-center py-4 px-3">
      <div className="container">
        © {new Date().getFullYear()} {t("appName")}. {t("allRightsReserved")}
      </div>
    </footer>
  );
};

export default Footer;
