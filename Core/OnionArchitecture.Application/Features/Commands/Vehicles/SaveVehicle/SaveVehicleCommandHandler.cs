using AutoMapper;
using MediatR;
using OnionArchitecture.Application.Dto;
using OnionArchitecture.Application.Interfaces.Repository;
using OnionArchitecture.Application.Wrappers;
using OnionArchitecture.Domain;
using OnionArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Commands.Vehicles.SaveVehicle
{
    public class SaveVehicleCommandHandler : IRequestHandler<SavehicleCommandRequest, DataResult<Vehicle>>
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMapper _mapper;

        public SaveVehicleCommandHandler(IMapper mapper, IVehicleRepository vehicleRepository)
        {
            _mapper = mapper;
            _vehicleRepository = vehicleRepository;
        }

        public async Task<DataResult<Vehicle>> Handle(SavehicleCommandRequest request, CancellationToken cancellationToken)
        {
            var addedVehicle = await _vehicleRepository.Save(_mapper.Map<Vehicle>(request));
            return new SuccessDataResult<Vehicle>(addedVehicle);
        }
    }
}
