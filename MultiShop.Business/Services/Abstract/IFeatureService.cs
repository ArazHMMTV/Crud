using MultiShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Business.Services.Abstract
{
    public interface IFeatureService
    {
        void AddFeature(Feature feature);
        void DeleteFeature(int id);

        void UpdateFeature(Feature newFeature, int id);

        Feature GetFeature(Func<Feature, bool>? func = null);
        List<Feature> GetAllFeatures(Func<Feature, bool>? func = null);
       
    }
}
