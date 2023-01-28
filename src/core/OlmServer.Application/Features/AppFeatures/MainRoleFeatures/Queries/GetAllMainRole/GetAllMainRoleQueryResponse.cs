using OlmServer.Domain.AppEntities;

namespace OlmServer.Application.Features.AppFeatures.MainRoleFeatures.Queries.GetAllMainRole
{
    public record GetAllMainRoleQueryResponse(IList<MainRole> MainRoles);
   
}
