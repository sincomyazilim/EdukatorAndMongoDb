using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
    public class Map : IMongoEntity
    {
        
        public string Name { get; set; }
        public string MapUrl { get; set; }
    }
}
