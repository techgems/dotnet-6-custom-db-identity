using Microsoft.AspNetCore.Mvc;

namespace CustomIdentity.Web.Components;

public class DashboardSidebarViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
