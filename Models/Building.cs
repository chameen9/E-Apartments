using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Models
{
    public class Building
    {
        [Key]
        public string BuildingId { get; set; }
        [Required]
        public string BuildingName { get; set; }
        [Required]
        public string Location { get; set; }
        public int ApartmentsCount { get; set; }
        public int ParkingsCount { get; set; }
        public int AdditionalParkingsCount { get; set; }

        public int FLoorCount { get; set; }

        public ICollection<Parking> Parking { get; set; }
        public ICollection<AdditionalParking> AdditionalParking { get; set; }
        public ICollection<Apartment> Apartment { get; set; }
    }
}
