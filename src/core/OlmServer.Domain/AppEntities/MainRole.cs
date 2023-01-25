using OlmServer.Domain.AppEntities.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlmServer.Domain.AppEntities
{
    public sealed class MainRole : BaseEntity
    {
        public string Title { get; set; }
        [ForeignKey("Company")]
        public string CompanyId { get; set; }
        public bool IsRoleCreatedByAdmin { get; set; }

        public Company? Company { get; set; }

    }
}
