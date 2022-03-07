using Diarymous.Models;
using Diarymous.Models.Entities;
using Diarymous.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diarymous.Controllers
{
    public class HomeController : Controller
    {    
        private readonly Context _context;
        private readonly ICheck _check;
        public HomeController(Context context,ICheck check)
        {
            _check = check;
            _context = context;
        }
        public IActionResult Index()
        {
            var list = _context.diaries.ToList();
            list.Reverse();
            return View(list);
        }
        public IActionResult AddDiary()
        {
            if(_check.checkState(HttpContext)== false)
            {
                ViewBag.Attention = "Giriş Yapmadınız Gönderiniz Anonim Olacak";
            }
            return View(new DiaryManager());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddDiary(DiaryManager diary)
        {
            if (ModelState.IsValid)
            {
                diary.ipAdrr = HttpContext.Connection.RemoteIpAddress.ToString();
                Diary temp = diary;
                _context.diaries.Add(temp);
                if (HttpContext.User.Identity.IsAuthenticated == true)
                {
                    temp.author = _context.accounts.FirstOrDefault(user => user.username == HttpContext.User.Identity.Name);
                }
               _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Yazı En Az 50 Cümleden Oluşmalı";
            return View();
        }
        [HttpGet("@{username}")]
        public IActionResult Index(string username)
        {
            var user = _context.accounts.Include(user => user.diaries).FirstOrDefault(user => user.username == username);
            if (user == null)
            {
                return RedirectToAction("Index");
            }
            var list = user.diaries.Where(x => x.isPrivate == false);
            list.Reverse();
            return View(list);
        }
    }
}
