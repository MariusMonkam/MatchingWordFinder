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
            // Method implementation will be added in the next steps
        }

    }
}
