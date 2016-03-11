﻿namespace PersonLibrary.Core.Validation.Interface
{
    using FluentValidation;
    using PersonLibrary.Core.Interface;

    public class SingleAddressPersonInterfaceValidator : AbstractValidator<ISingleAddressPerson>
    {
        public SingleAddressPersonInterfaceValidator()
        {
            this.RuleFor(person => person.Address).NotNull();
        }
    }
}