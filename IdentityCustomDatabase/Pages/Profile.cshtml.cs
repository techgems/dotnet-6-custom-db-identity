using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomIdentity.Web.Pages;

[Authorize]
public class ProfileModel : PageModel
{
    public void OnGet()
    {
    }
}
