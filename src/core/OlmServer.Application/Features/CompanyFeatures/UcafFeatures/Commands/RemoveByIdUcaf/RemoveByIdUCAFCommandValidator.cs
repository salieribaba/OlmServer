using FluentValidation;

namespace OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.RemoveByIdUcaf
{
    public sealed class RemoveByIdUCAFCommandValidator : AbstractValidator<RemoveByIdUCAFCommand>
    {
        public RemoveByIdUCAFCommandValidator()
        {
            _ = RuleFor(p => p.Id).NotEmpty().WithMessage("Id alanı boş olamaz!");
            _ = RuleFor(p => p.Id).NotNull().WithMessage("Id alanı boş olamaz!");
            _ = RuleFor(p => p.CompanyId).NotNull().WithMessage("Şirket bilgisi boş olamaz!");
            _ = RuleFor(p => p.CompanyId).NotEmpty().WithMessage("Şirket bilgisi boş olamaz!");
        }
    }

}
