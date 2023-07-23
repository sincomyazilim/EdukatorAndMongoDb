using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Repository;
using Edukator.EntityLayer.Concrete;
using MongoDB.Driver;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfAboutGridDal : GenericRepository<AboutGrid>, IAboutGridDal
    {
        public EfAboutGridDal(IMongoDatabase mongoDatabase) : base(mongoDatabase)
        {
        }
    }
}
