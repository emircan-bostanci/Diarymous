using Diarymous.Models.Entities;
using Diarymous.Models.Enums;
using Diarymous.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diarymous.Models
{
    public class DiaryIntervation : IIntervation
    {
        private readonly Context context;
        public DiaryIntervation(Context context)
        {
            this.context = context;
        }
        public void setItem(InterventionType type,int itemId)
        {
           var item = context.diaries.FirstOrDefault(item => item.id == itemId);
           if(type == InterventionType.delete)
            {
                this.context.diaries.Remove(item);
                this.context.SaveChanges();
            } 
           else if(type == InterventionType.hide)
            {
                item.isPrivate = true;
                this.context.SaveChanges();
            }
        }
    }
}
