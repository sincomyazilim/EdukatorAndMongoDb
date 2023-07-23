using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EdukatorMongo.Web.Controllers
{
   
    public class AdminLayoutControllerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PartialHead()
        {
            return PartialView();
        }
        public IActionResult PartialSpiner()
        {
            return PartialView();
        }
        public IActionResult PartialsideBar()
        {
            return PartialView();
        }
        public IActionResult PartialNavbar()
        {
            return PartialView();
        }


        public IActionResult PartialFooter()
        {
            return PartialView();
        }
        public IActionResult PartialScript()
        {
            return PartialView();
        }
    }
}
