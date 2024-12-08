using System.ComponentModel.DataAnnotations;

namespace Portfolio.Admin.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "E-posta adresini giriniz.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifreyi giriniz.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
