using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Application.Features.Queries.Vehicle;

namespace OnionArchitecture.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IMediator mediator;
        public VehicleController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("GetVehicleById/{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var productDto = await mediator.Send(new GetVehicleByIdQueryRequest(id));
            if (productDto is null)
                return NotFound();
            return Ok(productDto);
        }

        [HttpGet("GetAllVehicles")]
        public async Task<IActionResult> GetAllVehicles()
        {
            var productDtoList = await mediator.Send(new GetAllVehiclesQueryRequest());
            if (productDtoList is null)
                return NotFound();
            return Ok(productDtoList);
        }
    }
}
