using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlmServer.Domain.CompanyEntities;
using OlmServer.Persistance.Constans;

namespace OlmServer.Persistance.Configuration
{
    public sealed class UcafConfiguration : IEntityTypeConfiguration<UniformChartOfAccount>
    {
        public void Configure(EntityTypeBuilder<UniformChartOfAccount> builder)
        {
            builder.ToTable(TableNames.UniformChartOfAccount);
            builder.HasKey(x => x.Id);
        }
    }
}
