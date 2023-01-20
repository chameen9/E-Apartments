using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Models
{
    public class CustomerLeasings
    {
        [Key]
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }
        public CustomerSave CustomerSave { get; set; }

        public Guid LeasingId { get; set; }
        public Leasing Leasing { get; set; }
    }
}
