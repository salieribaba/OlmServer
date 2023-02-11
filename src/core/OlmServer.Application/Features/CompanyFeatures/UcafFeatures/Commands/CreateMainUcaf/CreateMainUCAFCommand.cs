using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.CreateMainUcaf
{
    public sealed record CreateMainUCAFCommand(string CompanyId) : ICommand<CreateMainUCAFCommandResponse>;
}
