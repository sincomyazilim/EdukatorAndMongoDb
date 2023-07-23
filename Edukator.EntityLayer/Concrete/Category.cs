using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Edukator.EntityLayer.Concrete
{
    public class Category: IMongoEntity
    {
       
        public string Name { get; set; }
    }
}
