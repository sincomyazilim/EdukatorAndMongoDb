using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Repository;
using Edukator.EntityLayer.Concrete;
using MongoDB.Driver;

namespace Edukator.DataAccessLayer.EntityFramework
{

    public class EFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EFeatureDal(IMongoDatabase mongoDatabase) : base(mongoDatabase)
        {
        }
    }
}
