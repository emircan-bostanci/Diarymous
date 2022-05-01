using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Diarymous.Models.Entities
{
    public class Suggestion{
        public int id{get;set;}
        public string suggestionText{get;set;}
        public DateTime suggestionDate{get;set;}
    }
}
