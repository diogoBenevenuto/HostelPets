using Microsoft.AspNetCore.Mvc;

namespace HostelPets.View.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
