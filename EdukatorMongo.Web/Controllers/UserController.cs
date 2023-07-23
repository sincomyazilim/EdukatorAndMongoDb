using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EdukatorMongo.Web.Controllers
{
    public class UserController : Controller
    {
        private UserManager<ApplicationUser> _userManager;

        public UserController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        //--------------------------------------------------------------
        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            var values = _userManager.Users.ToList();

            return View(values);
        }





        [HttpGet]
        [AllowAnonymous]
        public IActionResult Create()
        {
            return View();
        }
        public async Task<ActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser appUser = new ApplicationUser
                {
                    UserName=user.Name, 
                    Email=user.Email,   
                    
                };
                IdentityResult result=await _userManager.CreateAsync(appUser,user.Password);
                if (result.Succeeded)
                {
                    ViewBag.Message = "Yeni Kullanıcı eklendi";
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
               
            }
            return View(user);
        }
    }
}