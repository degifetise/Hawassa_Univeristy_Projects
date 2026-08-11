using System.ComponentModel.DataAnnotations;
namespace Centralzed_Event_Platform.ViewModels
{

    public class LoginViewModel
    {
        [Required(ErrorMessage ="Email is required.")]
        [EmailAddress] 
        public string Email { get; set; }


        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}