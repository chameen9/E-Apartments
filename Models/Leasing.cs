using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Models
{
    public class Leasing
    {
        [Key]
        public Guid LeasingId { get; set; }
        [Required]
        public string ApartmentID{ get; set; }
        [Required]
        public DateTime StartedDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public double? AdditionalParkingFee { get; set; }
        public double RefundableAmount { get; set; }
        public double MonthlyRate { get; set; }
        public double TotalAmount { get; set; }
        public double PaidAmount { get; set; }
        public double Balance { get; set; }

        public string ClassID { get; set; }
        public Class Class { get; set; }

        public ICollection<CustomerSave> CustomerSave { get; set; }
        public ICollection<LeaseExtendRequest> LeaseExtendRequest { get; set; }
    }
}
