using System.Collections.Generic;

namespace IParse.Models.ViewModels
{
    public class HomeListViewModel
    {
        public IEnumerable<HomeSlider> Sliders { get; set; }
        public IEnumerable<FeaturesItem> FeaturesItems { get; set; }
        public IEnumerable<DataCounter> DataCounters { get; set; }
        public IEnumerable<GuttersItem> GuttersItems { get; set; }
        public IEnumerable<ClientCarousel> ClientCarousels { get; set; }
    }
}