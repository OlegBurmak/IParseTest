using System.Linq;

namespace IParse.Models
{
    public interface IDataCounter
    {
        public IQueryable<DataCounter> DataCounters { get; }
    }
}