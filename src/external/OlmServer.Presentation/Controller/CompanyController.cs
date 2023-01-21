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
        public async Task<IActionResult> CreateCompany(CompanyCreateRequest request)
        {
            CompanyCreateResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> MigrateCompanyDatabases()
        {
            MigrateCompanyDatabaseRequest request = new();
            MigrateCompanyDatabaseResponse response = await _mediator.Send(request);
            return Ok(response);

        }


    }

}
