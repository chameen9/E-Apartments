using E_Apartments.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Validators
{
    public class BuildingValidator : AbstractValidator<Building>
    {
        public BuildingValidator() 
        {
            RuleFor(x => x.BuildingId).NotEmpty().WithMessage("Please enter a Building ID.");
            RuleFor(x => x.BuildingName).NotEmpty().WithMessage("Please enter a Building Name.");
            RuleFor(x => x.Location).NotEmpty().WithMessage("Please enter the Location.");

            RuleFor(x => x.ApartmentsCount).GreaterThanOrEqualTo(1).WithMessage("At Least 1 Apartment Should Include in the Building");
            RuleFor(x => x.ParkingsCount).GreaterThanOrEqualTo(1).WithMessage("At Least 1 Normal Parking Should Include in the Building");
            RuleFor(x => x.FLoorCount).GreaterThanOrEqualTo(1).WithMessage("At Least 1 Floor Should Include in the Building");
            RuleFor(x => x.AdditionalParkingsCount).GreaterThanOrEqualTo(0).WithMessage("Additional Parkings should not be minus");
        }
    }
}
