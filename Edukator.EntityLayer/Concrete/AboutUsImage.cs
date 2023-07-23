using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
    public class AboutUsImage : IMongoEntity
    {
      
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageTitle1 { get; set; }

        public string ImageUrl2 { get; set; }
        public string ImageTitle2 { get; set; }

        public string ImageUrl3 { get; set; }
        public string ImageTitle3 { get; set; }
        public string ImageUrl4 { get; set; }
        public string ImageTitle4 { get; set; }

    }
}
