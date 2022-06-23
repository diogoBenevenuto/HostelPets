using Microsoft.AspNetCore.Mvc;

namespace HostelPets.View.Controllers
{
    public class SobreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
