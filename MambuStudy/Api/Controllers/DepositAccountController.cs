using MambuStudy.Application.Interfaces;
using MambuStudy.Application.Services;
using MambuStudy.Application.ViewModel.Request;
using Microsoft.AspNetCore.Mvc;

namespace MambuStudy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepositAccountController : ControllerBase
    {
        private readonly IDepositAccountService _depositAccountService;

        public DepositAccountController(IDepositAccountService depositAccountService)
        {
            _depositAccountService = depositAccountService;
        }

        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] int? limit, [FromQuery] int? offset)
        {
            var result = await _depositAccountService.Get(limit, offset);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateDepositAccountRequest depositAccountRequest)
        {
            var result = await _depositAccountService.Create(depositAccountRequest);

            if (result.IsSuccess)
                return CreatedAtAction(nameof(GetById), new { depositAccountId = result.Data.Id }, result);

            return BadRequest(result);
        }

        [HttpGet("{depositAccountId}")]
        public async Task<ActionResult> GetById([FromRoute] string depositAccountId)
        {
            var result = await _depositAccountService.GetById(depositAccountId);

            if (result.IsSuccess)
                return Ok(result);

            return NotFound(result);
        }

        [HttpDelete("{depositAccountId}")]
        public async Task<ActionResult> Delete([FromRoute] string depositAccountId)
        {
            var result = await _depositAccountService.Delete(depositAccountId);

            if (result.IsSuccess)
                return NoContent();

            return NotFound(result);
        }
    }
}
