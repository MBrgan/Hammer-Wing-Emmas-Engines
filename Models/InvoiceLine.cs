﻿using System.ComponentModel.DataAnnotations;

namespace EmmaProject.Models
{
    public class InvoiceLine
    {
        [Display(Name = "Invoice")]
        [Required(ErrorMessage = "You cannot leave Invoice blank")]
        public int InvoiceID { get; set; }
        public Invoice Invoice { get; set; }

        [Display(Name = "UPC")]
        [Required(ErrorMessage = "UPC can't be left blank")]
        [RegularExpression("^[0-9]{3}-[0-9]{4}-[0-9]$", ErrorMessage = "The UPC Code should be in the format '###-####-#'")]
        public string UPC_ID { get; set; }
        public Inventory Inventory { get; set; }


        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "Quantity is requied")]
        public int OtQuantity { get; set; }

        [Display(Name = "Sale Price")]
        [Required(ErrorMessage = "Sale Price is requied")]
        public decimal OtSalePrice { get; set; }
    }
}
