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
    public class DeleteVehicleCommandHandler : IRequestHandler<DeleteVehicleCommandRequest, Result>
    {
        private readonly IVehicleRepository _vehicleRepository;

        public DeleteVehicleCommandHandler(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        public async Task<Result> Handle(DeleteVehicleCommandRequest request, CancellationToken cancellationToken)
        {
            var vehicleWillBeDeleted = await _vehicleRepository.GetById(request.Id);
            if (vehicleWillBeDeleted is null)
            {
                return new ErrorResult(Constants.ConstantMessages.VehicleNotFound);
            }
            await _vehicleRepository.Delete(vehicleWillBeDeleted);
            return new SuccessResult(Constants.ConstantMessages.VehicleDeleted);
        }
    }
}
s