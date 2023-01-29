using MediatR;
using Microsoft.AspNetCore.Mvc;
using OlmServer.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.CreateMainRoleAndUserRL;
using OlmServer.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.RemoveByIdMainRoleAndUserRL;
using OlmServer.Presentation.Abstractions;

namespace OlmServer.Presentation.Controller
{
    public class MainRoleAndUserRelationshipsController : ApiController
    {
        public MainRoleAndUserRelationshipsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateMainRoleAndUserRLCommand request)
        {
            CreateMainRoleAndUserRLCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RemoveById(RemoveByIdMainRoleAndUserRLCommand request)
        {
            RemoveByIdMainRoleAndUserRLCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }

}
