﻿using MambuStudy.Application.Interfaces;
using MambuStudy.Application.ViewModel.Request;
using MambuStudy.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace MambuStudy.Api.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll([FromQuery] int? limit, [FromQuery] int? offset, [FromQuery] DetailsLevel? detailsLevel = DetailsLevel.BASIC)
        {
            var result = await _clientService.GetAll(limit, offset, detailsLevel);

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
        public async Task<ActionResult> GetById([FromRoute] string clientId, [FromQuery] DetailsLevel? detailsLevel = DetailsLevel.BASIC)
        {
            var result = await _clientService.GetById(clientId, detailsLevel);

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
