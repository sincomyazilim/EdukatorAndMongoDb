using Edukator.DataAccessLayer.Abstract;

using Edukator.DataAccessLayer.Repository;
using Edukator.EntityLayer.Concrete;
using MongoDB.Driver;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfAboutUsImageDal : GenericRepository<AboutUsImage>, IAboutUsImageDal
    {
        public EfAboutUsImageDal(IMongoDatabase mongoDatabase) : base(mongoDatabase)
        {
        }
    }
}
