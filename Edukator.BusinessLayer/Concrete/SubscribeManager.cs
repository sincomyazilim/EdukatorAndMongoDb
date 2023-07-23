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
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }
        //----------------------------------------------------
        public void BCreateAsync(Subscribe t)
        {
           _subscribeDal.CreateAsync(t);
        }

        public void BDeleteAsync(string id)
        {
            _subscribeDal.DeleteAsync(id);
        }

        public List<Subscribe> BGetAllAsync()
        {
           return _subscribeDal.GetAllAsync();
        }

        public Subscribe BGetByIdAsync(string id)
        {
          return  _subscribeDal.GetByIdAsync(id);
        }

        public void BUpdateAsync(Subscribe t)
        {
            _subscribeDal.UpdateAsync(t);
        }
    }
}
