import React, { Suspense, lazy } from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Header from "./components/Header";
import Footer from "./components/Footer";
import ScrollToTopButton from "./components/ScrollToTopButton";
import RouteScrollReset from "./components/RouteScrollReset";

const Home = lazy(() => import("./pages/Home"));
const BookDetail = lazy(() => import("./pages/BookDetail"));
const CategoryBooks = lazy(() => import("./pages/CategoryBooks"));
const CollectionBooks = lazy(() => import("./pages/CollectionBooks"));

const App: React.FC = () => {
  return (
    <Router>
      <div className="app-shell">
        <RouteScrollReset />
        <Header />

        <main className="app-main">
          <Suspense
            fallback={
              <div className="container py-5 text-center loading-text">
                <div className="spinner-border" role="status" />
              </div>
            }
          >
            <Routes>
              <Route path="/" element={<Home />} />
              <Route path="/bookdetails/:id" element={<BookDetail />} />
              <Route path="/category/:categoryName" element={<CategoryBooks />} />
              <Route path="/collection/:collectionType" element={<CollectionBooks />} />
            </Routes>
          </Suspense>
        </main>

        <ScrollToTopButton />
        <Footer />
      </div>
    </Router>
  );
};

export default App;
