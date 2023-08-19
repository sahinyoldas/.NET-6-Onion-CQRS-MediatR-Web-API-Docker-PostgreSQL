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
    public class GetAllVehiclesQueryHandler : IRequestHandler<GetAllVehiclesQueryRequest, DataResult<IEnumerable<VehicleDto>>>
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMapper _mapper;

        public GetAllVehiclesQueryHandler(IVehicleRepository vehicleRepository, IMapper mapper)
        {
            _vehicleRepository = vehicleRepository;
            _mapper = mapper;
        }
        public async Task<DataResult<IEnumerable<VehicleDto>>> Handle(GetAllVehiclesQueryRequest request, CancellationToken cancellationToken)
        {
            var vehicleList = await _vehicleRepository.GetList();
            var viewModel = _mapper.Map<List<VehicleDto>>(vehicleList);
            return new SuccessDataResult<IEnumerable<VehicleDto>>(viewModel);
        }
    }
}
