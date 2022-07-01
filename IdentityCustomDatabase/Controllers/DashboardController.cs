using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CustomIdentity.Web.Controllers;

[Authorize]
public class DashboardController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}
