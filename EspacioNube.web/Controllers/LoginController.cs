using Microsoft.AspNetCore.Mvc;

namespace EspacioNube.web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
