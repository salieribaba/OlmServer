using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.CreateMainUcaf;
using OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.RemoveByIdUcaf;
using OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.UcafCreate;
using OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.UpdateUcaf;
using OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Queries.GetAllUcaf;
using OlmServer.Presentation.Abstractions;

namespace OlmServer.Presentation.Controller
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    public sealed class UcafsController : ApiController
    {
        public UcafsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateUcaf(UcafCreateCommand request, CancellationToken cancellationToken = default)
        {
            UcafCreateCommandResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);

        }

        [HttpPost("[action]")]
        public async Task<IActionResult> UpdateUcaf(UpdateUcafCommand request, CancellationToken cancellationToken = default)
        {
            UpdateUcafCommandResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);

        }



        [HttpPost("[action]")]
        public async Task<IActionResult> CreateMainUCAF(CreateMainUCAFCommand request, CancellationToken cancellationToken)
        {
            CreateMainUCAFCommandResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> GetAllUcaf(GetAllUCAFQuery request, CancellationToken cancellationToken)
        {
            GetAllUCAFQueryResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RemoveByIdUCAF(RemoveByIdUCAFCommand request, CancellationToken cancellationToken)
        {
            RemoveByIdUCAFCommandResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
