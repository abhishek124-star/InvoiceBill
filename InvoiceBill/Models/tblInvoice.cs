//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InvoiceBill.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tblInvoice
    {
       
        public int InvoiceId { get; set; }

        [Required(ErrorMessage = "Name is Requirded")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Desc is Requirde")]
        public string ProductDesc { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Display(Name = "Price")]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a valid positive number.")]
        public Nullable<int> Price { get; set; }
    }
}
