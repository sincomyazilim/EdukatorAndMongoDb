using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }
        //---------------------------------------------------------
        public void BCreateAsync(Service t)
        {
            _serviceDal.CreateAsync(t);
        }

        public void BDeleteAsync(string id)
        {
            _serviceDal.DeleteAsync(id);
        }

        public List<Service> BGetAllAsync()
        {
            return _serviceDal.GetAllAsync();
        }

        public Service BGetByIdAsync(string id)
        {
            return _serviceDal.GetByIdAsync(id);
        }

        public void BUpdateAsync(Service t)
        {
            _serviceDal.UpdateAsync(t);
        }
    }
}
