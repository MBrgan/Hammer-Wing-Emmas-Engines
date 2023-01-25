﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace EmmaProject.Models
{
    public class Supplier
    {
        public int SupID { get; set; }


        [Display(Name = "Supplier")]
        [Required(ErrorMessage = "You cannot leave the Supplier blank.")]
        [StringLength(80, ErrorMessage = "Supplier cannot be more than 80 characters long.")]
        public string SupName { get; set; }


        [Display(Name = "Phone")]
        public string PhoneFormatted
        {
            get
            {
                return "(" + SupPhone.Substring(0, 3) + ") " + SupPhone.Substring(3, 3) + "-" + SupPhone[6..];
            }
        }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression("^\\d{10}$", ErrorMessage = "Please enter a valid 10-digit phone number (no spaces).")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        public string SupPhone { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email Address is required.")]
        [StringLength(255)]
        [DataType(DataType.EmailAddress)]
        public string SupEmail { get; set; }


        [Display(Name = "Address")]
        [Required(ErrorMessage = "You cannot leave Supplier Address blank.")]
        [StringLength(100, ErrorMessage = "Supplier Address cannot be more than 100 characters long.")]
        public string SupAddress { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "You cannot leave the name of the city blank.")]
        [StringLength(50, ErrorMessage = "City name cannot be more than 50 characters long.")]
        public string SupCity { get; set; }

        [Display(Name = "Province")]
        [Required(ErrorMessage = "You cannot leave the name of the province blank.")]
        [StringLength(2, ErrorMessage = "Province name can only be 2 characters long.")]
        public string SupProvince { get; set; }

        [Display(Name = "Postal Code")]
        [Required(ErrorMessage = "You cannot leave the Postal Code blank.")]
        [RegularExpression("^[ABCEGHJ-NPRSTVXY]{1}[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[ ]?[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[0-9]{1}$", ErrorMessage = "The Postal Code in the format of 'M3A 1A5'")]
        public string SupPostal { get; set; }

        [Display(Name = "Price")]
        public ICollection<Price> Prices { get; set; } = new HashSet<Price>();

    }
}