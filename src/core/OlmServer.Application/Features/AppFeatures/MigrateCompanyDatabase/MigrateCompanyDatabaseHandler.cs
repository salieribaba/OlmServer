using MediatR;
using OlmServer.Application.Services.AppServices;

namespace OlmServer.Application.Features.AppFeatures.MigrateCompanyDatabase
{
    public sealed class MigrateCompanyDatabaseHandler : IRequestHandler<MigrateCompanyDatabaseRequest, MigrateCompanyDatabaseResponse>
    {
        private readonly ICompanyService _companyService;

        public MigrateCompanyDatabaseHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<MigrateCompanyDatabaseResponse> Handle(MigrateCompanyDatabaseRequest request, CancellationToken cancellationToken)
        {
            await _companyService.MigrateCompanyDatabase();
            return new();
        }
    }
}
