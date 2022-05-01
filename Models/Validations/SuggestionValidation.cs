using Diarymous.Models.Attributes;
using Diarymous.Models.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diarymous.Models.Validations
{
    public class SuggestionValidation:AbstractValidator<Suggestion>
    {
        public SuggestionValidation(){
            RuleFor(suggestion => suggestion.suggestionText).NotEmpty().WithMessage("Öneri boş bırakılamaz");
        }
 
    }
}
