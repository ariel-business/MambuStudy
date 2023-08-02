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

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateClientRequest clientRequest)
        {
            var result = await _clientService.Create(clientRequest);

            return Ok(result);
        }

        [HttpGet("{clientId}")]
        public async Task<ActionResult> GetById([FromRoute] string clientId)
        {
            var result = await _clientService.GetById(clientId);

            return Ok(result);
        }

        [HttpDelete("{clientId}")]
        public async Task<ActionResult> Delete([FromRoute] string clientId)
        {
            var result = await _clientService.Delete(clientId);

            return Ok(result);
        }
    }
}
