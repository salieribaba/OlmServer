using OlmServer.Application.Messaging;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities.Identity;

namespace OlmServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole
{
    public class UpdateRoleCommandHandler : ICommandHandler<UpdateRoleCommand, UpdateRoleCommandResponse>
    {
        private readonly IRoleService _roleService;

        public UpdateRoleCommandHandler(IRoleService roleService = null)
        {
            _roleService = roleService;
        }

        public async Task<UpdateRoleCommandResponse> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
        {
            AppRole role = await _roleService.GetByCode(request.Id);

            if (role == null) throw new Exception("Rol bulunamadı.");

            if (role.Code != request.Code)
            {
                AppRole roleCode = await _roleService.GetByCode(request.Code);
                if (roleCode != null) throw new Exception("Bu kod daha önce oluşturulmuş.");
            }

            role.Code = request.Code;
            role.Name = request.Name;

            await _roleService.UpdateAsync(role);
            return new();

        }

    }

}
