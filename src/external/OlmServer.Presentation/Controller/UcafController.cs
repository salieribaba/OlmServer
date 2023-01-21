using MediatR;
using Microsoft.AspNetCore.Mvc;
using OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.UcafCreate;
using OlmServer.Presentation.Abstractions;

namespace OlmServer.Presentation.Controller
{
    public sealed class UcafController : ApiController
    {
        public UcafController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async  Task<IActionResult> CreateUcaf(UcafCreateRequest request)
        {
           UcafCreateResponse response= await _mediator.Send(request);
            return Ok(response);

        }
    }
}
