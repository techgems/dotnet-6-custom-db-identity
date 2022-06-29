using Microsoft.AspNetCore.Mvc;

namespace IdentityCustomDatabase.Components;

public class DashboardFooterViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
