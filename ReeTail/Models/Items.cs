using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReeTail.Models
{
    public class Items
    {
        [DisplayName("Item Image")]
        [Display(Prompt = "Choose an item image")]
        [DataType(DataType.ImageUrl)]
        public string ItemImg { get; set; }

        [DisplayName("Item Title")]
        [Display(Prompt = "Enter an item title...")]
        [DataType(DataType.Text)]
        [MinLength(2), MaxLength(30)]
        public string ItemTitle { get; set; }

        [DisplayName("Item Description")]
        [Display(Prompt = "Enter an item description...")]
        [DataType(DataType.Text)]
        [MinLength(10), MaxLength(100)]
        public string ItemDescription { get; set; }

        [DisplayName("Price")]
        [Display(Prompt = "Enter an item price...")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [DisplayName("Condition")]
        [Display(Prompt = "What condition is the item in?")]
        [DataType(DataType.Text)]
        public string ItemCondition { get; set; }

        [DisplayName("Category")]
        [Display(Prompt = "What categories does this item come under?")]
        [DataType(DataType.Text)]
        public string Category { get; set; }

        public UserAccount ItemOwnerAccont { get; set; }

    }
}
