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
    public class AboutUsImageManager : IAboutUsImageService
    {

        private readonly IAboutUsImageDal _aboutUsDal;

        public AboutUsImageManager(IAboutUsImageDal aboutUsDal)
        {
            _aboutUsDal = aboutUsDal;
        }
        //----------------------------------------------------
        public void BCreateAsync(AboutUsImage t)
        {
            _aboutUsDal.CreateAsync(t);
        }

        public void BDeleteAsync(string id)
        {
           _aboutUsDal.DeleteAsync(id);
        }

        public List<AboutUsImage> BGetAllAsync()
        {
            return _aboutUsDal.GetAllAsync();
        }

        public AboutUsImage BGetByIdAsync(string id)
        {
            return _aboutUsDal.GetByIdAsync(id);
        }

        public void BUpdateAsync(AboutUsImage t)
        {
            _aboutUsDal.UpdateAsync(t);
        }
    }
}
