using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace SourceControlFinalAssignment.Models
{
    public class UserSignUp
    {

        [Required(AllowEmptyStrings=false, ErrorMessage = "First Name is Required")]
        [DisplayName("Enter Your First Name: ")]
        public string FirstName { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name is Required")]
        [DisplayName("Enter Your Last Name: ")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Email ID is Required")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(30)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public string Email { get; set; }

        [Required]
        [Phone]
        [StringLength(42)]
        public int PhoneNo { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        [RegularExpression("^((?=.?[A-Z])(?=.?[a-z])(?=.?[0-9])|(?=.?[A-Z])(?=.?[a-z])(?=.?[^a-zA-Z0-9])|(?=.?[A-Z])(?=.?[0-9])(?=.?[^a-zA-Z0-9])|(?=.?[a-z])(?=.?[0-9])(?=.?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters long")]
        [MinLength(8, ErrorMessage = "Minimum 8 characters are required")]
        [DisplayName("Enter Password : ")]
        public string Password { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage ="Confirm Password is required.")]
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password doesnot match")]

        public string ConfirmPassword { get; set; }
    }
}
