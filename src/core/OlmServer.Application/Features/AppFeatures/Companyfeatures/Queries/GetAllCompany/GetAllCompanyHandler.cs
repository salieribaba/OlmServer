using Microsoft.EntityFrameworkCore;
using OlmServer.Application.Messaging;
using OlmServer.Application.Services.AppServices;

namespace OlmServer.Application.Features.AppFeatures.Companyfeatures.Queries.GetAllCompany
{
    public class GetAllCompanyHandler : IQueryHandler<GetAllCompanyQuery, GetAllCompanyResponse>
    {
        private readonly ICompanyService _companyService;

        public GetAllCompanyHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<GetAllCompanyResponse> Handle(GetAllCompanyQuery request, CancellationToken cancellationToken)
        {
            var companies = _companyService.GetAllCompanies();
            return new GetAllCompanyResponse(await companies.ToListAsync());


        }
    }
}
