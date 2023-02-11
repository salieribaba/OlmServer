using OlmServer.Application.Messaging;
using OlmServer.Application.Services.CompanyServices;

namespace OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.RemoveByIdUcaf
{
    public sealed class RemoveByIdUCAFCommandHandler : ICommandHandler<RemoveByIdUCAFCommand, RemoveByIdUCAFCommandResponse>
    {
        private readonly IUcafService _service;

        public RemoveByIdUCAFCommandHandler(IUcafService service)
        {
            _service = service;
        }

        public async Task<RemoveByIdUCAFCommandResponse> Handle(RemoveByIdUCAFCommand request, CancellationToken cancellationToken)
        {
            var checkRemoveUcafById = await _service.CheckRemoveByIdUcafIsGroupAndAvailable(request.Id, request.CompanyId);

            if (!checkRemoveUcafById) throw new Exception("Hesap planına bağlı alt hesaplar olduğundan silinemiyor!");

            await _service.RemoveByIdUcafAsync(request.Id, request.CompanyId);

            return new();
        }
    }
}
