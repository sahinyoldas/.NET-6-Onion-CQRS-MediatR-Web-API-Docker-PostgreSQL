using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Application.Features.Commands.Vehicles.SaveVehicle;
using OnionArchitecture.Application.Features.Queries.Vehicles;

namespace OnionArchitecture.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<VehicleController> _logger;
        public VehicleController(IMediator mediator, ILogger<VehicleController> logger)
        {
            _mediator = mediator;
            _logger = logger;
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

        [HttpPost("SaveVehicle")]
        public async Task<IActionResult> Save([FromBody]SavehicleCommandRequest commandRequest)
        {
            _logger.LogInformation(System.Text.Json.JsonSerializer.Serialize(commandRequest).ToString());
            var addedVehicle = await _mediator.Send(commandRequest);
            if (addedVehicle is null)
                return NotFound();
            return Ok(addedVehicle);
        }
    }
}
