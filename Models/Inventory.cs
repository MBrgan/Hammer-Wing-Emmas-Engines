﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace EmmaProject.Models
{
    public class Inventory
    {

        [Display(Name = "UPC")]
        [Required(ErrorMessage = "UPC must match the pattern '###-####-#'")]
        [RegularExpression("^[0-9]{3}-[0-9]{4}-[0 - 9]$", ErrorMessage = "The Postal Code in the format of 'M3A 1A5'")]
        public int UPC_ID { get; set; }
   

        [Display(Name = "Name")]
        [Required(ErrorMessage = "You cannot leave Inventory Name blank.")]
        [StringLength(50, ErrorMessage = "Inventory Name cannot be more than 50 characters long.")]
        public string InvName { get; set; }

        [Display(Name = "Size")]
        [Required(ErrorMessage = "You cannot leave Inventory Size blank")]
        [StringLength(50, ErrorMessage = "Inventory Name cannot be more than 50 characters long.")]
        public string InvSize { get; set; }
       

        [Display(Name = "Stock")]
        [Required(ErrorMessage = "You cannot leave Stock blank")]
        [StringLength(20, ErrorMessage = "Stock cannot be more than 20 characters long.")]
        public string InvQuantity { get; set; }

        [Display(Name = "Price Retail")]
        [Required(ErrorMessage = "You cannot leave Adjasted Price blank")]
        public decimal InvAdjustedPrice { get; set; }

        [Display(Name = "Markup")]
        [Required(ErrorMessage = "You cannot leave Markup blank")]
        public decimal InvMarkupPrice { get; set; }


        [Display(Name = "Current")]
        [Required(ErrorMessage = "Please enter either 'Y' (yes) or 'N'' (No) to indicate if an item is current or not")]
        [RegularExpression("^[YN]$", ErrorMessage = "Curent must be one charcter long 'Y' or 'N'")]
        public Char InvCurrent { get; set; }

        [Display(Name = "Order Request")]
        public ICollection<OrderRequestInventory> OrderRequestInventories { get; set; } = new HashSet<OrderRequestInventory>();

        [Display(Name = "Price")]
        public ICollection<Price> Prices { get; set; } = new HashSet<Price>();

        public InvoiceLine InvoiceLine { get; set; }

    }
}

