using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EdukatorMongo.Web.Controllers
{
    
    public class AboutGridController : Controller
    {
        private readonly IAboutGridService _aboutGridService;

        public AboutGridController(IAboutGridService aboutGridService)
        {
            _aboutGridService = aboutGridService;
        }
        //----------------------------------------------------------
        public IActionResult Index()
        {
            var values = _aboutGridService.BGetAllAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAboutGrid()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddAboutGrid(AboutGrid t)
        {
            _aboutGridService.BCreateAsync(t);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAboutGrid(string id)
        {
            var values = _aboutGridService.BGetByIdAsync(id);
            _aboutGridService.BDeleteAsync(values.Id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateAboutGrid(string id)
        {
            var values = _aboutGridService.BGetByIdAsync(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAboutGrid(AboutGrid t)
        {
            _aboutGridService.BUpdateAsync(t);
            return RedirectToAction("Index");
        }
    }
}
