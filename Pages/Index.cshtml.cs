using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;
        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
            // Constructor logic can be added here if needed
        }

        public void OnGet()
        {
            ViewData["Greeting"] = _configuration["Greeting"];
        }
    }
}
