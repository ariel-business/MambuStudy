using MambuStudy.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MambuStudy.Api.Controllers
{
    [Route("api/depositproducts")]
    [ApiController]
    public class DepositProductController : ControllerBase
    {
        private readonly IDepositProductService _depositProductService;

        public DepositProductController(IDepositProductService depositProductService)
        {
               _depositProductService = depositProductService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll([FromQuery] int? limit, [FromQuery] int? offset, [FromQuery] string? detailsLevel = "FULL")
        {
            var result = await _depositProductService.GetAll(limit, offset, detailsLevel);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("{depositProductId}")]
        public async Task<ActionResult> GetById([FromRoute] string depositProductId, [FromQuery] string? detailsLevel = "FULL")
        {
            var result = await _depositProductService.GetById(depositProductId, detailsLevel);

            if (result.IsSuccess)
                return Ok(result);

            return NotFound(result);
        }
    }
}
