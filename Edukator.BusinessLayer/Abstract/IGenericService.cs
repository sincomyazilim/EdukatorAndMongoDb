using Edukator.DataAccessLayer.Catalog.Dtos.CoursesDto;
using Edukator.DataAccessLayer.Dtos.CoursesDto;
using FreeCourse.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T:class
    {
        List<T> BGetAllAsync();
        T BGetByIdAsync(string id);
        void BCreateAsync(T t);
        void BUpdateAsync(T t);
        void BDeleteAsync(string id);
    }
}
