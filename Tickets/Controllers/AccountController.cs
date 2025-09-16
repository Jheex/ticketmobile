using Microsoft.AspNetCore.Mvc;
using tickets.Data;
using tickets.ViewModels;

namespace tickets.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var user = FakeUserStore.ValidateUser(model.Email, model.Password);
            if (user != null)
            {
                // Para teste, armazenamos o usuário no TempData (não seguro)
                TempData["User"] = user.FullName;
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Email ou senha inválidos");
            return View(model);
        }

        [HttpPost]
        public IActionResult Logout()
        {
            TempData.Remove("User");
            return RedirectToAction("Login");
        }
    }
}
