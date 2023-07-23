using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EdukatorMongo.Web.Controllers
{
    
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        //----------------------------------------------------------
        public IActionResult Index()
        {
            var values = _serviceService.BGetAllAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Add(Service t)
        {
            _serviceService.BCreateAsync(t);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(string id)
        {
            var values = _serviceService.BGetByIdAsync(id);
            _serviceService.BDeleteAsync(values.Id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(string id)
        {
            var values = _serviceService.BGetByIdAsync(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Update(Service t)
        {
            _serviceService.BUpdateAsync(t);
            return RedirectToAction("Index");
        }
    }
}
