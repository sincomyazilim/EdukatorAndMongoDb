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
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }
        //-------------------------------------------------
        public void BCreateAsync(SocialMedia t)
        {
            _socialMediaDal.CreateAsync(t);
        }

        public void BDeleteAsync(string id)
        {
            _socialMediaDal.DeleteAsync(id);
        }

        public List<SocialMedia> BGetAllAsync()
        {
            return _socialMediaDal.GetAllAsync();
        }

        public SocialMedia BGetByIdAsync(string id)
        {
            return _socialMediaDal.GetByIdAsync(id);
        }

        public void BUpdateAsync(SocialMedia t)
        {
            _socialMediaDal.UpdateAsync(t);
        }
    }
}
