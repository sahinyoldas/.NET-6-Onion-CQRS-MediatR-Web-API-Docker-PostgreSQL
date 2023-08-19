using AutoMapper;
using MediatR;
using OnionArchitecture.Application.Dto;
using OnionArchitecture.Application.Interfaces.Repository;
using OnionArchitecture.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Queries.Vehicles
{
    public class GetVehicleByIdQueryHandler : IRequestHandler<GetVehicleByIdQueryRequest, DataResult<VehicleDto>>
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMapper _mapper;

        public GetVehicleByIdQueryHandler(IVehicleRepository vehicleRepository, IMapper mapper)
        {
            _vehicleRepository = vehicleRepository;
            _mapper = mapper;
        }
        public async Task<DataResult<VehicleDto>> Handle(GetVehicleByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var vehicleItem = await _vehicleRepository.GetById(request.Id);
            var mappedProductObj = _mapper.Map<VehicleDto>(vehicleItem);
            return new SuccessDataResult<VehicleDto>(mappedProductObj);
        }
    }
}
