using System.Linq;

namespace IParse.Models
{
    public interface IClientCarouselRepository
    {
        IQueryable<ClientCarousel> ClientCarousels { get; }
    }
}