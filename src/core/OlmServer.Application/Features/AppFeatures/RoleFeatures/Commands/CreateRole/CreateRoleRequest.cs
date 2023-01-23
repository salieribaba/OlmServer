﻿using MediatR;

namespace OlmServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
    public sealed class CreateRoleRequest : IRequest<CreateRoleResponse>
    {
        public string Code { get; set; }
        public string Name { get; set; }



    }
}
