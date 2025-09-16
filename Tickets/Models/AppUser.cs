namespace tickets.Models
{
    public class AppUser
    {
        public string Email { get; set; }
        public string Password { get; set; } // Para teste apenas, sem criptografia
        public string FullName { get; set; }
    }
}
