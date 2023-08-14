using OnionArchitecture.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Dto
{
    public record VehicleDto : IDto
    {
        public string Name { get; init; }
        public int Year { get; init; }
        public double Price { get; init; }
    }
}
