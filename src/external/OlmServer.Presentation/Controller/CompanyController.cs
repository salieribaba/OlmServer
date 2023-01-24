using MediatR;
using Microsoft.AspNetCore.Mvc;
using OlmServer.Application.Features.AppFeatures.Companyfeatures.Commands.CompanyCreate;
using OlmServer.Application.Features.AppFeatures.MigrateCompanyDatabase;
using OlmServer.Presentation.Abstractions;

namespace OlmServer.Presentation.Controller
{
    public class CompanyController : ApiController
        
    {
        public CompanyController(IMediator mediator) : base(mediator)
        {
        }


        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCompany(CompanyCommandCreate request, CancellationToken cancellationToken = default)
        {
            CompanyCommandCreateResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> MigrateCompanyDatabases()
        {
            MigrateCommandCompanyDatabase request = new();
            MigrateCommandCompanyDatabaseResponse response = await _mediator.Send(request);
            return Ok(response);

        }


    }

}
