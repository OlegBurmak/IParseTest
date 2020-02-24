using System.Linq;

namespace IParse.Models
{
    public interface IGuttersItem
    {
        public IQueryable<GuttersItem> GuttersItems { get; }
    }
}