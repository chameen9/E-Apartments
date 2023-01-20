using E_Apartments.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Validators
{
    public class ClassValidator : AbstractValidator<Class>
    {
        public ClassValidator() 
        {
            RuleFor(x => x.ClassId).NotEmpty().WithMessage("Please enter Class ID.");
            RuleFor(x => x.ClassName).NotEmpty().WithMessage("Please enter Class Name.");
            RuleFor(x => x.RefundableAmount).GreaterThan(0).WithMessage("Please Enter Refundable Amount.");
            RuleFor(x => x.NonRefundableReservationAmount).GreaterThan(0).WithMessage("Please Enter Reservation Amount.");
            RuleFor(x => x.MonthlyRate).GreaterThan(0).WithMessage("Please Enter Monthly Installment Amount.");
            RuleFor(x => x.AdditionalParkingFee).GreaterThan(0).WithMessage("Please Enter Additional Parking Fee.");

            RuleFor(x => x.MaxOccuepentsCount).GreaterThan(0).WithMessage("Please Enter valid a Max Occupant Count.").LessThan(20).WithMessage("Please Enter valid a Max Occupant Count.");
            RuleFor(x => x.CommonRoomsCount).GreaterThan(0).WithMessage("At least 1 Common Room Should Included.");
            //RuleFor(x => x.ServentBathroomsCount).NotEmpty().WithMessage("Please Enter a Servant Bathrooms Count.");
            //RuleFor(x => x.ServentRoomsCount).NotEmpty().WithMessage("Please Enter a Servant Rooms Count.");
            //RuleFor(x => x.RoomsWithAttachedBathroomsCount).NotEmpty().WithMessage("Please Enter the Count for Rooms with Attached Bathrooms.");
            RuleFor(x => x.CommonBathroomsCount).GreaterThan(0).WithMessage("At least 1 Common Bathoom Should Included.");
        }
    }
}
