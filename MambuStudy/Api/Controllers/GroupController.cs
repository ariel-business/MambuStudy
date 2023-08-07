using MambuStudy.Application.Interfaces;
using MambuStudy.Application.ViewModel.Request;
using Microsoft.AspNetCore.Mvc;

namespace MambuStudy.Api.Controllers
{
    [Route("api/groups")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IGroupService _groupService;
        public GroupController(IGroupService groupService)
        {
            _groupService = groupService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll([FromQuery] int? limit, [FromQuery] int? offset)
        {
            var result = await _groupService.GetAll(limit, offset);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateGroupRequest groupRequest)
        {
            var result = await _groupService.Create(groupRequest);

            if (result.IsSuccess)
                return CreatedAtAction(nameof(GetById), new { groupId = result.Data.Id }, result);

            return BadRequest(result);
        }

        [HttpGet("{groupId}")]
        public async Task<ActionResult> GetById([FromRoute] string groupId, [FromQuery] string detailsLevel = "BASIC")
        {
            var result = await _groupService.GetById(groupId, detailsLevel);

            if (result.IsSuccess)
                return Ok(result);

            return NotFound(result);
        }
    }
}
