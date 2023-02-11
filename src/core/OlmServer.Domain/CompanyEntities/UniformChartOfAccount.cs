using OlmServer.Domain.AppEntities.Abstractions;

namespace OlmServer.Domain.CompanyEntities
{
    public sealed class UniformChartOfAccount : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
