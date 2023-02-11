using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.RemoveByIdUcaf
{
    public sealed record RemoveByIdUCAFCommand(
    string Id,
    string CompanyId)
    : ICommand<RemoveByIdUCAFCommandResponse>;
}
