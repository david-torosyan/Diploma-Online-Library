using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibraryAPI.Services;

public class AIAssistantHelper
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    private readonly string _model;

    public AIAssistantHelper(HttpClient httpClient, IOptions<AIAssistantOptions> options)
    {
        _httpClient = httpClient;
        _apiKey = options.Value.ApiKey;
        _model = options.Value.Model;
    }

    public async Task<BookWithDetailsDto> GenerateBookWithDetailsAsync(string request)
    {
        // 🧠 Construct a detailed prompt for the AI
        string prompt = $@"
        You are a helpful library assistant. Based on the following input, identify the most likely real book 
        and provide detailed metadata about it.
        
        Input: '{request}'
        
        Return ONLY a JSON object that matches this exact C# structure:
        
        {{
          ""id"": number (set to 0 if unknown),
          ""title"": string,
          ""isbn"": string (empty if unknown),
          ""pages"": number (set to 0 if unknown),
          ""publishedDate"": string (ISO 8601 format, e.g. 2020-05-14 or null),
          ""description"": string (short summary if possible, empty if unknown),
          ""authorId"": number (0 if unknown),
          ""authorFullName"": string (full name if known, otherwise empty),
          ""categoryId"": number (0 if unknown),
          ""categoryName"": string (category name or genre guess),
          ""bookURL"": string (see rules below),
          ""imageURL"": string (link to a valid book cover image or empty string)
        }}
        
        ⚠️ IMPORTANT RULES:
        - 'imageURL':
          • Must NOT be from 'https://upload.wikimedia.org/wikipedia/' or any Wikimedia domain.
          • If a reliable book cover exists online (e.g. Open Library, Google Books, or similar), use that direct image link.
          • The image URL must be publicly accessible (no logins or restrictions).
        
        - 'bookURL':
          • If a public, legal, and direct .pdf file of the book can be found online (for example, public domain, Google Books preview, or Open Library), return that PDF URL.
          • If no such free PDF is available, return a valid purchase or book information link (for example, Amazon, Google Books, or Goodreads).
        
        - Return only the JSON object — no markdown, no code fences, and no explanations.
        - Use empty strings or zeros for unknown values.
        ";

        string content = await GenerateContentAsync(prompt);

        try
        {
            // Handle any non-JSON text Gemini may include
            int jsonStart = content.IndexOf('{');
            int jsonEnd = content.LastIndexOf('}');
            if (jsonStart >= 0 && jsonEnd > jsonStart)
                content = content.Substring(jsonStart, jsonEnd - jsonStart + 1);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var dto = JsonSerializer.Deserialize<BookWithDetailsDto>(content, options);

            if (dto == null)
                return new BookWithDetailsDto { Title = "Unknown Book" };

            // 🧩 Validate or replace invalid ImageURL
            if (string.IsNullOrWhiteSpace(dto.ImageURL) ||
                !Uri.IsWellFormedUriString(dto.ImageURL, UriKind.Absolute) ||
                dto.ImageURL.Contains("wikipedia.org", StringComparison.OrdinalIgnoreCase))
            {
                dto.ImageURL = "https://via.placeholder.com/300x450?text=No+Cover+Available";
            }

            // 🧩 Validate or replace invalid BookURL
            if (string.IsNullOrWhiteSpace(dto.BookURL) ||
                !Uri.IsWellFormedUriString(dto.BookURL, UriKind.Absolute))
            {
                dto.BookURL = "https://www.amazon.com/s?k=" + Uri.EscapeDataString(dto.Title ?? "book");
            }

            // Leave Favorites and Reviews as null
            dto.Favorites = null;
            dto.Reviews = null;

            return dto;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Failed to deserialize BookWithDetailsDto: {ex.Message}");
            return new BookWithDetailsDto
            {
                Title = "Error parsing AI response",
                Description = ex.Message,
                ImageURL = "https://via.placeholder.com/300x450?text=Error",
                BookURL = "https://www.amazon.com/"
            };
        }
    }

    // https://aistudio.google.com/app/api-keys
    public async Task<string> GenerateContentAsync(string prompt)
    {
        if (string.IsNullOrWhiteSpace(prompt))
            throw new ArgumentException("Prompt cannot be empty.", nameof(prompt));

        var additionalPromt = "\nPlease keep your responses no more than 300 words.";
        var request = new GenerateContentRequest
        {
            Contents = new[]
            {
                new Content
                {
                    Parts = new[]
                    {
                        new Part { Text = prompt + additionalPromt }
                    }
                }
            }
        };


        var jsonBody = JsonSerializer.Serialize(request, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

        _httpClient.DefaultRequestHeaders.Clear();
        _httpClient.DefaultRequestHeaders.Add("x-goog-api-key", _apiKey);
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        string requestUri = $"https://generativelanguage.googleapis.com/v1beta/models/{_model}:generateContent";

        var response = await _httpClient.PostAsync(requestUri, content);

        var responseBody = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
            throw new HttpRequestException($"API request failed with status {response.StatusCode}: {responseBody}");

        var result = JsonDocument.Parse(responseBody);

        try
        {
            var text = result.RootElement
                             .GetProperty("candidates")[0]
                             .GetProperty("content")
                             .GetProperty("parts")[0]
                             .GetProperty("text")
                             .GetString();

            return text ?? "No text found in response.";
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException("Failed to parse AI response.", ex);
        }
    }

    #region DTOs

    private class GenerateContentRequest
    {
        [JsonPropertyName("contents")]
        public Content[] Contents { get; set; } = default!;
    }

    private class Content
    {
        [JsonPropertyName("parts")]
        public Part[] Parts { get; set; } = default!;
    }

    private class Part
    {
        [JsonPropertyName("text")]
        public string Text { get; set; } = default!;
    }

    #endregion
}
