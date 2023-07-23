using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Dashboard
{
    public class DashboardGetLast3CcontactMessage : ViewComponent
    {
        private readonly IContactService _contactService;

        public DashboardGetLast3CcontactMessage(IContactService contactService)
        {
            _contactService = contactService;
        }


        //------------------------------------------------
        public IViewComponentResult Invoke()
        {
            //var values = _contactService.BGetLast3Message();
            return View();
        }
    }
}
