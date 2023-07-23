using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edukator.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Dashboard
{
    public class _DashboradStatisticPartial: ViewComponent
    {
        private Context context = new Context();
        public IViewComponentResult Invoke()
        {
            //ViewBag.totalCouserCount = context.Courses.Count();
            //ViewBag.totalCouserCategory = context.Categories.Count();
            //ViewBag.totalMemberCount = context.Users.Count();
            //ViewBag.messageBoxCount = context.Contacts.Count();
            return View();
        }
    }
}
