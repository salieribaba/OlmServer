using OlmServer.Domain.AppEntities.Abstractions;
using OlmServer.Domain.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlmServer.Domain.AppEntities
{
    public class MainRoleAndUserRelationShip : BaseEntity
    {
        public MainRoleAndUserRelationShip()
        {

        }

        public MainRoleAndUserRelationShip(string id, string userId, string mainRoleId, string companyId) : base(id)
        {
            UserId = userId;
            CompanyId = companyId;
            MainRoleId = mainRoleId;
        }

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
