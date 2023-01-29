using OlmServer.Application.Messaging;
using OlmServer.Application.Services.AppServices;

namespace OlmServer.Application.Features.AppFeatures.AppUserFeature.Queries.GetRolesByUserIdAndCompanyId
{
    public sealed class GetRolesByUserIdAndCompanyIdQueryHandler : IQueryHandler<GetRolesByUserIdAndCompanyIdQuery, GetRolesByUserIdAndCompanyIdQueryResponse>
    {
        private readonly IAuthService _authService;

        public GetRolesByUserIdAndCompanyIdQueryHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<GetRolesByUserIdAndCompanyIdQueryResponse> Handle(GetRolesByUserIdAndCompanyIdQuery request, CancellationToken cancellationToken)
        {
            IList<string> roles = await _authService.GetRolesByUserIdAndCompanyId(request.UserId, request.CompanyId);

            return new(roles);
        }
    }

}
