using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace Nightmare.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        [Required]
        [DisplayName("Item Name")]
        [DataType(DataType.Text)]
        public string ItemName { get; set; }
        [Required]
        [DisplayName("Item Image")]
        [DataType(DataType.ImageUrl)]
        public byte[] ItemImg { get; set; }
        [Required]
        [DisplayName("Item Description")]
        [DataType(DataType.MultilineText)]
        public string ItemDescription { get; set; }
        public ApplicationUser ItemSeller { get; set; }
        [Required]
        [DisplayName("Item Condition")]
        public string ItemCondition { get; set; }
        [Required]
        [DisplayName("Item Status")]
        public string ItemStatus { get; set; }
    }
}
