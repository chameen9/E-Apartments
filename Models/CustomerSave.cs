using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Models
{
    public class CustomerSave
    {
        [Key]
        public Guid CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required, EmailAddress]
        public string CustomerEmail { get; set; }
        [Required]
        public string CustomerPhone { get; set; }
        [Required]
        public int CustomerAge { get; set; }
        [Required]
        public string CustomerAddress { get; set; }
        [Required]
        public string NICPassport { get; set; }

        //FK
        public Guid? LeasingId { get; set; }

        public Leasing Leasing { get; set; }
        //FK
        // Foreign Key Column
        //public Guid? UserId { get; set; }
        //public User User { get; set; }
        // Foreign Key Column
        public DateTime? CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
        [Required]
        public string ReferenceNumber { get; set; }

        public string Password { get; set; }

        //Set relation
        public ICollection<Dependent> Dependent { get; set; }
        public ICollection<Apartment> Apartment { get; set; }
        public ICollection<Reservation> Reservation { get; set; }
        public ICollection<AptApplication> AptApplication { get; set; }

    }
}
