using Edukator.EntityLayer.Concrete;
using EdukatorMongo.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace EdukatorMongo.Web.Controllers
{

    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        //--------------------------------------------------
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser findUser = await _userManager.FindByNameAsync(model.Name);
                if (findUser != null)
                {
                    Microsoft.AspNetCore.Identity.SignInResult result  =await _signInManager.PasswordSignInAsync(model.Name, model.Password,false,false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Course");
                    }
                }
                ModelState.AddModelError(nameof(model.Name), "Giriş Hatalı:Kullanıcı Adı veya Şifre Yanlış");

            }


            return View();
        }
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","Default");
        }
    }
}
