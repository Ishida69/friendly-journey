using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReeTail.Models
{
    public class ItemSearch
    {

        [DisplayName("Item Name")]
        [Display(Prompt = "Enter item name...")]
        [DataType(DataType.Text)]
        [MinLength(2), MaxLength(30)]
        public string SearchItemName { get; set; }

        [DisplayName("Filter")]
        [Display(Prompt = "Search by filter...")]
        [DataType(DataType.Text)]
        [MinLength(2), MaxLength(30)]
        public string SearchFilter { get; set; }

        [DisplayName("Item Information")]
        [DataType(DataType.Text)]   
        [MinLength(10), MaxLength(100)]
        public string SearchItemInformation { get; set; }   

        [DisplayName("Item Availability")]
        [DataType(DataType.Text)]
        public string SearchItemAvailability { get; set; }

        public ICollection<Items> AllItems { get; set; }

    }
}