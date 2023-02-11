using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.UpdateUcaf
{
    public sealed record UpdateUcafCommand(
        string Id,
        string CompanyId,
        string Code,
        string Name,
        string Type

        ) : ICommand<UpdateUcafCommandResponse>;

}
