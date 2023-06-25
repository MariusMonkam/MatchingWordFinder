using System.ComponentModel.DataAnnotations;

namespace MatchingWordFinder
{
    public class SearchRequest
    {
        [Required]
        public string Paragraph { get; set; }
        [Required]
        public string SearchInput { get; set; }

    }
}
