using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Repository;
using Edukator.EntityLayer.Concrete;
using MongoDB.Driver;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        //public List<Contact> GetLast3Message()
        //{
        //    using var context = new Context();

        //        var values = context.Contacts.OrderByDescending(x => x.ContactId).Take(3).ToList();
        //        return values;

        //}
        public EfContactDal(IMongoDatabase mongoDatabase) : base(mongoDatabase)
        {
        }
    }
}
