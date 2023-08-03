using MambuStudy.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MambuStudy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepositProductController : ControllerBase
    {
        private readonly IDepositProductService _depositProductService;

        public DepositProductController(IDepositProductService depositProductService)
        {
               _depositProductService = depositProductService;
        }

        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] int? limit, [FromQuery] int? offset, [FromQuery] string? detailsLevel = "FULL")
        {
            var result = await _depositProductService.Get(limit, offset, detailsLevel);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        } 
    }
}
