using System;

namespace TicketMobile.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public required string Nome { get; set; }      // obrigatório
        public required string Email { get; set; }     
        public required string Perfil { get; set; }
        public bool Ativo { get; set; }
        public required string Telefone { get; set; }
        public required string Departamento { get; set; }
        public string? Observacoes { get; set; }       // nullable
        public DateTime DataCriacao { get; set; }
        public DateTime? UltimoLogin { get; set; }     // nullable
        public required string SenhaHash { get; set; }
    }
}
