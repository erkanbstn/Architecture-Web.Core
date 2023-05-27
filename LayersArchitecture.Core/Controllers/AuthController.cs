using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace LayersArchitecture.Core.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(int id)
        {
            return View();
        }
        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Main");
        }
    }
}
