using Microsoft.AspNetCore.Mvc;

namespace IdentityCustomDatabase.Components;

public class DashboardNavbarViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
