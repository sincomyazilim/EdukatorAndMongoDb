using AutoMapper;
using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Catalog.Dtos.CoursesDto;
using Edukator.DataAccessLayer.Repository;
using Edukator.EntityLayer.Concrete;
using FreeCourse.Shared.Dtos;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfCourseDal : GenericRepository<Course>, ICourseDal
    {
        private readonly IMongoCollection<Course> _courseCollection;
        private readonly IMongoCollection<Category> _categoryCollection;
        private readonly IMapper _mapper;
        public EfCourseDal(IMongoDatabase mongoDatabase, IMapper mapper) : base(mongoDatabase)
        {

            _courseCollection = mongoDatabase.GetCollection<Course>("course");
            _categoryCollection = mongoDatabase.GetCollection<Category>("category");
            _mapper = mapper;
        }

        public async Task<List<CourseDto>> GetCourseWithCategory()
        {
            var courses = await _courseCollection.Find(course => true).ToListAsync();
            if (courses.Any())
            {
                foreach (var item in courses)
                {
                    item.Category = await _categoryCollection.Find(x => x.Id == item.CategoryId).FirstAsync();
                }
            }
            else
            {
                courses = new List<Course>();
            }
            
            return _mapper.Map<List<CourseDto>>(courses);

       
        }

        

        //public List<Course> GetLast5Course()
        //{
        //    Context context = new Context();
        //    return context.Courses.OrderByDescending(x => x.CourseId).Take(5).ToList();
        //}

    }
}
