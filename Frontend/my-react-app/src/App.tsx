import React from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Header from "./components/Header";
import Footer from "./components/Footer";
import Home from "./pages/Home";
import BookDetail from "./pages/BookDetail";
import CategoryBooks from "./pages/CategoryBooks";

const App: React.FC = () => {
  return (
    <Router>  
      <Header />
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/bookdetails/:id" element={<BookDetail />} />
        <Route path="/category/:categoryName" element={<CategoryBooks />} />
      </Routes>
      <Footer />
    </Router>
  );
};

export default App;
