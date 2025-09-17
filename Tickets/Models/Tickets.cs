namespace Tickets.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; } // "Aberto", "Fechado", "Pendente"
        public DateTime DataCriacao { get; set; }
    }
}
