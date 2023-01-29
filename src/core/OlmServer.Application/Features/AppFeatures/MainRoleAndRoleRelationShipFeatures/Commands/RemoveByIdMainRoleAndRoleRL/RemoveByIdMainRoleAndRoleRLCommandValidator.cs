using FluentValidation;

namespace OlmServer.Application.Features.AppFeatures.MainRoleAndRoleRelationShipFeatures.Commands.RemoveByIdMainRoleAndRoleRL
{
    public class RemoveByIdMainRoleAndRoleRLCommandValidator : AbstractValidator<RemoveByIdMainRoleAndRoleRLCommand>
    {
        public RemoveByIdMainRoleAndRoleRLCommandValidator()
        {
            _ = RuleFor(p => p.Id).NotEmpty().WithMessage("Id alanı zorunludur!");
            _ = RuleFor(p => p.Id).NotNull().WithMessage("Id alanı zorunludur!");
        }
    }
}
