using AutoMapper;
using Edukator.DataAccessLayer.Catalog.Dtos.CategoriesDto;
using Edukator.DataAccessLayer.Catalog.Dtos.CoursesDto;
using Edukator.DataAccessLayer.Dtos.CategoriesDto;
using Edukator.DataAccessLayer.Dtos.CoursesDto;
using Edukator.EntityLayer.Concrete;

namespace Edukator.DataAccessLayer.Mapping
{
    public class GeneralMapping:Profile//21 maplama yapıyoruz
    {
        public GeneralMapping()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryCreateDto>().ReverseMap();
            CreateMap<Category, CategoryUpdateDto>().ReverseMap();

            CreateMap<Course,CourseDto>().ReverseMap();       
            CreateMap<Course, CourseCreateDto>().ReverseMap();
            CreateMap<Course, CourseUpdateDto>().ReverseMap();


         
        }
    }
}
