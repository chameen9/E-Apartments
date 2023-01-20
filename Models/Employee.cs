using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Models
{
    public class Employee
    {
        [Key]
        public Guid EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string JobRole { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        //public Guid UserId { get; set; }
        public User UserId { get; set; }

    }
}
