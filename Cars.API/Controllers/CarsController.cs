using Cars.API.Cars.Queries;
using Cars.API.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cars.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController(IMediator mediator)
    {
        private readonly IMediator _mediator = mediator;

        [HttpGet("carsstream")]
        public IAsyncEnumerable<CarDto> StreamBooks()
        {
            IAsyncEnumerable<CarDto> stream = _mediator.CreateStream<CarDto>(new CarsQuery());

            return stream;
        }

    }
}
