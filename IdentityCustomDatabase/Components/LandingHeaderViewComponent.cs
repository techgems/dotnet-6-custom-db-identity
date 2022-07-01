using Microsoft.AspNetCore.Mvc;

namespace CustomIdentity.Web.Components;

public class LandingHeaderViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}