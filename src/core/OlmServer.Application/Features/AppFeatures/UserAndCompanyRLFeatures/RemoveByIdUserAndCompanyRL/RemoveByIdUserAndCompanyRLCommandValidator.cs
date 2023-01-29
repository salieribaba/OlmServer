using FluentValidation;

namespace OlmServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.RemoveByIdUserAndCompanyRL
{
    public sealed class RemoveByIdUserAndCompanyRLCommandValidator : AbstractValidator<RemoveByIdUserAndCompanyRLCommand>
    {
        public RemoveByIdUserAndCompanyRLCommandValidator()
        {
            _ = RuleFor(p => p.Id).NotEmpty().WithMessage("Id alanı boş olamaz!");
            _ = RuleFor(p => p.Id).NotNull().WithMessage("Id alanı boş olamaz!");
        }
    }
}
