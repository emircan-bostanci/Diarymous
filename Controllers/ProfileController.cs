using Diarymous.Models;
using Diarymous.Models.Enums;
using Diarymous.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
  
       public IActionResult Index()
        {
            if (_check.checkState(HttpContext.User) == false)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(_context.accounts.Include(acc=>acc.diaries).FirstOrDefault(user => user.username == HttpContext.User.Identity.Name));
        }

        [HttpPost]
        public IActionResult Index(int id,InterventionType interventionType)
        {
           _intervation.setItem(interventionType, id);
           return View();
        }
    }
}
