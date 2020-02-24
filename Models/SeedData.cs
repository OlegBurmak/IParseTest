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
                        Image = "",
                        CompanyName = "Название отсутствует",
                        Description = "Описание отсутствует",
                        ClientName = "Имя отсутствует",
                        Position = "Должность отсутствует"
                    }    
                );
                context.SaveChanges();
            }
        }
    }
}