using Microsoft.AspNetCore.Mvc;

namespace CustomIdentity.Web.Components;

public class DashboardNavbarViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
