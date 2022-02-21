using System;
using System.ComponentModel.DataAnnotations;

namespace Diarymous.Models.Entities
{
    public class Diary
    {
        [Key]
        public int id { get; set; }
        [Required]
        [RegularExpression(@"^[A-z ]+", ErrorMessage = "You should use only text")]
        public string title { get; set; }
        public string diaryText { get; set; }
        public DateTime publishDate { get; set; }
    }
}