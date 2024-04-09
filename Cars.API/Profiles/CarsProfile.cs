using AutoMapper;
using Cars.API.Entities;
using Cars.API.Models;

namespace Cars.API.Profiles;

public class CarsProfile : Profile
{
    public CarsProfile()
    {
        CreateMap<Car, CarDto>();
    }
}
