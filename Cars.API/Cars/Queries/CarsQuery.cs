using AutoMapper;
using Cars.API.DbContexts;
using Cars.API.Entities;
using Cars.API.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Cars.API.Cars.Queries;

public class CarsQuery : IStreamRequest<CarDto>
{

}

public class CarsQueryHandler(CarsContext carsContext, IMapper mapper)
    : IStreamRequestHandler<CarsQuery, CarDto>
{
    private readonly CarsContext _carsContext = carsContext;
    private readonly IMapper _mapper = mapper;

    public async IAsyncEnumerable<CarDto> Handle(CarsQuery request, CancellationToken cancellationToken)
    {
        var carQuery = _carsContext.Cars.AsAsyncEnumerable<Car>();

        await foreach (var carFromDb in carQuery)
        {
            // add a delay to visually see the effect
            await Task.Delay(500);
            yield return _mapper.Map<CarDto>(carFromDb); ;
        }
    }
}
