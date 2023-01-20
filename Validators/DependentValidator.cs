using E_Apartments.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Validators
{
    public class DependentValidator : AbstractValidator<Dependent>
    {
        public DependentValidator() 
        {
            RuleFor(x => x.DependentName).NotEmpty().WithMessage("Please enter Dependent Name.");
            RuleFor(x => x.Relationship).NotEqual("(Relation)").WithMessage("Please select a Relation");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Please enter Valid Age.").GreaterThanOrEqualTo(1).WithMessage("Age must greater than 1!").LessThanOrEqualTo(100).WithMessage("Age must less than 100!");
        }
    }
}
