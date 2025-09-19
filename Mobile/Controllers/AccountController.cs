using Microsoft.AspNetCore.Mvc;
using TicketMobile.Data;
using System.Linq;

namespace TicketMobile.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == email && u.SenhaHash == senha && u.Ativo);

            if (usuario != null)
            {
                // salva sessão simples
                HttpContext.Session.SetString("UsuarioNome", usuario.Nome);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Erro = "Credenciais inválidas!";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
