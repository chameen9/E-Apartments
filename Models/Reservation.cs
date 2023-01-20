using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Models
{
    public class Reservation
    {
        [Key]
        public Guid ResvId { get; set; }
        [Required]
        public string Status { get; set; }
        public Guid CustomerId { get; set; }
        public CustomerSave CustomerSave { get; set; }

        public string ApartmentId { get; set; }
        public Apartment Apartment { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ResrvedFrom { get; set;}

        public DateTime ResrvedTo { get; set;}

        public double? AdditionalParkingFee { get; set; }
        public double? RefundableAmount { get; set; }
        public double? MonthlyRate { get; set; }
        public double? TotalAmount { get; set; }
        public double? PaidAmount { get; set; }
        public double? Balance { get; set; }

        public string ClassID { get; set; }
        public Class Class { get; set; }
    }
}
