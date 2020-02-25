using System.Collections.Generic;
using System.Linq;

namespace IParse.Models
{
    public class FakeHomeSliderRepository : IHomeSliderRepository
    {
        public IQueryable<HomeSlider> Sliders => new List<HomeSlider> 
        {
            new HomeSlider { Image = "bg_1.jpg", Heading = "Начать работать очень легко!", Description = "Для начала работы с помощью нашего сервиса нужно просто войти в систему", ButtoAction = "/", ButtonName = "Войти"},
            new HomeSlider { Image = "bg_2.jpg", Heading = "Кто мы такие", Description = "IParse продвинутая система парсинга, монитринга инфраструктур для малого и большого бизнеса.", ButtoAction = "AboutUs", ButtonName = "Подробнее"}
        }.AsQueryable<HomeSlider>();
    }
}