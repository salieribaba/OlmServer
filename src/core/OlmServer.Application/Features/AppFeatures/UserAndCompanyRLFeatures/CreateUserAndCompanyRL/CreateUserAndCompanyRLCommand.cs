using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.CreateUserAndCompanyRL
{
    public record CreateUserAndCompanyRLCommand(
    string AppUserId,
    string CompanyId) : ICommand<CreateUserAndCompanyRLCommandResponse>;

}
