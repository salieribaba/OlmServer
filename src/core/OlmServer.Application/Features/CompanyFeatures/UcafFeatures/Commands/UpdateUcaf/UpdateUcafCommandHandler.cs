using OlmServer.Application.Messaging;
using OlmServer.Application.Services.CompanyServices;
using OlmServer.Domain.CompanyEntities;

namespace OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.UpdateUcaf
{
    public class UpdateUcafCommandHandler : ICommandHandler<UpdateUcafCommand, UpdateUcafCommandResponse>
    {
        private readonly IUcafService _ucafService;

        public UpdateUcafCommandHandler(IUcafService ucafService)
        {
            _ucafService = ucafService;
        }

        public async Task<UpdateUcafCommandResponse> Handle(UpdateUcafCommand request, CancellationToken cancellationToken)
        {
            UniformChartOfAccount ucaf = await _ucafService.GetByIdAsync(request.Id, request.CompanyId);

            if (ucaf == null) throw new Exception("Hesap planı bulunamadı.");

            if (ucaf.Code != request.Code)
            {

                var ucafByCode = await _ucafService.GetByCodeAsync(request.CompanyId, request.Code, cancellationToken);
                if (ucafByCode != null) throw new Exception("Hesap planı kodu zaten kullanımda.");

            }

            if (request.Type != "G" && request.Type != "M") throw new Exception("Hesap planı türü Grup ya da Muavin olmalıdır!");

            ucaf.Name = request.Name;

            ucaf.Code = request.Code;

            ucaf.Type = request.Type == "G" ? "G" : "M";

            await _ucafService.UpdateUcafAsync(ucaf, request.CompanyId);



            return new();
        }
    }
}
