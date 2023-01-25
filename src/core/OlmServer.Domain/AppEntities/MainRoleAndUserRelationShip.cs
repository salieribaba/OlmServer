using OlmServer.Domain.AppEntities.Abstractions;
using OlmServer.Domain.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlmServer.Domain.AppEntities
{
    public class MainRoleAndUserRelationShip:BaseEntity
    {
        [ForeignKey("MainRole")]
        public string MainRoleId { get; set; }
        [ForeignKey("AppUser")]
        public string UserId { get; set; }
        [ForeignKey("Company")]
        public string CompanyId { get; set; }

        public MainRole MainRole { get; set; }
        public AppUser AppUser { get; set; }
        public Company Company { get; set; }
    }
}
