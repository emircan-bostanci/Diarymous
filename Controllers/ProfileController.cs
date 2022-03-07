using Diarymous.Models;
using Diarymous.Models.Enums;
using Diarymous.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diarymous.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
       private readonly Context _context;
        private readonly ClaimsManager claimsManager;
        private readonly ICheck _check;
        private readonly IIntervation _intervation;
        public ProfileController(Context context, ClaimsManager claimsManager, ICheck check,IIntervation intervation)
        {
            _intervation = intervation;
            _check = check;
            _context = context;
            this.claimsManager = claimsManager;
        }
  
       public IActionResult Profile()
        {
            if (_check.checkState(HttpContext) == false)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(_context.accounts.FirstOrDefault(user => user.username == HttpContext.User.Identity.Name));
        }

        [HttpPost]
        public IActionResult Profile(int id,InterventionType interventionType)
        {
           _intervation.setItem(interventionType, id);
           return View();
        }
    }
}
