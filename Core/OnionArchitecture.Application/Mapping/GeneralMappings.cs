using AutoMapper;
using OnionArchitecture.Application.Dto;
using OnionArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Mapping
{
    public class GeneralMappings : Profile
    {
        public GeneralMappings()
        {
            CreateMap<Vehicle, VehicleDto>().ReverseMap();
        }
    }
}
