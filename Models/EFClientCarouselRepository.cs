using System.Linq;

namespace IParse.Models
{
    public class EFClientCarouselRepository : IClientCarouselRepository
    {
        
        private ApplicationDbContext context;

        public EFClientCarouselRepository(ApplicationDbContext appContext)
        {
            context = appContext;
        }
        public IQueryable<ClientCarousel> ClientCarousels => context.ClientCarousels;
    }
}