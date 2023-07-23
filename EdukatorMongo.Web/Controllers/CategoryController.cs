using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EdukatorMongo.Web.Controllers
{
    
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryservice;

        public CategoryController(ICategoryService categoryservice)
        {
            _categoryservice = categoryservice;
        }


        //---------------------------------------------------
        public  IActionResult Index()
        {
            var values = _categoryservice.BGetAllAsync();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category course)
        {
            _categoryservice.BCreateAsync(course);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(string id)
        {
            var values = _categoryservice.BGetByIdAsync(id);
            _categoryservice.BDeleteAsync(values.Id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCategory(string id)
        {
            var values = _categoryservice.BGetByIdAsync(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryservice.BUpdateAsync(category);
            return RedirectToAction("Index");
        }
    }
}
