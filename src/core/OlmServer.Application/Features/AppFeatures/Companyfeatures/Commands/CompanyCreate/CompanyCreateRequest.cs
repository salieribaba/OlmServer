using MediatR;

namespace OlmServer.Application.Features.AppFeatures.Companyfeatures.Commands.CompanyCreate
{
    public sealed class CompanyCreateRequest : IRequest<CompanyCreateResponse>
    {
        public string Name { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
