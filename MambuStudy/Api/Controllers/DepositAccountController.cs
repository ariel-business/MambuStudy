using MambuStudy.Application.Interfaces;
using MambuStudy.Application.ViewModel.Request;
using Microsoft.AspNetCore.Mvc;

namespace MambuStudy.Api.Controllers
{
    [Route("api/deposits")]
    [ApiController]
    public class DepositAccountController : ControllerBase
    {
        private readonly IDepositAccountService _depositAccountService;

        public DepositAccountController(IDepositAccountService depositAccountService)
        {
            _depositAccountService = depositAccountService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll([FromQuery] int? limit, [FromQuery] int? offset, [FromQuery] string? detailsLevel = "BASIC")
        {
            var result = await _depositAccountService.GetAll(limit, offset, detailsLevel);

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

        [HttpPost("{depositAccountId}:changeState")]
        public async Task<ActionResult> ChangeDepositAccountState([FromRoute] string depositAccountId, [FromBody] ChangeDepositAccountStateRequest changeDepositAccountStateRequest)
        {
            var result = await _depositAccountService.ChangeDepositAccountState(depositAccountId, changeDepositAccountStateRequest);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("{depositAccountId}")]
        public async Task<ActionResult> GetById([FromRoute] string depositAccountId, [FromQuery] string? detailsLevel = "BASIC")
        {
            var result = await _depositAccountService.GetById(depositAccountId, detailsLevel);

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

        [HttpGet("{depositAccountId}/transactions")]
        public async Task<ActionResult> GetAllTransactions([FromRoute] string depositAccountId, [FromQuery] int? limit, [FromQuery] int? offset, [FromQuery] string? detailsLevel = "BASIC")
        {
            var result = await _depositAccountService.GetAllTransactions(depositAccountId, limit, offset, detailsLevel);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("{depositAccountId}/deposit-transactions")]
        public async Task<ActionResult> MakeDeposit([FromRoute] string depositAccountId, [FromBody] MakeDepositTransactionRequest makeDepositTransactionRequest)
        {
            var result = await _depositAccountService.MakeDeposit(depositAccountId, makeDepositTransactionRequest);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
