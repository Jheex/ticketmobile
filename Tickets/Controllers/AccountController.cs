using Microsoft.AspNetCore.Mvc;
using Tickets.Models;

namespace Tickets.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Simulação de login (email e senha fixos)
            if (model.Email == "cliente@exemplo.com" && model.Password == "1234")
            {
                // Aqui normalmente você faria autenticação real
                TempData["Message"] = "Login realizado com sucesso!";
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError(string.Empty, "Email ou senha inválidos");
            return View(model);
        }
    }
}
