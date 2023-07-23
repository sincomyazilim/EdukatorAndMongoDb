using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
    public class SocialMedia : IMongoEntity
    {
       
        public string SocialMediaName { get; set; }
        public string SocialMediaIcon { get; set; }
        public string SocialMediaUrl { get; set; }
    }
    
}
