using MambuStudy.Application.Interfaces;
using MambuStudy.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace MambuStudy.Api.Controllers;

[Route("api/deposits/transactions")]
[ApiController]
public class DepositTransactionController : ControllerBase
{
    private readonly IDepositTransactionService _depositTransactionService;

    public DepositTransactionController(IDepositTransactionService depositTransactionService)
    {
        _depositTransactionService = depositTransactionService;
    }

    [HttpGet("{depositTransactionId}")]
    public async Task<ActionResult> GetById([FromRoute] string depositTransactionId, [FromQuery] DetailsLevel? detailsLevel = DetailsLevel.BASIC)
    {
        var result = await _depositTransactionService.GetById(depositTransactionId, detailsLevel);

        if (result.IsSuccess)
            return Ok(result);

        return NotFound(result);
    }
}
