using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyApp.Application.Queries;

namespace MyApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalVendorController(ISender sender) : ControllerBase
    {

        [HttpGet("GetCointDeskDatt")]
        public async Task<IActionResult> GetCoinDeskData()
        {
            var res = await sender.Send(new GetCoinDeskDataQuery());
            return Ok(res);
        }
    }
}
