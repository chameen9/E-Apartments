using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Models
{
    public class Dependent
    {
        [Key]
        public Guid DependentId { get; set; }
        [Required]
        public string DependentName { get; set; }
        [Required]
        public string Relationship { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]

        //Foreign key
        public Guid? CustomerId { get; set; }
        
    }
}
