using System;
using System.ComponentModel.DataAnnotations;
namespace Yelp.Models
{
        // Internal field to hold the received date value.
    
    public class UserViewModel : BaseEntity
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-mail Address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Your passwords do not match")]
        [Display(Name = "Confirm Password")]
        public string PasswordConfirm { get; set; }
        
        public int balance { get; set; }
        public DateTime CreatedAt  { get; set; }
        public DateTime UpdatedAt  { get; set; }
    }
    public class LoginViewModel{
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class UserReviewModel : BaseEntity
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "First Name")]
        public string First_name { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Last Name")]
        public string Last_name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-mail Address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password), ErrorMessage = "Your passwords do not match")]
        [Display(Name = "Confirm Password")]
        public string Password_confirm { get; set; }
        
        public int balance { get; set; }
    }
}