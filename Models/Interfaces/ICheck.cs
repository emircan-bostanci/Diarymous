using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diarymous.Models.Interfaces
{
    public interface ICheck
    {
        public bool checkState(HttpContext httpContext);
    }
}
