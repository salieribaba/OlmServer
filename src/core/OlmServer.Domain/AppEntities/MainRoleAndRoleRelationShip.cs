using OlmServer.Domain.AppEntities.Abstractions;
using OlmServer.Domain.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlmServer.Domain.AppEntities
{
    public sealed class MainRoleAndRoleRelationShip:BaseEntity
    {
        [ForeignKey("MainRole")]
        public string MainRoleId { get; set; }
        [ForeignKey("AppRole")]
        public string RoleId { get; set; }

        public AppRole AppRole { get; set; }
        public MainRole MainRole { get; set; }




    }
}
