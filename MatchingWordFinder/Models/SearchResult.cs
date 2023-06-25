using MatchingWordFinder.Models;

namespace MatchingWordFinder
{
    public class SearchResult
    {
        public List<MatchingWord> MatchingWords { get; set; }
        public int Count { get; set; }
        public string HighlightedParagraph { get; set; }
    }
}
