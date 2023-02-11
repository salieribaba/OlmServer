
using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.UcafCreate
{
    public sealed record UcafCreateCommand(
        string Code,
        string Name,
        string Type,
        string CompanyId) : ICommand<UcafCreateCommandResponse>;
}
