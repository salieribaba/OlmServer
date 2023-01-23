
using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.UcafCreate
{
    public sealed record UcafCreateCommand(string CompanyId, string Name, string Code, string Type) : ICommand<UcafCreateCommandResponse>;
}
