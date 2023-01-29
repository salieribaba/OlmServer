using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.RemoveByIdUserAndCompanyRL
{
    public record RemoveByIdUserAndCompanyRLCommand(
    string Id) : ICommand<RemoveByIdUserAndCompanyRLCommandResponse>;

}
