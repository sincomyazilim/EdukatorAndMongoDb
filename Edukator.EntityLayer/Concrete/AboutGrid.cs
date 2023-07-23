﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
   public class AboutGrid:IMongoEntity
    {
        
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
