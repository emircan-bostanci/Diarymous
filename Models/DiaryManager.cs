using Diarymous.Models.Attributes;
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
        public string title { get; set; }
        public string text { get; set; }
        public int likeCount{ get; set; }
        public string ipAdrr { get; set; }
        public static implicit operator Diary(DiaryManager diaryManager) {
            Diary diary = new Diary();
            diary.title = diaryManager.title;
            diary.diaryText = diaryManager.text;
            diary.publishDate = DateTime.Now;
            diary.isPrivate = false;
            diary.ipAdrr = diaryManager.ipAdrr;
            return diary; 
          }
    }
}
