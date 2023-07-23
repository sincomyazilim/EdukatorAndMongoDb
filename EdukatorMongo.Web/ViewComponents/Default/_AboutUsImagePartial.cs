using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Default
{
    public class _AboutUsImagePartial:ViewComponent
    {
        private readonly IAboutUsImageService _aboutUsImageService;

        public _AboutUsImagePartial(IAboutUsImageService aboutUsImageService)
        {
            _aboutUsImageService = aboutUsImageService;
        }


        //-------------------------------------------
        public IViewComponentResult Invoke()
        {
            var values = _aboutUsImageService.BGetAllAsync();
            return View(values);
        }
    }
}
