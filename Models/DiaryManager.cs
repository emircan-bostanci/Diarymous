using Diarymous.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Diarymous.Models
{
    public class DiaryManager
    {
        [DisplayName("Baslik")]
        public string title { get; set; }
        [DisplayName("Metin")]
        public string text { get; set; }
        public static implicit operator Diary(DiaryManager diaryManager) {
            Diary diary = new Diary();
            diary.title = diaryManager.title;
            diary.diaryText = diaryManager.text;
            diary.publishDate = DateTime.Now;
            return diary; 
          }
    }
}
