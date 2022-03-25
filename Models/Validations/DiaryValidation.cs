using Diarymous.Models.Attributes;
using Diarymous.Models.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diarymous.Models.Validations
{
    public class DiaryValidation:AbstractValidator<DiaryManager>
    {
        public DiaryValidation()
        {
            RuleFor(diary => diary.title).NotNull().NotEmpty().WithMessage("Başlık boş bırakılamaz ");
            RuleFor(diary => diary.text).NotEmpty().NotNull().WithMessage("Günlük boş bırakılamaz")
            .Must(new WordAttribute(50).WordValidation).WithMessage("Günlük en az 50 kelimeden oluşmalı");
        }
    }
}
