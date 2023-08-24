using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Commands.Vehicles.UpdateVehicle
{
    public class UpdateVehicleCommandValidator : AbstractValidator<UpdateVehicleCommandRequest>
    {
        public UpdateVehicleCommandValidator()
        {
            RuleFor(p => p.Id).Must(p => p > 0).WithMessage("'Id' must be greater than 0");

            RuleFor(p => p.Name)
                .NotNull().WithMessage("Name field is required")
                .MaximumLength(20).MinimumLength(3).WithMessage("'Name' value length should be between 3 and 20");

            RuleFor(p => p.Price)
                .Must(p => p > 0).WithMessage("'Price' should be greater than 0");
        }
    }
}

