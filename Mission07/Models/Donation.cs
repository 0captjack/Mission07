using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission07.Models
{
    public class Donation
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }

        [BindNever]
        public ICollection<CartLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter a name:")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter an address:")]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }
        [Required(ErrorMessage = "Please enter a name:")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a city:")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter a state:")]
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please enter a country:")]
        public string Country { get; set; }

        public bool EmailReceipt { get; set; }
        [BindNever]
        public bool DonationReceived { get; set; }
    }
}
