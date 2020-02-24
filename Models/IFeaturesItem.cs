using System.Linq;

namespace IParse.Models
{
    public interface IFeaturesItem
    {
        public IQueryable<FeaturesItem> FeaturesItems { get; }
    }
}