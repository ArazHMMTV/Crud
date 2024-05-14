using MultiShop.Core.Models;
using MultiShop.Core.RepositoryAbstract;
using MultiShop.Data.DAL;
using MultiShop.Data.RepositoryAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Data.RepositoyConcerets
{
    public class FeatureRepository : GenericRepository<Feature>, IFeatureRepository
    {
        public FeatureRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
