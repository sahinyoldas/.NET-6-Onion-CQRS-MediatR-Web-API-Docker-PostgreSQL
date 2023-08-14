using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnionArchitecture.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        [HttpGet(Name = "GetAllVehicles")]
        public string GetAllVehicles()
        {
            return "It worked";
        }
    }
}
