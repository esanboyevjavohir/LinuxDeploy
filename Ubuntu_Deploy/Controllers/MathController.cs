using Microsoft.AspNetCore.Mvc;
using Ubuntu_Deploy.Services;

namespace Ubuntu_Deploy.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class MathController : ControllerBase
    {
        [HttpGet("add")]
        public async Task<IActionResult> AddAsync(
            [FromQuery] long x,
            [FromQuery] long y,
            [FromServices] IMathService mathService,
            CancellationToken cancellationToken = default)
        {
            var result = await mathService.AddAsync(x, y);

            return Ok(new {result = result});
        }
    }
}
