using MambuStudy.Application.Interfaces;
using MambuStudy.Application.ViewModel.Request;
using Microsoft.AspNetCore.Mvc;

namespace MambuStudy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] int? limit, [FromQuery] int? offset)
        {
            var result = await _clientService.Get(limit, offset);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateClientRequest clientRequest)
        {
            var result = await _clientService.Create(clientRequest);
           
            if(result.IsSuccess)
                return CreatedAtAction(nameof(GetById), new { clientId = result.Data.Id }, result);

            return BadRequest(result);
        }

        [HttpGet("{clientId}")]
        public async Task<ActionResult> GetById([FromRoute] string clientId)
        {
            var result = await _clientService.GetById(clientId);

            if (result.IsSuccess)
                return Ok(result);

            return NotFound(result);
        }

        [HttpDelete("{clientId}")]
        public async Task<ActionResult> Delete([FromRoute] string clientId)
        {
            var result = await _clientService.Delete(clientId);

            if (result.IsSuccess)
                return NoContent();

            return NotFound(result);
        }
    }
}
