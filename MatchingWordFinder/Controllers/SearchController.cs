using Microsoft.AspNetCore.Mvc;
using MatchingWordFinder.Models;
using System.Text.RegularExpressions;

namespace MatchingWordFinder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {
        [HttpPost()]
        public IActionResult Search(SearchRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            string paragraph = request.Paragraph;
            string searchInput = request.SearchInput.ToLower();

            // Split the paragraph into words using white spacing, common punctuation as delimiter
            string[] words = paragraph.Split(new[] { ' ', '\t', '\r', '\n', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            // Find the position and count of the matching words
            List<MatchingWord> matchingWords = new List<MatchingWord>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].ToLower() == searchInput)
                {
                    matchingWords.Add(new MatchingWord
                    {
                        Word = words[i],
                        Position = i
                    });
                }
            }

            if (matchingWords.Count > 0)
            {
                // Highlight the matching words in the paragraph
                string highlightedParagraph = HighlightMatchingWords(paragraph, matchingWords.Select(mw => mw.Word));

                return Ok(new SearchResult
                {
                    MatchingWords = matchingWords,
                    Count = matchingWords.Count,
                    HighlightedParagraph = highlightedParagraph
                });
            }
            else
            {
                return NotFound("No matching word");
            }
        }

        private string HighlightMatchingWords(string paragraph, IEnumerable<string> matchingWords)
        {
            // Use HTML tags to highlight the matching words
            foreach (string word in matchingWords)
            {
                paragraph = Regex.Replace(paragraph, $"\\b{Regex.Escape(word)}\\b", $"<strong>{word}</strong>", RegexOptions.IgnoreCase);
            }

            return paragraph;
        }
    }
}