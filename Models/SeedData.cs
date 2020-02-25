using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IParse.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if(!context.ClientCarousels.Any())
            {
                context.ClientCarousels.AddRange(
                    new ClientCarousel
                    {
                        Image = "person_1.jpg",
                        CompanyName = "Astars",
                        Description = "Удобное решение для быстрого анализа рынка",
                        ClientName = "Андрей Попов",
                        Position = "CEO специалист"
                    }, 
                    new ClientCarousel
                    {
                        Image = "person_2.jpg",
                        CompanyName = "PathFinder",
                        Description = "Если нужно качественный мониторинг конкурентов, то этот сервис мастхев",
                        ClientName = "Александр Вилюсов",
                        Position = "Game producer"
                    } 
                );
                context.SaveChanges();
            }
        }
    }
}