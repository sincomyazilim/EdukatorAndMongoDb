using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edukator.EntityLayer.Concrete;

namespace Edukator.DataAccessLayer.Abstract
{
    public interface ICourseRegisterDal:IGenericDal<CourseRegister>
    {
        //List<CourseRegister> CourseRegisterListWithCoursesAndUsers();
        //List<CourseRegister> CourseRegisterListWithCourseByUser(int id);
    }
}
