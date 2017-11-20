using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReeTail.Models
{
    public class UserAccount
    {

        [DisplayName("Username")]
        [Display(Prompt = "Enter username")]
        [MinLength(1), MaxLength(30)]
        [RegularExpression(@"[a-zA-Z\s]*$")]
        public string Username { get; set; }

        [DisplayName("Password")]
        [Display(Prompt = "Enter password")]
        [MinLength(1), MaxLength(30)]
        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email addresss is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }

        [DisplayName("Postcode")]
        [Display(Prompt = "Enter postcode")]
        [MinLength(3), MaxLength(8)]
        [DataType(DataType.PostalCode)]
        public string Postcode { get; set; }

        [DisplayName("Mobile Number")]
        [Display(Prompt = "Enter your mobile number")]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(15)]
        public string MobileNum { get; set; }

        [DisplayName("Profile Picture")]
        [Display(Prompt = "Choose a profile picture (optional)")]
        [DataType(DataType.ImageUrl)]
        public string ProfileImg { get; set; }

        public ICollection<Items> UserItems { get; set; }
    }


}
