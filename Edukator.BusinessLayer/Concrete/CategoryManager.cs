using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Catalog.Dtos.CoursesDto;
using Edukator.DataAccessLayer.Dtos.CoursesDto;
using Edukator.EntityLayer.Concrete;
using FreeCourse.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {//11
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        //----------------------------------------------------------
        public void BCreateAsync(Category t)
        {
            _categoryDal.CreateAsync(t);
        }

        public void BDeleteAsync(string id)
        {
            _categoryDal.DeleteAsync(id);
        }

        public List<Category> BGetAllAsync()
        {
            return _categoryDal.GetAllAsync();
        }

        public Category BGetByIdAsync(string id)
        {
            return _categoryDal.GetByIdAsync(id);
        }

        public void BUpdateAsync(Category t)
        {
            _categoryDal.UpdateAsync(t);
        }
    }
}
