using FluentValidation;

namespace OlmServer.Application.Features.AppFeatures.MainRoleAndRoleRelationShipFeatures.Commands.CreateMainRoleAndRoleRelationShips
{
    public class CreateMainRoleAndRoleRLCommandValidator : AbstractValidator<CreateMainRoleAndRoleRelationShipCommand>
    {
        public CreateMainRoleAndRoleRLCommandValidator()
        {
            _ = RuleFor(p => p.RoleId).NotEmpty().WithMessage("Rol seçilmelidir!");
            _ = RuleFor(p => p.RoleId).NotNull().WithMessage("Rol seçilmelidir!");
            _ = RuleFor(p => p.MainRoleId).NotNull().WithMessage("Ana Rol seçilmelidir!");
            _ = RuleFor(p => p.MainRoleId).NotEmpty().WithMessage("Ana Rol seçilmelidir!");
        }
    }
}
