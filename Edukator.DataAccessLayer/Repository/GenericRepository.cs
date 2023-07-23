using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Edukator.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : IMongoEntity
    {
        private readonly IMongoCollection<T> _collection;    

        //private readonly IMongoDatabase _mongoDatabase;
    


        public GenericRepository(IMongoDatabase mongoDatabase)
        {

            _collection = mongoDatabase.GetCollection<T>(typeof(T).Name.ToLowerInvariant());
            
        }

        //----------------------------------------------------------------------------
        public void CreateAsync(T t)
        {
            
             _collection.InsertOneAsync(t);
        }

        public  void DeleteAsync(string id)
        {
           _collection.FindOneAndDeleteAsync(x => x.Id == id);

        }

        public List<T> GetAllAsync()
        {
            return _collection.AsQueryable().ToList();
        }

        public T GetByIdAsync(string id)
        {
            return _collection.Find(x => x.Id == id).FirstOrDefault();
        }

        public void UpdateAsync(T t)
        {
            _collection.FindOneAndReplaceAsync(x => x.Id == t.Id, t);
        }
    }
}
