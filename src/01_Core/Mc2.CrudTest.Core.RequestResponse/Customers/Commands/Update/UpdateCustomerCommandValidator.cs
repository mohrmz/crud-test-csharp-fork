﻿using FluentValidation;
using Mc2.CrudTest.Core.Domain.Customers.Specifications;

namespace Mc2.CrudTest.Core.RequestResponse.Customers.Commands.Update;

public class UpdateCustomerCommandValidator : AbstractValidator<UpdateCustomerCommand>
{
    public UpdateCustomerCommandValidator()
    {
        var bankAccountValidator = new ValidBankAccountNumberSpecification();
        var phoneNumberValidator = new ValidLibphoneNumberSpecifications();

        RuleFor(c => c.FirstName)
       .NotNull()
       .WithMessage("FirstName is required");

        RuleFor(c => c.LastName)
       .NotNull()
       .WithMessage("LastName is required");

        RuleFor(c => c.DateOfBirth)
       .NotNull()
       .WithMessage("DateOfBirth is required");

        RuleFor(c => c.PhoneNumber)
       .NotNull()
       .WithMessage("PhoneNumber is required")
       .Must(value => phoneNumberValidator.IsSatisfiedBy(value))
       .WithMessage("PhoneNumber is not valid");

        RuleFor(c => c.Email)
        .NotNull()
        .WithMessage("Email is required")
        .EmailAddress()
        .WithMessage("Invalid email format");

        RuleFor(c => c.BankAccountNumber)
       .NotNull()
       .WithMessage("BankAccountNumber is required")
       .Must(value => bankAccountValidator.IsSatisfiedBy(value))
       .WithMessage("BankAccountNumber is not valid");
    }
}
