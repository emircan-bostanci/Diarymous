using Diarymous.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diarymous.Models.Interfaces
{
    public interface IIntervation
    {
        void setItem(InterventionType type,int itemId);
    }
}
