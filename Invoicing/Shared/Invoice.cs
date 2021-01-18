using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Shared
{
    public class Invoice
    {
        public Invoice(string reference, string customer, decimal amount, DateTime created, DateTime expected) 
        {
            Reference = reference;
            Customer = customer;
            Amount = amount;
            Created = created;
            Expected = expected;
        }
        public Invoice()
        {

        }
        public int? id { get; set; }
        [Required(ErrorMessage = "Reférence obligatoire")]
        [MinLength(5, ErrorMessage = "Une référence doit contenir 5 caractères")]
        public string Reference { get; set; }
        public string Customer { get; set; }
        public decimal Amount { get; set; }
        public decimal Paid { get; set; }
        public DateTime Created { get; set; }
        public DateTime Expected { get; set; }
        public DateTime? LastPayment { get; private set; } = null;

        public bool IsPaid => Paid == Amount;
        public bool IsLate => Expected < DateTime.Now;

        public void RegisterPayment(DateTime when, decimal howMany)
        {
            if(when < Created)
            {
                throw new ArgumentOutOfRangeException("Cannot pay before the invoice creation");
            }
            LastPayment = when;
            if(Amount-Paid < howMany)
            {
                throw new ArgumentOutOfRangeException("Cannot pay over the due amount");
            }
            Paid += howMany;
        }
    }
}
