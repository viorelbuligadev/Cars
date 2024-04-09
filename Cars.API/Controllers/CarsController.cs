using Cars.API.Cars.Queries;
using Cars.API.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cars.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController(IMediator mediator)
    {
        private readonly IMediator _mediator = mediator;

        [HttpGet("stream")]
        public IAsyncEnumerable<CarDto> StreamBooks()
        {
            IAsyncEnumerable<CarDto> stream = _mediator.CreateStream<CarDto>(new CarsQuery());

            return stream;
        }

    }
}
