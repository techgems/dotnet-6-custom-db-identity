using Microsoft.AspNetCore.Mvc;

namespace IdentityCustomDatabase.Components;
public class LandingFooterViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
