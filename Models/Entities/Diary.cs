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
        public string ipAdrr { get; set; }
        [Required]
        public string diaryText { get; set; }
        public bool isPrivate { get; set; }
        public int likeCount{ get; set; }
        public Account? author { get; set; }
        public DateTime publishDate { get; set; }
    }
}