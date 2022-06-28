using Microsoft.AspNetCore.Mvc;

namespace IdentityCustomDatabase.Components.ViewComponents;

public class AuthNavbarViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}

