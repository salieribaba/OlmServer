using MediatR;
using Microsoft.AspNetCore.Mvc;
using OlmServer.Application.Features.AppFeatures.AppUserFeature.Commands.Login;
using OlmServer.Application.Features.AppFeatures.AppUserFeature.Queries.GetRolesByUserIdAndCompanyId;
using OlmServer.Presentation.Abstractions;

namespace OlmServer.Presentation.Controller
{
    public class AuthController : ApiController
    {
        public AuthController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("action")]

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginCommand request)
        {
            LoginCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> GetRolesByUserIdAndCompanyId(GetRolesByUserIdAndCompanyIdQuery request)
        {
            GetRolesByUserIdAndCompanyIdQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }



    }
}
