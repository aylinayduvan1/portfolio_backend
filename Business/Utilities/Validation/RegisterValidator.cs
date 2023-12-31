﻿using Business.Models.Request;
using FluentValidation;

namespace Business.Utilities.Validation;

public class RegisterValidator : AbstractValidator<RegisterDto>
{
    public RegisterValidator()
    {
        RuleFor(x => x.Email).NotEmpty().WithName("E-Mail").MinimumLength(8);
        RuleFor(x => x.UserName).NotEmpty().WithName("Kullanıcı Adı").MinimumLength(5);
        RuleFor(x => x.Password).NotEmpty().WithName("Şifre").MinimumLength(8);
        RuleFor(x => x.Password).NotEmpty().WithName("Şifre").MinimumLength(8);

        RuleFor(x => x.Gsm).NotEmpty().WithName("telefon numarası").MinimumLength(11);

        RuleFor(x => x.Adress).NotEmpty().WithName("adres").MinimumLength(3);

        RuleFor(x => x.SurName).NotEmpty().WithName("soyad").MinimumLength(2);

    }
}