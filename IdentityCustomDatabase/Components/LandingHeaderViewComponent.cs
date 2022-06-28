using Microsoft.AspNetCore.Mvc;

namespace IdentityCustomDatabase.Components;

public class LandingHeaderViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}