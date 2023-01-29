using MediatR;
using Microsoft.AspNetCore.Mvc;
using OlmServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.CreateUserAndCompanyRL;
using OlmServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.RemoveByIdUserAndCompanyRL;
using OlmServer.Presentation.Abstractions;

namespace OlmServer.Presentation.Controller
{
    public class UserAndCompanyRelationshipsController : ApiController
    {
        public UserAndCompanyRelationshipsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateUserAndCompanyRLCommand request, CancellationToken cancellationToken)
        {
            CreateUserAndCompanyRLCommandResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RemoveById(RemoveByIdUserAndCompanyRLCommand request)
        {
            RemoveByIdUserAndCompanyRLCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
