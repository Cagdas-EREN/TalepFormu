using System.ComponentModel.DataAnnotations;

namespace MvcUI.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Kullanıcı Adını Giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage = "Parolanızı Giriniz")]
        public string password { get; set; }
    }
}
