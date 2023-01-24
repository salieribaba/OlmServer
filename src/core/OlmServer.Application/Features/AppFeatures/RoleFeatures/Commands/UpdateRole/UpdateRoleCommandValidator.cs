using FluentValidation;

namespace OlmServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole
{
    public class UpdateRoleCommandValidator : AbstractValidator<UpdateRoleCommand>
    {
        public UpdateRoleCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} boş geçilemez.")
                .NotNull()
                .MaximumLength(150).WithMessage("{PropertyName} yüz elli karakterden fazla giremezsiniz.");

            RuleFor(p => p.Code)
                .NotEmpty().WithMessage("{PropertyName} boş geçilemez.")
                .NotNull()
                .MaximumLength(150).WithMessage("{PropertyName} yüz elli karakterden fazla giremezsiniz.");



        }
    }
}
