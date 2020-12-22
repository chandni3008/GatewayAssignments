using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SourceControlFinalAssignment.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }


        [Required]
        public string LastName { get; set; }



        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [StringLength(42)]
        [Phone]
         public int PhoneNo { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
