﻿namespace Edukator.DataAccessLayer.Dtos.CoursesDto
{
    public class CourseCreateDto//21
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string UserId { get; set; }
        public string Picture { get; set; }

        
        public string CategoryId { get; set; }
    }
}
