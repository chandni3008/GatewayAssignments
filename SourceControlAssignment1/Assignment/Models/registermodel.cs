using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Assignment.Models
{
    public class registermodel
    {
        
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        
        [Required(ErrorMessage = "Name is Required")]
        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name  have maximum length of 50 and minimum length of 3 ")]
        public string Name { get; set; }

        
        [Required(ErrorMessage = "Age is Required")]
        [Display(Name = "Age")]
        [Range(18, 40, ErrorMessage = "Age must be between 18 to 90 yrs")]
        public int Age { get; set; }


        
        [Required(ErrorMessage = "Email is Required")]
        [Display(Name = "Email ID")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
       
        public string Email { get; set; }

       
        [Required(ErrorMessage = "PhoneNo is Required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})[-. ]?([0-9]{4})[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Not a valid Phone number")]
        public int PhoneNo { get; set; }


        // Address Validation
        [Required(ErrorMessage = "Address is Required")]
        [Display(Name = "Address")]
        [MinLength(10, ErrorMessage = "Please specify the full Address")]
        public string Address { get; set; }

        [Display(Name = "website link")]
        [Url]
        [Required]
        public string GitHubLink { get; set; }


        [Required]
        [Display(Name = "Credit Card Details")]
        [DataType(DataType.CreditCard)]
        public int CreditCard { get; set; }


        [Required(ErrorMessage = "Password is Required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain lower case ,upper case and an special charcter)")]
        public string Password { get; set; }

   
        [Required(ErrorMessage = "ConfirmPassword is Required")]
        [Display(Name = "Confirm Password ")]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        public string ConfirmPassword { get; set; }


    }
}