using MediatR;
using OnionArchitecture.Application.Dto;
using OnionArchitecture.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Queries.Vehicles
{
    public class GetVehicleByIdQueryRequest : IRequest<DataResult<VehicleDto>>
    {
        public long Id { get; set; }

        public GetVehicleByIdQueryRequest(long id)
        {
            Id = id;
        }
    }
}
