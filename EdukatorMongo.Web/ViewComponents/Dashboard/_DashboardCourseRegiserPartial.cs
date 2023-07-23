using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Dashboard
{ 
    
    public class _DashboardCourseRegiserPartial:ViewComponent
    {
        private readonly ICourseRegisterService _courseRegisterService;

        public _DashboardCourseRegiserPartial(ICourseRegisterService courseRegisterService)
        {
            _courseRegisterService = courseRegisterService;
        }
        //----------------------------
        public IViewComponentResult Invoke()
        {
            //var values = _courseRegisterService.BCourseRegisterListWithCoursesAndUsers();
            return View();
        }
    }
}
