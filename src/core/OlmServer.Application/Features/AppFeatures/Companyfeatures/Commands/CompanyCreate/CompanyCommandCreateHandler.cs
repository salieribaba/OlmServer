using OlmServer.Application.Messaging;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;

namespace OlmServer.Application.Features.AppFeatures.Companyfeatures.Commands.CompanyCreate
{
    public sealed class CompanyCommandCreateHandler : ICommandHandler<CompanyCommandCreate, CompanyCommandCreateResponse>
    {
        private readonly ICompanyService _companyService;

        public CompanyCommandCreateHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<CompanyCommandCreateResponse> Handle(CompanyCommandCreate request, CancellationToken cancellationToken)
        {
            Company company = await _companyService.GetCompanyByName(request.Name, cancellationToken);
            if (company != null) throw new Exception("Bu şirket adı daha önce kullanılmış!");

            await _companyService.CreateCompany(request, cancellationToken);
            return new();
        }
    }
}
