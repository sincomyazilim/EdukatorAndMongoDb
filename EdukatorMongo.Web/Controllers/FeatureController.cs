using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EdukatorMongo.Web.Controllers
{
   
    public class FeatureController : Controller
    {
        private readonly IFeatureService _featureService;

        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }
        //-------------------------------------------------------
        public IActionResult Index()
        {
            var values = _featureService.BGetAllAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Add(Feature t)
        {
            _featureService.BCreateAsync(t);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(string id)
        {
            var values = _featureService.BGetByIdAsync(id);
            _featureService.BDeleteAsync(values.Id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(string id)
        {
            var values = _featureService.BGetByIdAsync(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Update(Feature t)
        {
            _featureService.BUpdateAsync(t);
            return RedirectToAction("Index");
        }
    }
}
