using E_Apartments.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Validators
{
    internal class UserValidator : AbstractValidator<User>
    {
        public UserValidator() 
        {
            RuleFor(x => x.UserId).NotEmpty().WithMessage("Please enter the User ID"); // developer check
            RuleFor(x => x.Username).NotEmpty().WithMessage("Please enter the  Userame.");
            RuleFor(x => x.Email).EmailAddress().NotEmpty().WithMessage("Please enter proper Email Address");
            RuleFor(x => x.UserType).NotEqual("-select-").WithMessage("Please enter the User Type");
        }
    }
}
