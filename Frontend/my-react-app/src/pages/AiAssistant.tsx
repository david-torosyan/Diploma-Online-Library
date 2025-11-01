import React, { useState, useEffect, useRef } from "react";
import { LibraryClient } from "../api/LibraryClient";
import config from "../config/config.json";
import ReactMarkdown from "react-markdown";
import { useTranslation } from "react-i18next";

interface ChatMessage {
  sender: "user" | "ai";
  text: string;
}

const AiAssistant: React.FC = () => {
  const { t } = useTranslation();
  const [messages, setMessages] = useState<ChatMessage[]>([]);
  const [input, setInput] = useState("");
  const [loading, setLoading] = useState(false);
  const chatEndRef = useRef<HTMLDivElement | null>(null);

  // 🌀 Auto-scroll to bottom when messages change
  useEffect(() => {
    chatEndRef.current?.scrollIntoView({ behavior: "smooth" });
  }, [messages]);

  const handleSend = async (e: React.FormEvent) => {
    e.preventDefault();
    if (!input.trim()) return;

    const newUserMessage: ChatMessage = { sender: "user", text: input };
    setMessages((prev) => [...prev, newUserMessage]);
    setInput("");
    setLoading(true);

    // Temporary "AI is typing..." message
    const typingMessage: ChatMessage = { sender: "ai", text: "typing" };
    setMessages((prev) => [...prev, typingMessage]);

    try {
      const api = new LibraryClient(config.baseUrl);
      const aiReply = await api.prompt(input);

      // Replace typing message with actual reply
      setMessages((prev) => {
        const updated = [...prev];
        updated[updated.length - 1] = { sender: "ai", text: aiReply };
        return updated;
      });
    } catch (err) {
      console.error("AI Assistant error:", err);
      setMessages((prev) => {
        const updated = [...prev];
        updated[updated.length - 1] = {
          sender: "ai",
          text: t("aiError")
        };
        return updated;
      });
    } finally {
      setLoading(false);
    }
  };

  return (
    <div
      className="offcanvas offcanvas-end"
      tabIndex={-1}
      id="aiAssistantDrawer"
      aria-labelledby="aiAssistantDrawerLabel"
    >
      <div className="offcanvas-header bg-primary text-white">
        <h5 id="aiAssistantDrawerLabel" className="offcanvas-title">
          🤖 {t("aiAssistantTitle")}
        </h5>
        <button
          type="button"
          className="btn-close btn-close-white"
          data-bs-dismiss="offcanvas"
          aria-label={t("close")}
        ></button>
      </div>

      <div className="offcanvas-body d-flex flex-column">
        {/* Chat Container */}
        <div className="flex-grow-1 mb-3 overflow-auto border rounded p-3 vh-70">
          {messages.length === 0 && (
            <p className="text-muted text-center">{t("askMeAnything")}</p>
          )}

          {messages.map((msg, idx) => (
            <div
              key={idx}
              className={`d-flex mb-2 ${
                msg.sender === "user"
                  ? "justify-content-end"
                  : "justify-content-start"
              }`}
            >
              <div
                className={`p-2 rounded shadow-sm ${
                  msg.sender === "user"
                    ? "bg-primary text-white"
                    : "bg-light text-dark"
                } w-75 text-break`}
              >
                {/* Typing animation */}
                {msg.sender === "ai" && msg.text === "typing" ? (
                  <div className="d-flex align-items-center">
                    <div className="spinner-grow spinner-grow-sm text-secondary me-2" />
                    <span className="text-muted">{t("aiTyping")}</span>
                  </div>
                ) : msg.sender === "ai" ? (
                  <ReactMarkdown>{msg.text}</ReactMarkdown>
                ) : (
                  msg.text
                )}
              </div>
            </div>
          ))}

          <div ref={chatEndRef}></div>
        </div>

        {/* Input Form */}
        <form onSubmit={handleSend} className="d-flex gap-2">
          <input
            type="text"
            className="form-control"
            placeholder={t("typeQuestion")}
            value={input}
            onChange={(e) => setInput(e.target.value)}
            disabled={loading}
          />
          <button
            type="submit"
            className="btn btn-primary px-3"
            disabled={loading || !input.trim()}
          >
            {loading ? (
              <span
                className="spinner-border spinner-border-sm text-light"
                role="status"
              ></span>
            ) : (
              t("send")
            )}
          </button>
        </form>
      </div>
    </div>
  );
};

export default AiAssistant;
