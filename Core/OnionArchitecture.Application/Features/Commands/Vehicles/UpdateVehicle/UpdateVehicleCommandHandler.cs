using AutoMapper;
using MediatR;
using OnionArchitecture.Application.Interfaces.Repository;
using OnionArchitecture.Application.Wrappers;
using OnionArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Commands.Vehicles
{
    public class UpdateVehicleCommandHandler : IRequestHandler<UpdateVehicleCommandRequest, Result>
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMapper _mapper;

        public UpdateVehicleCommandHandler(IMapper mapper, IVehicleRepository vehicleRepository)
        {
            _mapper = mapper;
            _vehicleRepository = vehicleRepository;
        }

        public async Task<Result> Handle(UpdateVehicleCommandRequest request, CancellationToken cancellationToken)
        {
            var vehicleWillBeUpdated = await _vehicleRepository.GetById(request.Id);
            if (vehicleWillBeUpdated is null)
            {
                return new SuccessResult(Constants.ConstantMessages.VehicleNotFound);
            }
            vehicleWillBeUpdated.Name = request.Name;
            vehicleWillBeUpdated.Year = request.Year;
            vehicleWillBeUpdated.Price = request.Price;
            var updatedVehicle = await _vehicleRepository.Update(_mapper.Map<Vehicle>(vehicleWillBeUpdated));
            return new SuccessResult(Constants.ConstantMessages.VehicleUpdated);
        }
    }
}
