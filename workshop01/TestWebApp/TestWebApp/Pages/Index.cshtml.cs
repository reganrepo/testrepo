using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public string txt { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        public void OnGet()
        {
            // Dynamic texts
            string[] txts = { "Logic will get you from A to B. Imagination will take you everywhere.", "There are 10 kinds of people. Those who know binary and those who don't.", "There are two ways of constructing a software design. One way is to make it so simple that there are obviously no deficiencies and the other is to make it so complicated that there are no obvious deficiencies.", "It's not that I'm so smart, it's just that I stay with problems longer.",
 "It is pitch dark. You are likely to be eaten by a grue." };

            // Create a Random object
            Random rand = new Random();

            // Generate a random index less than the size of the array.
            int index = rand.Next(txts.Length);

            // Display the result.
            txt = txts[index];
        }
    }
}