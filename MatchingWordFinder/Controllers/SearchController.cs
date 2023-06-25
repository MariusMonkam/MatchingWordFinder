﻿using MatchingWordFinder.Models;
using Microsoft.AspNetCore.Mvc;

namespace MatchingWordFinder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {
        // Controller actions will be added here

        [HttpPost()]
        public IActionResult Search(SearchRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

        }
        string paragraph = request.Paragraph;
        string searchInput = request.SearchInput.ToLower();

        string[] words = paragraph.Split(new[] { ' ', '\t', '\r', '\n', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        
        List<MatchingWord> matchingWords = new List<MatchingWord>();



    }
}
