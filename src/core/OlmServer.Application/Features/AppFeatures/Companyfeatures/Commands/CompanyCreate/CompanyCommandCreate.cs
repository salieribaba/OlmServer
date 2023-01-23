using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.AppFeatures.Companyfeatures.Commands.CompanyCreate
{
    public sealed record CompanyCommandCreate
        (string Name, string ServerName, string DatabaseName, string UserId, string Password)
        : ICommand<CompanyCommandCreateResponse>;
}
