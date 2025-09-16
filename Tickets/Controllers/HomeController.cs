using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using tickets.Models;

namespace tickets.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Dados simulados de tickets
            var tickets = new List<Ticket>
            {
                new Ticket { Id = 1, Titulo="Erro no login", Status="Aberto", DataCriacao=DateTime.Now.AddDays(-2), Descricao="Não consigo logar." },
                new Ticket { Id = 2, Titulo="Atualização de dados", Status="Fechado", DataCriacao=DateTime.Now.AddDays(-5), Descricao="Atualizei meu endereço." },
                new Ticket { Id = 3, Titulo="Solicitação de suporte", Status="Pendente", DataCriacao=DateTime.Now.AddDays(-1), Descricao="Preciso de ajuda no sistema." },
                new Ticket { Id = 4, Titulo="Problema no app", Status="Aberto", DataCriacao=DateTime.Now.AddDays(-3), Descricao="O app fecha sozinho." }
            };

            // Passando métricas para os cards
            ViewBag.TicketsAbertos = tickets.Count(t => t.Status == "Aberto");
            ViewBag.TicketsFechados = tickets.Count(t => t.Status == "Fechado");
            ViewBag.TicketsPendentes = tickets.Count(t => t.Status == "Pendente");
            ViewBag.TotalTickets = tickets.Count;

            return View(tickets);
        }
    }
}
