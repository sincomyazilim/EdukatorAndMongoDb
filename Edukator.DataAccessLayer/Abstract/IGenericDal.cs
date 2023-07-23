using Edukator.DataAccessLayer.Catalog.Dtos.CoursesDto;
using Edukator.DataAccessLayer.Dtos.CoursesDto;
using Edukator.EntityLayer.Concrete;
using FreeCourse.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T: IMongoEntity
    {
         List<T> GetAllAsync();
        T GetByIdAsync(string id);      
        void  CreateAsync(T t);
        void UpdateAsync(T t);
        void DeleteAsync(string id);
    }
}
