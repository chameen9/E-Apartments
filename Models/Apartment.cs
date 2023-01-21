using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Models
{
    public class Apartment
    {
        [Key]
        public string ApartmentId { get; set; }
        [Required]
        public int FloorNumber { get; set; }

        //FK
        public string BuildingId { get; set; }
        public Building Building { get; set; }
        //FK

        // Foreign Key Column
        public Guid? CustomerId { get; set; } // if customer id != null it was taken
        public CustomerSave CustomerSave { get; set; }
        // Foreign Key Column


        // Foreign Key Column
        public string ParkingId { get; set; }
        public Parking Parking { get; set; }
        // Foreign Key Column

        // Foreign Key Column
        public int? AddParkingId { get; set; }
        public AdditionalParking AdditionalParking { get; set; }
        // Foreign Key Column

        //FK
        public string ClassId { get; set; }
        public Class Class { get; set; }
        //FK

        public DateTime? DeletedAt { get; set; }

        public ICollection<Reservation> Reservation { get; set; }
        public ICollection<AptApplication> AptApplication { get; set; }
    }
}
