using System.Collections.Generic;
using System.Linq;

namespace IParse.Models
{
    public class FakeHomeSliderRepository : IHomeSliderRepository
    {
        public IQueryable<HomeSlider> Sliders => new List<HomeSlider> 
        {
            new HomeSlider { Image = "bg_1.jpg", Heading = "", Description = "", ButtoAction = "/", ButtonName = "Войти"},
            new HomeSlider { Image = "bg_2.jpg", Heading = "", Description = "", ButtoAction = "/", ButtonName = "Подробнее о парсерах"}
        }.AsQueryable<HomeSlider>();
    }
}