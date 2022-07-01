using Microsoft.AspNetCore.Mvc;

namespace CustomIdentity.Web.Components;

public class AuthNavbarViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}

