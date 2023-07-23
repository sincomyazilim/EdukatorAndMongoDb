using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EdukatorMongo.Web.Controllers
{
   
    public class AboutUsImageController : Controller
    {
        private readonly IAboutUsImageService _aboutUsImageService;

        public AboutUsImageController(IAboutUsImageService aboutUsImageService)
        {
            _aboutUsImageService = aboutUsImageService;
        }
        //--------------------------------------------------------------------
        public IActionResult Index()
        {
            var values = _aboutUsImageService.BGetAllAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Add(AboutUsImage t)
        {
            _aboutUsImageService.BCreateAsync(t);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(string id)
        {
            var values = _aboutUsImageService.BGetByIdAsync(id);
            _aboutUsImageService.BDeleteAsync(values.Id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(string id)
        {
            var values = _aboutUsImageService.BGetByIdAsync(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Update(AboutUsImage t)
        {
            _aboutUsImageService.BUpdateAsync(t);
            return RedirectToAction("Index");
        }
    }
}
