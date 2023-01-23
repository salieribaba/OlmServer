using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.AppFeatures.MigrateCompanyDatabase
{
    public sealed record MigrateCommandCompanyDatabase() : ICommand<MigrateCommandCompanyDatabaseResponse>;
}
