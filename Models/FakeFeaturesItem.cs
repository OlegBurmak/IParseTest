using System.Collections.Generic;
using System.Linq;

namespace IParse.Models
{
    public class FakeFeaturesItem : IFeaturesItem
    {
        public IQueryable<FeaturesItem> FeaturesItems => new List<FeaturesItem> 
        {
            new FeaturesItem { Icon = "flaticon-collaboration", Header = "Возможности", Description = "Система IParse собирает цены магазинов, обновляя их непосредственно со страниц сайтов, без каких-либо прайс-листов. Благодаря передовым технологиям способны обработать интернет-магазины с любой организацией данных."},
            new FeaturesItem { Icon = "flaticon-analysis", Header = "Гибкая отчетность", Description = "Мы интегрируем все данные из нашего онлайн-сервиса в вашу внутреннюю систему. С IParse используйте широкий набор стандартных аналитических отчетов и создавайте их самостоятельно."},
            new FeaturesItem { Icon = "flaticon-search-engine", Header = "Гибкая отчетность", Description = "Мы интегрируем все данные из нашего онлайн-сервиса в вашу внутреннюю систему. С IParse используйте широкий набор стандартных аналитических отчетов и создавайте их самостоятельно."},
            new FeaturesItem { Icon = "flaticon-handshake", Header = "Гибкая отчетность", Description = "Мы интегрируем все данные из нашего онлайн-сервиса в вашу внутреннюю систему. С IParse используйте широкий набор стандартных аналитических отчетов и создавайте их самостоятельно."}
        }.AsQueryable<FeaturesItem>();
    }
}