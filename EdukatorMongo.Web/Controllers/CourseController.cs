using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace EdukatorMongo.Web.Controllers
{
    
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly ICategoryService _categoryService;

        public CourseController(ICourseService courseService, ICategoryService categoryService)
        {
            _courseService = courseService;
            _categoryService = categoryService;
        }
        //-----------------------------
        public IActionResult Index()
        {
            var values = _courseService.BGetAllAsync();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCourse()
        {
            List<SelectListItem> values = (from x in _categoryService.BGetAllAsync()
                                           select new SelectListItem()
                                           {
                                               Text = x.Name,
                                               Value = x.Id.ToString()

                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddCourse(Course course)
        {

            _courseService.BCreateAsync(course);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCourse(string id)
        {
            var values = _courseService.BGetByIdAsync(id);
            _courseService.BDeleteAsync(values.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCourse(string id)
        {
            List<SelectListItem> values = (from x in _categoryService.BGetAllAsync()
                                           select new SelectListItem()
                                           {
                                               Text = x.Name,
                                               Value = x.Id.ToString()

                                           }).ToList();
            ViewBag.v = values;
            var value = _courseService.BGetByIdAsync(id);


            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCourse(Course course)
        {

            _courseService.BUpdateAsync(course);
            return RedirectToAction("Index");
        }
    }
}
