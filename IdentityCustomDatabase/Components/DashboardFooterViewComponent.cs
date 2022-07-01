using Microsoft.AspNetCore.Mvc;

namespace CustomIdentity.Web.Components;

public class DashboardFooterViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
