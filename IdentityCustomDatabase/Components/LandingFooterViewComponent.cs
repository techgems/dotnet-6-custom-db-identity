using Microsoft.AspNetCore.Mvc;

namespace CustomIdentity.Web.Components;
public class LandingFooterViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
