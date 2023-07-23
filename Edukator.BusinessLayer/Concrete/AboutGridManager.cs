using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Catalog.Dtos.CoursesDto;
using Edukator.DataAccessLayer.Dtos.CoursesDto;
using Edukator.EntityLayer.Concrete;
using FreeCourse.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Concrete
{
    public class AboutGridManager : IAboutGridService
    {
        private readonly IAboutGridDal _aboutGridDal;

        public AboutGridManager(IAboutGridDal aboutGridDal)
        {
            _aboutGridDal = aboutGridDal;
        }
        //-------------------------------------------------
        public void BCreateAsync(AboutGrid t)
        {
            _aboutGridDal.CreateAsync(t);
        }

        public void BDeleteAsync(string id)
        {
            _aboutGridDal.DeleteAsync(id);
        }

        public List<AboutGrid> BGetAllAsync()
        {
            return _aboutGridDal.GetAllAsync();
        }

        public AboutGrid BGetByIdAsync(string id)
        {
           return _aboutGridDal.GetByIdAsync(id);
        }

        public void BUpdateAsync(AboutGrid t)
        {
            _aboutGridDal.UpdateAsync(t);
        }
    }
}
