using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Catalog.Dtos.CoursesDto;
using Edukator.DataAccessLayer.Dtos.CoursesDto;
using Edukator.EntityLayer.Concrete;
using FreeCourse.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }
        //------------------------------------
        public void BCreateAsync(Feature t)
        {
            _featureDal.CreateAsync(t);
        }

        public void BDeleteAsync(string id)
        {
            _featureDal.DeleteAsync(id);
        }

        public List<Feature> BGetAllAsync()
        {
           return _featureDal.GetAllAsync();    
        }

        public Feature BGetByIdAsync(string id)
        {
            return _featureDal.GetByIdAsync(id);
        }

        public void BUpdateAsync(Feature t)
        {
            _featureDal.UpdateAsync(t);
        }
    }
}
