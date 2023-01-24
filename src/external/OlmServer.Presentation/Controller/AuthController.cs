using MediatR;
using Microsoft.AspNetCore.Mvc;
using OlmServer.Application.Features.AppFeatures.AppUserFeature.Commands.Login;
using OlmServer.Presentation.Abstractions;

namespace OlmServer.Presentation.Controller
{
    public class AuthController : ApiController
    {
        public AuthController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("action")]

        public async Task<IActionResult> Login(LoginCommand request)
        {
            LoginCommandResponse response = await _mediator.Send(request);
            return Ok(response);

        }



    }
}
