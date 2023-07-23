using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EdukatorMongo.Web.Controllers
{
    
    public class RoleController : Controller
    {
        private readonly RoleManager<ApplicationRole> _roleManager;

        public RoleController(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }
        //--------------------------------------------------------------------------
        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(ApplicationRole appRole)
        {
            var result = await _roleManager.CreateAsync(appRole);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteRole(Guid id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            await _roleManager.DeleteAsync(value);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateRole(Guid id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(ApplicationRole appRole)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == appRole.Id);
            value.Name = appRole.Name;
            await _roleManager.UpdateAsync(value);

            return RedirectToAction("Index");
        }
    }
}
