using Diarymous.Models;
using Diarymous.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diarymous.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        private readonly Context _context;
        public HomeController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index(int id)
        {
            return View(_context.Diaries.ToList());
        }
        public IActionResult AddDiary()
        {
            return View(new DiaryManager());
        }
        [HttpPost]
        public IActionResult AddDiary(DiaryManager diary)
        {
            Console.WriteLine(ModelState.IsValid);
            if (ModelState.IsValid) {
                Diary temp= diary; 
                _context.Diaries.Add(temp);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
