using OlmServer.Application.Messaging;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;

namespace OlmServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.CreateUserAndCompanyRL
{
    public class CreateUserAndCompanyRLCommandHandler : ICommandHandler<CreateUserAndCompanyRLCommand, CreateUserAndCompanyRLCommandResponse>
    {
        private readonly IUserAndCompanyRelationshipService _userAndCompanyRelationshipService;

        public CreateUserAndCompanyRLCommandHandler(IUserAndCompanyRelationshipService userAndCompanyRelationshipService)
        {
            _userAndCompanyRelationshipService = userAndCompanyRelationshipService;
        }

        public async Task<CreateUserAndCompanyRLCommandResponse> Handle(CreateUserAndCompanyRLCommand request, CancellationToken cancellationToken)
        {
            AppUsersCompany entity = await _userAndCompanyRelationshipService.GetByUserIdAndCompanyId(request.AppUserId, request.CompanyId, cancellationToken);
            if (entity != null) throw new Exception("Bu kullanıcı daha önce bu şirkete kayıt edilmiş!");

            AppUsersCompany userAndCompanyRelationship = new(
                Guid.NewGuid().ToString(),
                request.AppUserId,
                request.CompanyId);

            await _userAndCompanyRelationshipService.CreateAsync(userAndCompanyRelationship, cancellationToken);
            return new();
        }
    }
}
