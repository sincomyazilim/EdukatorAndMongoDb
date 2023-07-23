using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Catalog.Dtos.CoursesDto;
using Edukator.DataAccessLayer.Dtos.CoursesDto;
using Edukator.EntityLayer.Concrete;
using FreeCourse.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Concrete
{
    public class CourseRegisterManager : ICourseRegisterService
    {
        private readonly ICourseRegisterService _courseRegisterService;

        public CourseRegisterManager(ICourseRegisterService courseRegisterService)
        {
            _courseRegisterService = courseRegisterService;
        }
        //-----------------------------------------------
        public void BCreateAsync(CourseRegister t)
        {
            _courseRegisterService.BCreateAsync(t);
        }

        public void BDeleteAsync(string id)
        {
            _courseRegisterService.BDeleteAsync(id);
        }

        public List<CourseRegister> BGetAllAsync()
        {
            return _courseRegisterService.BGetAllAsync();
        }

        public CourseRegister BGetByIdAsync(string id)
        {
            return _courseRegisterService.BGetByIdAsync(id);
        }

        public void BUpdateAsync(CourseRegister t)
        {
            _courseRegisterService.BUpdateAsync(t);
        }
    }
}
