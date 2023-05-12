﻿using EasyCashIdentityProject.DTOLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {

        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("ad alanı boş geçilemez");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrar alanı boş geçilemez");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter girişi yapınız");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Paralolarınız Eşleşmiyor.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen Geçerli bir mail adresi giriniz!");



        }

    }
}
