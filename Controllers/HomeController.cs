using Diarymous.Models;
using Diarymous.Models.Entities;
using Diarymous.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diarymous.Controllers
{
    public class HomeController :Controller
    {    
        private readonly Context _context;
        private readonly ICheck _check;
        private readonly LikeManager _likeManager;
        public HomeController(Context context,ICheck check,LikeManager likeManager)
        {
            _check = check;
            _likeManager = likeManager;
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.ProfileName = _check.checkState(HttpContext.User) == false ? "Anonim" : HttpContext.User.Identity.Name;

            var list = _context.diaries.Include(diary=>diary.author).ToList();
            list.Reverse();
            return View(list);
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
        [HttpGet]
        public IActionResult Diary(int id)
        {
            ViewBag.like = false;
            var diary = _context.diaries.FirstOrDefault(diary => diary.id == id);
            IActionResult result = diary == null ? RedirectToAction("index"):View(diary);
            if(_check.checkState(HttpContext.User) == true)
            {
               var user= _context.accounts.Include(user => user.likedPosts).FirstOrDefault(user => user.username == HttpContext.User.Identity.Name);
                if(user.likedPosts.FirstOrDefault(post => post.id == id)!= null)
                {
                    ViewBag.like = true;
                }
            }
            return result;
        }
        [HttpPost]
        public IActionResult Diary(int id,int likeId) {
            var diary = _context.diaries.FirstOrDefault(diary => diary.id == id);
           if(_check.checkState(HttpContext.User) == true)
            {
                var user = _context.accounts.Include(_=>_.likedPosts).FirstOrDefault(user => user.username == HttpContext.User.Identity.Name);
                var isLiked = _likeManager.likeChecker(true, diary, user);
                _likeManager.like(isLiked,_context , diary, user);
           }
            
            return View(diary);
        } 
        public IActionResult AddDiary()
        {
            if(_check.checkState(HttpContext.User)== false)
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
      
    }
}
