using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EdukatorMongo.Web.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly ISubscribeService _subscribeService;

        public DefaultController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }
        //------------------------------------------------------------------------
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult AddSubscribe()
        {
            return PartialView();

        }
        [HttpPost]
        public IActionResult AddSubscribe(Subscribe subscribe)
        {
            _subscribeService.BCreateAsync(subscribe);
            return RedirectToAction("Index", "Default");
        }

        public IActionResult GetSubscribe()
        {
            
            return View(_subscribeService.BGetAllAsync());
        }
    }
}
