using MultiShop.Business.Services.Abstract;
using MultiShop.Business.Services.Exceptions;
using MultiShop.Core.Models;
using MultiShop.Core.RepositoryAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Business.Services.Concretes
{
    public class FeatureService : IFeatureService
    {
        private readonly IFeatureRepository _featureRepository;
        public FeatureService(IFeatureRepository featureRepository)
        {
            _featureRepository = featureRepository;
        }
        public void AddFeature(Feature feature)
        {
            if (!_featureRepository.GetAll().Any(x => x.Title == feature.Title))
            {
                _featureRepository.Add(feature);
                _featureRepository.Commit();
            }
            else
                throw new DuplicateExceptions("Bele bir feature yoxdur!");
        }

        public void DeleteFeature(int id)
        {
             var exsistFeature = _featureRepository.Get(x => x.Id == id);
            if (exsistFeature == null) throw new NullReferenceException("Feature Yoxdur");
            _featureRepository.Delete(exsistFeature);
            _featureRepository.Commit();

        }


        public Feature GetFeature(Func<Feature, bool>? func = null)
        {
            return _featureRepository.Get(func);
        }
        public List<Feature> GetAllFeatures(Func<Feature, bool>? func = null)
        {
            return _featureRepository.GetAll(func);
        }

        public void UpdateFeature(Feature newFeature, int id)
        {
             var oldFeature = _featureRepository.Get(x=>x.Id== id);
            if (oldFeature == null) throw new NullReferenceException("Feature yoxdur!");
            oldFeature.Title = newFeature.Title;
            oldFeature.Icon= newFeature.Icon;
        }

       
    }
}
