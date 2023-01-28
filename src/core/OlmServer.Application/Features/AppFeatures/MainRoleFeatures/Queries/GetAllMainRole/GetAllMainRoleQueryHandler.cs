using OlmServer.Application.Messaging;
using OlmServer.Application.Services.AppServices;

namespace OlmServer.Application.Features.AppFeatures.MainRoleFeatures.Queries.GetAllMainRole
{
    public class GetAllMainRoleQueryHandler : IQueryHandler<GetAllMainRoleQuery, GetAllMainRoleQueryResponse>
    {
        private readonly IMainRoleService _mainRoleService;

        public GetAllMainRoleQueryHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public Task<GetAllMainRoleQueryResponse> Handle(GetAllMainRoleQuery request, CancellationToken cancellationToken)
        {
            var mainRoles = _mainRoleService.GetAll(cancellationToken).ToList();
            return Task.FromResult(new GetAllMainRoleQueryResponse(mainRoles));
        }
    }
}
