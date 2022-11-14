using AutoMapper;
using Domain.Dtos;
using Domain.Entities;

namespace Services.Profiles
{
    public class CargoProfile : Profile
    {
        public CargoProfile()
        {
            CreateMap<Cargo, CargoDTO>();
        }
    }
}
