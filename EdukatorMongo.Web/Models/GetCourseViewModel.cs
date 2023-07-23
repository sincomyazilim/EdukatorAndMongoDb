using Edukator.DataAccessLayer.Dtos.CategoriesDto;
using System;

namespace EdukatorMongo.Web.Models
{
    public class GetCourseViewModel
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
