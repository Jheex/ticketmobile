using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tickets.Models;

namespace Tickets.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Tela inicial (Dashboard)
        public IActionResult Index()
        {
            // Dados simulados de tickets
            var tickets = new List<Ticket>
            {
                new Ticket { Id = 1, Titulo = "Erro no login", Status = "Aberto", DataCriacao = DateTime.Now.AddDays(-2), Descricao = "Não consigo logar." },
                new Ticket { Id = 2, Titulo = "Atualização de dados", Status = "Fechado", DataCriacao = DateTime.Now.AddDays(-5), Descricao = "Atualizei meu endereço." },
                new Ticket { Id = 3, Titulo = "Solicitação de suporte", Status = "Pendente", DataCriacao = DateTime.Now.AddDays(-1), Descricao = "Preciso de ajuda no sistema." },
                new Ticket { Id = 4, Titulo = "Problema no app", Status = "Aberto", DataCriacao = DateTime.Now.AddDays(-3), Descricao = "O app fecha sozinho." }
            };

            // Métricas para os cards do dashboard
            ViewBag.TicketsAbertos = tickets.Count(t => t.Status == "Aberto");
            ViewBag.TicketsFechados = tickets.Count(t => t.Status == "Fechado");
            ViewBag.TicketsPendentes = tickets.Count(t => t.Status == "Pendente");
            ViewBag.TotalTickets = tickets.Count;

            // Passa a lista de tickets para a View
            return View(tickets);
        }

        // Tela de privacidade (opcional)
        public IActionResult Privacy()
        {
            return View();
        }

        // Tela de erro
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
