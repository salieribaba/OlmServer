using FluentValidation;

namespace OlmServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
    public class CreateRolCommandValidator : AbstractValidator<CreateRoleCommand>
    {
        public CreateRolCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("İsim alanı boş geçilemez")
                .NotNull()
                .WithMessage("İsim alanı boş geçilemez")
                .MaximumLength(100)
                .WithMessage("İsim alanı 100 karakterden uzun olamaz")
                .MinimumLength(3)
                .WithMessage("İsim alanı 3 karakterden kısa olamaz");

            RuleFor(x => x.Code)
                .NotEmpty()
                .WithMessage("Kod alanı boş geçilemez")
                .NotNull()
                .WithMessage("Kod alanı boş geçilemez")
                .MaximumLength(100)
                .WithMessage("Kod alanı 100 karakterden uzun olamaz")
                .MinimumLength(3)
                .WithMessage("Kod alanı 3 karakterden kısa olamaz");
        }
    }
}
