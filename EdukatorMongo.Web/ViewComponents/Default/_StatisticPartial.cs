using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace Edukator.PresentationLayer.ViewComponents.Default
{
    public class _StatisticPartial:ViewComponent
    {
      private readonly ICourseService _courseService;

        public _StatisticPartial(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = 19;
            ViewBag.v2 = 52;
            ViewBag.v3 = 63;
            return View();
        }
    }
}

