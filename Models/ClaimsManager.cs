using Microsoft.AspNetCore.Authentication.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Diarymous.Models
{
    public class ClaimsManager
    {
        
        public ClaimsPrincipal getClaim(string username)
        {
            ClaimsIdentity claimsIdentity = new(new List<Claim> { new Claim(ClaimTypes.Name, username) },CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal claimsPrincipal = new(claimsIdentity);
            return claimsPrincipal;
        }
    }
}
