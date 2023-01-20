using E_Apartments.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Validators
{
    public class CustomerValidator : AbstractValidator<CustomerSave>
    {
        public CustomerValidator() 
        { 
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Please enter Customer Name.");
            RuleFor(x => x.CustomerAge).NotEmpty().WithMessage("Please enter Valid Age.").GreaterThanOrEqualTo(18).WithMessage("Age must greater than 18!").LessThanOrEqualTo(100).WithMessage("Age must less than 100!");
            RuleFor(x => x.CustomerEmail).EmailAddress().NotEmpty().WithMessage("Please enter proper Email Address");
            RuleFor(x => x.CustomerPhone).NotEmpty().WithMessage("Please enter Phone Number.");
            RuleFor(x => x.NICPassport).NotEmpty().Length(9, 12).WithMessage("Please enter a proper NIC / Passport Number.");
            RuleFor(x => x.CustomerAddress).Length(20, 350).NotEmpty();
        }
    }
}
