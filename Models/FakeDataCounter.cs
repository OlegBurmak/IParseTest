using System.Collections.Generic;
using System.Linq;

namespace IParse.Models
{
    public class FakeDataCounter : IDataCounter
    {
        public IQueryable<DataCounter> DataCounters => new List<DataCounter> 
        {
            new DataCounter { DataNumber = 705, Description = "Завершенных проектов"},
            new DataCounter { DataNumber = 750, Description = "Поддерживаемых сайтов"}, 
            new DataCounter { DataNumber = 550, Description = "Довольных клиентов"}, 
            new DataCounter { DataNumber = 10, Description = "Лет в сфере"}
        }.AsQueryable<DataCounter>();
    }
}