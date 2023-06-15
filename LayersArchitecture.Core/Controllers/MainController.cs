using Microsoft.AspNetCore.Mvc;

namespace LayersArchitecture.Core.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
