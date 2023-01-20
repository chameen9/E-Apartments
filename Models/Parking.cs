using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Models
{
    public class Parking
    {
        [Key]
        public string ParkingId { get; set; }
        [Required]
        public string Status { get; set; }

        // FK
        public string BuildingId { get; set; }
        public Building Building { get; set; }
        // FK

        //set relation
        public ICollection<Apartment> Apartment { get; set; }
    }
}
