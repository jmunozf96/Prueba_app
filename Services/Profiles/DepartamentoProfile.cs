using AutoMapper;
using Domain.Dtos;
using Domain.Entities;

namespace Services.Profiles
{
    public class DepartamentoProfile: Profile
    {
        public DepartamentoProfile()
        {
            CreateMap<Departamento, DepartamentoDTO>();
        }
    }
}
