using OnionArchitecture.Application.Interfaces.Repository;
using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Persistence.Context;
using OnionArchitecture.Persistence.Repositories;

namespace OnionArchitecture.Persistence
{
    public class VehicleRepository : GeneralRepository<Vehicle, ApplicationDbContext>, IVehicleRepository
    {
    }
}