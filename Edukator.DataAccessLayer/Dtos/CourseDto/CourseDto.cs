

using Edukator.DataAccessLayer.Dtos.CategoriesDto;
using System;

namespace Edukator.DataAccessLayer.Catalog.Dtos.CoursesDto
{
    public class CourseDto//21
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; }
        public string UserId { get; set; }
        public string Picture { get; set; }
        public DateTime CreatedTime { get; set; }

        
        public string CategoryId { get; set; }
        public CategoryDto Category { get; set; }
    }
}
