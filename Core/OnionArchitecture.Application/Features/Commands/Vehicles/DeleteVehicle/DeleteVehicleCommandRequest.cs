using MediatR;
using OnionArchitecture.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Commands.Vehicles
{
    public class DeleteVehicleCommandRequest :IRequest<Result>
    {
        public long Id { get; set; }
    }
}
