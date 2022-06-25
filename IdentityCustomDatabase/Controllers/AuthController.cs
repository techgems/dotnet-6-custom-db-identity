using Microsoft.AspNetCore.Mvc;

namespace IdentityCustomDatabase.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
