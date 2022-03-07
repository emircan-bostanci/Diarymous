using Diarymous.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diarymous.Models
{
    public class LoginState:ICheck
    {
        public bool checkState(HttpContext httpContext)
        {
            bool loginState = httpContext.User.Identity.Name == null ? false : true; 
            return loginState;
        }
    }
}
