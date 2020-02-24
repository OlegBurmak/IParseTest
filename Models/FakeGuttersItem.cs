using System.Collections.Generic;
using System.Linq;

namespace IParse.Models
{
    public class FakeGuttersItem : IGuttersItem
    {
        public IQueryable<GuttersItem> GuttersItems => new List<GuttersItem> 
        {
            new GuttersItem { Icon = "flaticon-analysis", Header = "Бизнес Аналитика", Description = "Удобное решение для анализа вашей области."},
            new GuttersItem { Icon = "flaticon-business", Header = "Анализ Рынка", Description = "Удобное решение для анализа рынка по вашей области."},
            new GuttersItem { Icon = "flaticon-insurance", Header = "Мониторинг Экономики", Description = "Удобное решение для мониторинга экономики по вашей области."},
            new GuttersItem { Icon = "flaticon-money", Header = "Популярные Направления", Description = "Удобное решение для поиска популярных направление в вашей области."},
            new GuttersItem { Icon = "flaticon-rating", Header = "Улучшение Инфраструктуры", Description = "Удобное решения для улучшение инфраструктуры вашей области."},
            new GuttersItem { Icon = "flaticon-search-engine", Header = "Выработка Стратегии", Description = "Удобное решение для выработки стратегии в вашей области."},
        }.AsQueryable<GuttersItem>();
    }
}