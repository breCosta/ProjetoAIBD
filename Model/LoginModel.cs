using System.ComponentModel.DataAnnotations;

namespace ProjetoBD.Model
{
    public class LoginModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
