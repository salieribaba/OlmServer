using OlmServer.Domain.AppEntities.Abstractions;
using OlmServer.Domain.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlmServer.Domain.AppEntities
{
    public class AppUsersCompany : BaseEntity
    {
        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        [ForeignKey("Company")]
        public string CompanyId { get; set; }

        public AppUser AppUser { get; set; }
        public Company Company { get; set; }
    }
}
