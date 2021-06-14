using System.ComponentModel.DataAnnotations;

namespace curso.api.Models.Usuario
{
    public class RegistroViewModelInput
    {
        [Required(ErrorMessage = "O Login é obrigatório")]
        public string Login { get; set; }
        [EmailAddress(ErrorMessage = "Deve-se informar um E-mail válido")]
        [Required(ErrorMessage = "O E-mail é obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage = "A Senha é obrigatória")]
        public string Senha { get; set; }
    }
}