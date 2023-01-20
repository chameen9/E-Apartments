using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Models
{
    public class BorrowedParking
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public CustomerSave CustomerId { get; set; }
        [Required]
        public Parking ParkingId { get; set; }
    }
}
