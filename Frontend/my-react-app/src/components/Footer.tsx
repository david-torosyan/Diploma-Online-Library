import React from "react";
import { useTranslation } from "react-i18next";

const Footer: React.FC = () => {
  const { t } = useTranslation();

  return (
    <footer className="bg-gray-200 text-center p-4 text-sm text-gray-600">
      © {new Date().getFullYear()} {t("appName")}. {t("allRightsReserved")}
    </footer>
  );
};

export default Footer;
