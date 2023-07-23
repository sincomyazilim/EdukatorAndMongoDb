using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
    public class CourseRegister : IMongoEntity
    {
      
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int AppUserId { get; set; }
        public AppUser1 AppUser { get; set; }
    }
}
