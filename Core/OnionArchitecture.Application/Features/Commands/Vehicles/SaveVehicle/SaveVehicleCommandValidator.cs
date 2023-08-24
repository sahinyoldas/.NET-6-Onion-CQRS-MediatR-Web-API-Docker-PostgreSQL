﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Commands.Vehicles.SaveVehicle
{
    public class SaveVehicleCommandValidator : AbstractValidator<SaveVehicleCommandRequest>
    {
        public SaveVehicleCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotNull().WithMessage("Name field is required")
                .MaximumLength(20).MinimumLength(3).WithMessage("'Name' value length should be between 3 and 20");

            RuleFor(p => p.Price)
                .Must(p => p > 0).WithMessage("'Price' should be greater than 0");
        }
    }
}
