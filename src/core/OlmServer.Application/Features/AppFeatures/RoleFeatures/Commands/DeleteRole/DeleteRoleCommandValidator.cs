using FluentValidation;

namespace OlmServer.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
    public class DeleteRoleCommandValidator : AbstractValidator<DeleteRoleCommand>
    {
        public DeleteRoleCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("{PropertyName} alanı boş geçilemez.")
                .NotNull().WithMessage("{PropertyName} alanı boş geçilemez.");
        }
    }
}
