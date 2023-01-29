using MediatR;
using Microsoft.AspNetCore.Mvc;
using OlmServer.Application.Features.AppFeatures.MainRoleAndRoleRelationShipFeatures.Commands.CreateMainRoleAndRoleRelationShips;
using OlmServer.Application.Features.AppFeatures.MainRoleAndRoleRelationShipFeatures.Commands.RemoveByIdMainRoleAndRoleRL;
using OlmServer.Application.Features.AppFeatures.MainRoleAndRoleRelationShipFeatures.Queries;
using OlmServer.Presentation.Abstractions;

namespace OlmServer.Presentation.Controller
{
    public class MainRoleAndRoleRelationshipsController : ApiController
    {
        public MainRoleAndRoleRelationshipsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateMainRoleAndRoleRelationShipCommand request, CancellationToken cancellationToken)
        {
            CreateMainRoleAndRoleRelationShipResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }


        [HttpPost("[action]")]
        public async Task<IActionResult> RemoveById(RemoveByIdMainRoleAndRoleRLCommand request)
        {
            RemoveByIdMainRoleAndRoleRLCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> GetAll()
        {
            GetAllMainRoleAndRoleRelationShipQuery request = new();
            GetAllMainRoleAndRoleRelationShipQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
