using Microsoft.AspNetCore.Mvc;

namespace IdentityCustomDatabase.Components;

public class AuthFooterViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
