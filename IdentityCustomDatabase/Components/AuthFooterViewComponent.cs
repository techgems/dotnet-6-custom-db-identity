using Microsoft.AspNetCore.Mvc;

namespace CustomIdentity.Web.Components;

public class AuthFooterViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
