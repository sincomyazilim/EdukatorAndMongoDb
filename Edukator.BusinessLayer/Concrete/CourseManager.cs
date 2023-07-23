using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Catalog.Dtos.CoursesDto;
using Edukator.DataAccessLayer.Dtos.CoursesDto;
using Edukator.EntityLayer.Concrete;
using FreeCourse.Shared.Dtos;

namespace Edukator.BusinessLayer.Concrete
{
    public class CourseManager : ICourseService
    {//11
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        //-------------------------------------------------------------
      

        public void BCreateAsync(Course t)
        {
           _courseDal.CreateAsync(t);
        }

        public void BDeleteAsync(string id)
        {
            _courseDal.DeleteAsync(id);
        }

        

        public List<Course> BGetAllAsync()
        {
           return _courseDal.GetAllAsync();
        }

        public Course BGetByIdAsync(string id)
        {
            return _courseDal.GetByIdAsync(id);
        }

        public void BUpdateAsync(Course t)
        {
            _courseDal.UpdateAsync(t);
        }

        public Task<List<CourseDto>> GetCourseWithCategory()
        {
           return _courseDal.GetCourseWithCategory();
        }
    }
}
