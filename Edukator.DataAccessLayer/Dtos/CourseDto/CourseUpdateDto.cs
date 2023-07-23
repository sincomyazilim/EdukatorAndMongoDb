namespace Edukator.DataAccessLayer.Catalog.Dtos.CoursesDto
{
    public class CourseUpdateDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string UserId { get; set; }
        public string Picture { get; set; }

       
        public string CategoryId { get; set; }
    }
}
