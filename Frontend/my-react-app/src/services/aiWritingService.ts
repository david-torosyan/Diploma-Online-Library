import axios from "axios";
import config from "../config/config.json";

const api = axios.create({
  baseURL: config.baseUrl,
});

type ImproveTextResponse = {
  improvedText?: string;
};

/**
 * Improves the provided text using AI suggestions
 * @param text The text to improve
 * @param context Optional context (e.g., "review comment", "chat message")
 * @returns Improved version of the text
 */
export async function improveText(text: string, context?: string): Promise<string> {
  try {
    const { data } = await api.get<string | ImproveTextResponse>("/api/AIAssistant/improve-text", {
      params: {
        prompt: text,
        context,
      },
    });

    if (typeof data === "string") {
      return data.trim();
    }

    return data?.improvedText?.trim() ?? "";
  } catch (error) {
    console.error("Error improving text:", error);
    throw error;
  }
}

/**
 * Generates quick reply suggestions based on conversation context
 * @param prompt The conversation context or initial message
 * @param draftText Optional draft text being composed
 * @param count The number of suggestions to generate (default: 5, max: 10)
 * @returns Array of suggested quick replies
 */
export async function getQuickReplies(
  prompt?: string,
  draftText?: string,
  count = 5
): Promise<string[]> {
  try {
    const contextParts = [prompt, draftText]
      .filter((item) => typeof item === "string" && item.trim().length > 0);
    
    if (contextParts.length === 0) {
      return [];
    }

    const finalPrompt = contextParts.join(" ");

    const { data } = await api.get<string[] | string>("/api/AIAssistant/quick-replies", {
      params: {
        prompt: finalPrompt,
        count: Math.min(Math.max(count, 1), 10), // Ensure count is between 1 and 10
      },
    });

    if (!Array.isArray(data)) {
      return [];
    }

    return data.filter((item) => typeof item === "string" && item.trim().length > 0);
  } catch (error) {
    console.error("Error getting quick replies:", error);
    throw error;
  }
}
