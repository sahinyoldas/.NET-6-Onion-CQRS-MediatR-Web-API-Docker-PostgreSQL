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
        private readonly IMediator _mediator;
        public VehicleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetVehicleById/{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var productDto = await _mediator.Send(new GetVehicleByIdQueryRequest(id));
            if (productDto is null)
                return NotFound();
            return Ok(productDto);
        }

        [HttpGet("GetAllVehicles")]
        public async Task<IActionResult> GetAllVehicles()
        {
            var productDtoList = await _mediator.Send(new GetAllVehiclesQueryRequest());
            if (productDtoList is null)
                return NotFound();
            return Ok(productDtoList);
        }
    }
}
