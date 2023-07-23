using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Repository;
using Edukator.EntityLayer.Concrete;
using MongoDB.Driver;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfContactInfoDal : GenericRepository<ContactInfo>, IContactInfoDal
    {
        public EfContactInfoDal(IMongoDatabase mongoDatabase) : base(mongoDatabase)
        {
        }
    }
}
