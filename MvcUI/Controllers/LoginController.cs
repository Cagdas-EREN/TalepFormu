using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MvcUI.Models;

namespace MvcUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel userSignInView)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(userSignInView.username, userSignInView.password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Add", "KayitFormu");
                }
                else
                {
                    return RedirectToAction("Index", "Login");
                }
            }

            return View();

        }
    }
}
