using Microsoft.AspNetCore.Mvc;

namespace HostelPets.View.Controllers
{
    public class ServiçosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
