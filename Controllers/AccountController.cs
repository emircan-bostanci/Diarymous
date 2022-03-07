using Diarymous.Models;
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
        public AccountController(Context context, ClaimsManager claimsManager, ICheck check)
        {
            _check = check;
            _context = context;
            this.claimsManager = claimsManager;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult Login()
        {
            if (_check.checkState(HttpContext) == true)
            {
                return RedirectToAction("Home","Index");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AccountManager accountManager)
        {
            if (_check.checkState(HttpContext) == true)
            {
                return RedirectToAction("Home","Index");
            }
            if (ModelState.IsValid && _check.checkState(HttpContext) == false)
            {
                if (_context.accounts.FirstOrDefault(user => user.username == accountManager.username && user.password == accountManager.password) == null)
                {
                    ViewBag.Message = "Kullanıcı Adı veya Şifre Yanlış";
                    return View();
                }
                await HttpContext.SignInAsync(claimsManager.getClaim(accountManager.username));
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public IActionResult Register()
        {
            if (_check.checkState(HttpContext) == true)
            {
                return RedirectToAction("Home","Index");
            }
            return View(new AccountManager());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(AccountManager accountManager)
        {
            if (_check.checkState(HttpContext) == true)
            {
                return RedirectToAction("Home","Index");
            }
            if (ModelState.IsValid)
            {
                if (await _context.accounts.FirstOrDefaultAsync(user => user.username == accountManager.username) == null)
                {
                    _context.accounts.Add(accountManager);
                    _context.SaveChanges();
                    await HttpContext.SignInAsync(claimsManager.getClaim(accountManager.username));
                    return RedirectToAction("Profile");
                }
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            if (_check.checkState(HttpContext) == true)
            {
                await HttpContext.SignOutAsync();
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Login");
        }
    }
}
