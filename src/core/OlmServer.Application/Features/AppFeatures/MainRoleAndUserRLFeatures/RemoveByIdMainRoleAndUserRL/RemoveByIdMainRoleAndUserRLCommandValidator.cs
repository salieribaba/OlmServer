using FluentValidation;

namespace OlmServer.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.RemoveByIdMainRoleAndUserRL
{
    public class RemoveByIdMainRoleAndUserRLCommandValidator : AbstractValidator<RemoveByIdMainRoleAndUserRLCommand>
    {
        public RemoveByIdMainRoleAndUserRLCommandValidator()
        {
            _ = RuleFor(p => p.Id).NotEmpty().WithMessage("Id alanı boş olamaz!");
            _ = RuleFor(p => p.Id).NotNull().WithMessage("Id alanı boş olamaz!");
        }
    }
}
