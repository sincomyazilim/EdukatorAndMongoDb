using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Repository;
using Edukator.EntityLayer.Concrete;
using MongoDB.Driver;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {//11
        public EfCategoryDal(IMongoDatabase mongoDatabase) : base(mongoDatabase)
        {
        }
    }
}
