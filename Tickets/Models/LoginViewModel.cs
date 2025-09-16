using System.ComponentModel.DataAnnotations;

namespace tickets.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Digite o usuário")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite a senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
