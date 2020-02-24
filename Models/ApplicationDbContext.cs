using Microsoft.EntityFrameworkCore;

namespace IParse.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<ClientCarousel> ClientCarousels { get; set; }
        public DbSet<RequestQuestion> RequestQuestions { get; set; }
    }
}