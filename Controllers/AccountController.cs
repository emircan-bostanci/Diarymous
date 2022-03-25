using Diarymous.Models;
using Diarymous.Models.Entities;
using Diarymous.Models.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Diarymous.Controllers
{
    public class AccountController : Controller
    {
        private readonly Context _context;
        private readonly ClaimsManager claimsManager;
        private readonly ICheck _check;
        private readonly ICiphering _ciphering;
        public AccountController(Context context, ClaimsManager claimsManager, ICheck check,ICiphering ciphering)
        {
            _check = check;
            _context = context;
            _ciphering = ciphering;
            this.claimsManager = claimsManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            if (_check.checkState(HttpContext.User) == true)
            {
                return RedirectToAction("Home","Index");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Account account)
        {
            if (_check.checkState(HttpContext.User) == true) {
                return RedirectToAction("Home","Index");
            }
            if (ModelState.IsValid && _check.checkState(HttpContext.User) == false)
            {
                if (_context.accounts.FirstOrDefault(user => user.username == account.username && user.password == _ciphering.encrypter(_ciphering.generateSaltedString(account.password,account.username))) == null)
                {
                    ModelState.AddModelError("pass","Kullanıcı Adı veya Şifre Yanlış");
                    return View();
                }
                await HttpContext.SignInAsync(claimsManager.getClaim(account.username));
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public IActionResult Register()
        {
            if (_check.checkState(HttpContext.User) == true)
            {
                return RedirectToAction("Home","Index");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(Account account)
        {
            account.password = _ciphering.encrypter(_ciphering.generateSaltedString(account.password,account.username));
            if (_check.checkState(HttpContext.User) == true)
            {
                return RedirectToAction("Home","Index");
            }
            if (ModelState.IsValid)
            {
                if (await _context.accounts.FirstOrDefaultAsync(user => user.username == account.username) == null)
                {
                    _context.accounts.Add(account);
                    _context.SaveChanges();
                 
                    await HttpContext.SignInAsync(claimsManager.getClaim(account.username));
                    return RedirectToAction("Profile","Index");
                }
                 
                 ModelState.AddModelError("pass","Böyle bir kullanıcı zaten var!");
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            if (_check.checkState(HttpContext.User) == true)
            {
                await HttpContext.SignOutAsync();
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Login");
        }
    }
}
