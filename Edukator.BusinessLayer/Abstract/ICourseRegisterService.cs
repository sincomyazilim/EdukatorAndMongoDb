using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edukator.EntityLayer.Concrete;

namespace Edukator.BusinessLayer.Abstract
{
    public interface ICourseRegisterService:IGenericService<CourseRegister>
    {
        //List<CourseRegister> BCourseRegisterListWithCoursesAndUsers();
        //List<CourseRegister> BCourseRegisterListWithCourseByUser(int id);
    }
}
