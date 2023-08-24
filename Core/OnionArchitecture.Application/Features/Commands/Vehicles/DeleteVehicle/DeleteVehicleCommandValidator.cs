using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Commands.Vehicles.DeleteVehicle
{
    public class DeleteVehicleCommandValidator : AbstractValidator<DeleteVehicleCommandRequest>
    {
        public DeleteVehicleCommandValidator()
        {
            RuleFor(p => p.Id).Must(p => p > 0).WithMessage("'Id' must be greater than 0");
        }
    }
}
