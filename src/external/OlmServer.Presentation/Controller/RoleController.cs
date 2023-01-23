using MediatR;
using Microsoft.AspNetCore.Mvc;
using OlmServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using OlmServer.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole;
using OlmServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;
using OlmServer.Application.Features.AppFeatures.RoleFeatures.Queries.RolesGetAll;
using OlmServer.Presentation.Abstractions;

namespace OlmServer.Presentation.Controller
{
    public class RoleController : ApiController
    {
        public RoleController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateRole(CreateRoleRequest request)
        {
            CreateRoleResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllRoles()
        {
            RolesGetAllRequest request = new();
            RolesGetAllResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> UpdateRole(UpdateRoleRequest request)
        {
            UpdateRoleResponse response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpDelete("[action]/{id}")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            DeleteRoleRequest request = new() { Id = id };
            DeleteRoleResponse response = await _mediator.Send(request);
            return Ok(response);
        }





    }
}
