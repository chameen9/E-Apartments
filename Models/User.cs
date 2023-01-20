using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Models
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string UserType { get; set; }

        // Set the Relation with Customer Model
        //public ICollection<CustomerSave> CustomerSave { get; set; }
    }
}
