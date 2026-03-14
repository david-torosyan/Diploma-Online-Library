import { useEffect } from "react";
import { useLocation } from "react-router-dom";

const RouteScrollReset: React.FC = () => {
  const { pathname, search } = useLocation();

  useEffect(() => {
    window.scrollTo({ top: 0, behavior: "smooth" });
  }, [pathname, search]);

  return null;
};

export default RouteScrollReset;
