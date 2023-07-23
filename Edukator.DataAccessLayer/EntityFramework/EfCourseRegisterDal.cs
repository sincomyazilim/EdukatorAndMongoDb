using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Repository;
using Edukator.EntityLayer.Concrete;
using MongoDB.Driver;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfCourseRegisterDal : GenericRepository<CourseRegister>, ICourseRegisterDal
    {

        //public List<CourseRegister> CourseRegisterListWithCourseByUser(int id)
        //{
        //    using var context = new Context();
        //    var values = context.CourseRegisters.Where(x => x.AppUserId == id).Include(x => x.Course).ToList();
        //    return values;
        //}

        //public List<CourseRegister> CourseRegisterListWithCoursesAndUsers()
        //{
        //    using var context = new Context();
        //    var values = context.CourseRegisters.Include(x => x.Course).Include(y => y.AppUser).ToList();
        //    return values;
        //}
        public EfCourseRegisterDal(IMongoDatabase mongoDatabase) : base(mongoDatabase)
        {
        }
    }
}
