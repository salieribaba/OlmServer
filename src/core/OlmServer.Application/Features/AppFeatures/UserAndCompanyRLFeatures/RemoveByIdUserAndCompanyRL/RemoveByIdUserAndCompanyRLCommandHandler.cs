using OlmServer.Application.Messaging;
using OlmServer.Application.Services.AppServices;

namespace OlmServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.RemoveByIdUserAndCompanyRL
{
    public sealed class RemoveByIdUserAndCompanyRLCommandHandler : ICommandHandler<RemoveByIdUserAndCompanyRLCommand, RemoveByIdUserAndCompanyRLCommandResponse>
    {
        private readonly IUserAndCompanyRelationshipService _service;

        public RemoveByIdUserAndCompanyRLCommandHandler(IUserAndCompanyRelationshipService service)
        {
            _service = service;
        }

        public async Task<RemoveByIdUserAndCompanyRLCommandResponse> Handle(RemoveByIdUserAndCompanyRLCommand request, CancellationToken cancellationToken)
        {
            await _service.RemoveByIdAsync(request.Id);
            return new();
        }
    }
}
