using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.CreateMainRoleAndUserRL
{
    public sealed record CreateMainRoleAndUserRLCommand(
    string UserId,
    string MainRoleId,
    string CompanyId) : ICommand<CreateMainRoleAndUserRLCommandResponse>;
}
