using FluentValidation;

namespace OlmServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.CreateUserAndCompanyRL
{
    public class CreateUserAndCompanyRLCommandValidator : AbstractValidator<CreateUserAndCompanyRLCommand>
    {
        public CreateUserAndCompanyRLCommandValidator()
        {
            _ = RuleFor(p => p.AppUserId).NotEmpty().WithMessage("Kullanıcı seçilmelidir!");
            _ = RuleFor(p => p.AppUserId).NotNull().WithMessage("Kullanıcı seçilmelidir!");
            _ = RuleFor(p => p.CompanyId).NotNull().WithMessage("Şirket seçilmelidir!");
            _ = RuleFor(p => p.CompanyId).NotEmpty().WithMessage("Şirket seçilmelidir!");
        }
    }
}
