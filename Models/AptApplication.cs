using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Models
{
    public class AptApplication
    {
        [Key]
        public Guid AppID { get; set; }
        [Required]
        public string Status { get; set; }
        public Guid CustomerId { get; set; }
        public CustomerSave CustomerSave { get; set; }

        public string ApartmentId { get; set; }
        public Apartment Apartment { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ResrvedFrom { get; set; }

        public DateTime ResrvedTo { get; set; }
    }
}
