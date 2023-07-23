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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        //--------------------------------------------------------------
        public void BCreateAsync(Contact t)
        {
            _contactDal.CreateAsync(t);
        }

        public void BDeleteAsync(string id)
        {
            _contactDal.DeleteAsync(id);
        }

        public List<Contact> BGetAllAsync()
        {
            return _contactDal.GetAllAsync();
        }

        public Contact BGetByIdAsync(string id)
        {
            return _contactDal.GetByIdAsync(id);
        }

        

        public void BUpdateAsync(Contact t)
        {
            _contactDal.UpdateAsync(t);
        }
    }
}
