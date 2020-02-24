using System.Linq;

namespace IParse.Models
{
    public interface IHomeSliderRepository
    {
         IQueryable<HomeSlider> Sliders { get; }
    }
}