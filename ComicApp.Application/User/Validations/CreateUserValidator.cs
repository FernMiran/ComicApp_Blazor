using ComicApp.Application.User.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicApp.Application.User.Validations
{
    public class CreateUserValidator : AbstractValidator<CreateUser>
    {
        public CreateUserValidator()
        {
            RuleFor(x => x.Username)
                .NotEmpty()
                .Length(10, 50);

            RuleFor(x => x.Password)
                .NotEmpty()
                .Length(10, 100)
                .Must(IsPasswordValid)
                .WithMessage("Password is invalid because X reason.");
        }

        bool IsPasswordValid(string password)
        {
            return true;
        }
    }
}
