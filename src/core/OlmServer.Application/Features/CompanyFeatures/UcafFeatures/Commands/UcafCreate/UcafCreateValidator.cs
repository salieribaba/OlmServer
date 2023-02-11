﻿using FluentValidation;

namespace OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.UcafCreate
{
    public class UcafCreateValidator : AbstractValidator<UcafCreateCommand>
    {
        public UcafCreateValidator()
        {
            _ = RuleFor(x => x.CompanyId).NotEmpty().WithMessage("{Property.Name} alanı gereklidir");
            _ = RuleFor(x => x.CompanyId).NotNull().WithMessage("{Property.Name} alanı gereklidir");

            _ = RuleFor(x => x.Name).NotEmpty().WithMessage("{Property.Name} alanı gereklidir");
            _ = RuleFor(x => x.Name).NotNull().WithMessage("{Property.Name} alanı gereklidir");

            _ = RuleFor(x => x.Code).NotEmpty().WithMessage("{Property.Name} alanı gereklidir");
            _ = RuleFor(x => x.Code).NotNull().WithMessage("{Property.Name} alanı gereklidir");
            _ = RuleFor(x => x.Code).MinimumLength(5).WithMessage("{Property.Name} alanı 5 karakterden az olamaz");

            _ = RuleFor(x => x.Type).NotEmpty().WithMessage("{Property.Name} alanı gereklidir");
            _ = RuleFor(x => x.Type).NotNull().WithMessage("{Property.Name} alanı gereklidir");
            _ = RuleFor(x => x.Type).MaximumLength(1).WithMessage("{Property.Name} alanı en fazla bir karakterdir.");

        }
    }
}
