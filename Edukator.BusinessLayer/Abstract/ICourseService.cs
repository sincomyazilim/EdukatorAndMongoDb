using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edukator.DataAccessLayer.Catalog.Dtos.CoursesDto;
using Edukator.EntityLayer.Concrete;

namespace Edukator.BusinessLayer.Abstract
{
    public interface ICourseService:IGenericService<Course>
    {//13
        Task<List<CourseDto>> GetCourseWithCategory();
        //public List<Course> BGetLast5Course();
    }
}
