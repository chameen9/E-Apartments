using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Models
{
    public class LeaseExtendRequest
    {
        [Key]
        public Guid RequestId { get; set; }
        public Guid LeasingId { get; set; }
        public Leasing Leasing { get; set; }
        public string Status { get; set; }
        public DateTime RequestedAt { get; set; }
        public DateTime? RequestedEndDate { get; set; }
    }
}
