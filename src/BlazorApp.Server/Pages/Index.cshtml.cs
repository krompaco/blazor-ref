using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazorApp.Server.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            this.ViewData["Title"] = "BlazorApp.Server";
        }
    }
}
