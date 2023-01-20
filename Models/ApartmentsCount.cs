using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Models
{
    public class ApartmentsCount
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Building BuildingId { get; set; }
        [Required]
        public int Class1Count { get; set; }
        [Required]
        public int Class2Count { get; set; }
        [Required]
        public int Class3Count { get; set; }
    }
}
