using Diarymous.Models.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diarymous.Models.Validations
{
    public class AccountValidation:AbstractValidator<Account>
    {
        public AccountValidation()
        {
          RuleFor(ac=>ac.username).NotEmpty().NotNull().WithMessage("Lütfen adınızı boş bırakmayınız!");
          RuleFor(ac => ac.password).NotEmpty().WithMessage("Şifre Boş Olamaz");
          RuleFor(ac => ac.password).Matches(@"^(?=.*?[A-Z])(?=(.*[a-z]){1,}).{8,}$").WithMessage(errorMessage:"Şifre En Az 8 karakterden oluşmalı ve en az 1 büyük ve küçük kelime kullanılmalı!");
        }
    }
}
