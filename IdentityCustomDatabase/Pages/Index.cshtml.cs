using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomIdentity.Web.Pages;

public class IndexModel : PageModel
{
    public IActionResult OnGet()
    {
        if(User.Identity is not null && User.Identity.IsAuthenticated)
            return Redirect("/Dashboard/Index");

        return Page();
    }
}
