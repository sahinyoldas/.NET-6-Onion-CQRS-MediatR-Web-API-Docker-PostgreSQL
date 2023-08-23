using MediatR;
using OnionArchitecture.Application.Wrappers;
using OnionArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Commands.Vehicles
{
    public class UpdateVehicleCommandRequest : IRequest<Result>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
    }
}
