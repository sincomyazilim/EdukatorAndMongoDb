using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edukator.DataAccessLayer.Catalog.Dtos.CoursesDto;
using Edukator.EntityLayer.Concrete;

namespace Edukator.DataAccessLayer.Abstract
{
    public interface ICourseDal: IGenericDal<Course>
    {//10-13

        Task<List<CourseDto>> GetCourseWithCategory();
        //List<Course> GetLast5Course();

    }
}
