using Microsoft.AspNetCore.Mvc;

namespace LayersArchitecture.Core.Areas.Admin.Controllers
{
	[Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
