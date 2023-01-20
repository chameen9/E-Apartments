using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Models
{
    public class Class
    {
        [Key]
        public string ClassId { get; set; }
        [Required]
        public string ClassName { get; set; }
        [Required]
        public double RefundableAmount { get; set; }
        [Required]
        public double NonRefundableReservationAmount { get; set; }
        [Required]
        public double MonthlyRate { get; set; }
        [Required]
        public int RoomsWithAttachedBathroomsCount { get; set; }
        [Required]
        public int CommonBathroomsCount { get; set; }
        [Required]
        public int CommonRoomsCount { get; set; }
        [Required]
        public int ServentBathroomsCount { get; set; }
        [Required]
        public int ServentRoomsCount { get; set; }
        [Required]
        public int MaxOccuepentsCount { get; set; }
        [Required]
        public double AdditionalParkingFee { get; set; }

        public ICollection<Apartment> Apartment { get; set; }
        public ICollection<Leasing> Leasing { get; set; }
        public ICollection<Reservation> Reservation { get; set; }
    }
}
