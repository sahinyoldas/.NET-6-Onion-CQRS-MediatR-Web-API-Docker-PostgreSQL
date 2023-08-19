using MediatR;
using OnionArchitecture.Application.Wrappers;
using OnionArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Commands.Vehicles.SaveVehicle
{
    public class SavehicleCommandRequest : IRequest<DataResult<Vehicle>>
    {
        public string Name { get; init; }
        public int Year { get; init; }
        public double Price { get; init; }
    }
}
