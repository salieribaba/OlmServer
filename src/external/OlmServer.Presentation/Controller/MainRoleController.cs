﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using OlmServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRoles;
using OlmServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles;
using OlmServer.Application.Features.AppFeatures.MainRoleFeatures.Queries.GetAllMainRole;
using OlmServer.Presentation.Abstractions;

namespace OlmServer.Presentation.Controller
{
    public class MainRoleController : ApiController
    {
        public MainRoleController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateMainRole(MainRoleCreateCommand command, CancellationToken cancellationToken)
        {
            MainRoleCreateResponse response = await _mediator.Send(command, cancellationToken);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateStaticMainRoles(CancellationToken cancellationToken)
        {
            CreateStaticMainRolesCommand request = new(null);
            CreateStaticMainRolesResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> GetAll(GetAllMainRoleQuery request)
        {
            GetAllMainRoleQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

    }
}