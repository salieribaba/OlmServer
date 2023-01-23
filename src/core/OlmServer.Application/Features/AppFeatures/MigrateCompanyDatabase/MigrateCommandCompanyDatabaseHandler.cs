using MediatR;
using OlmServer.Application.Messaging;
using OlmServer.Application.Services.AppServices;

namespace OlmServer.Application.Features.AppFeatures.MigrateCompanyDatabase
{
    public sealed class MigrateCommandCompanyDatabaseHandler : ICommandHandler<MigrateCommandCompanyDatabase, MigrateCommandCompanyDatabaseResponse>
    {
        private readonly ICompanyService _companyService;

        public MigrateCommandCompanyDatabaseHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<MigrateCommandCompanyDatabaseResponse> Handle(MigrateCommandCompanyDatabase request, CancellationToken cancellationToken)
        {
            await _companyService.MigrateCompanyDatabase();
            return new();
        }
    }
}
