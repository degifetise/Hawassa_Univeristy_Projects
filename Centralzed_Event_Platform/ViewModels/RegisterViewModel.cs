using System.ComponentModel.DataAnnotations;

namespace Centralzed_Event_Platform.ViewModels
{
    public class RegisterViewModel {

        [Required(ErrorMessage = "Full Name is Required.")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = string.Empty;


        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; } = string.Empty;



        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; } = string.Empty;

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "Student ID is required.")]
        [Display(Name = "Student ID")]
        public string StudentId { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select your stream/field.")]
        public string Field { get; set; } = string.Empty;

        [Required(ErrorMessage = "Department selection is required.")]
        public int DepartmentId { get; set; }

        public string Campus { get; set; } = "Main Campus";
        public int Year { get; set; } = 1;
        public int GraduationYear { get; set; } = DateTime.Now.Year + 4;
    }

}