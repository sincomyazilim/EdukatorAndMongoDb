using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
    public class Feature : IMongoEntity
    {
       
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string VideoUrl { get; set; }
    }
}
