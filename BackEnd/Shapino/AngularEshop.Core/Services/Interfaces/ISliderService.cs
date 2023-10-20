

using AngularEshop.DataLayer.Entities.Site;

namespace AngularEshop.Core.Services.Interfaces
{
    public interface ISliderService :IDisposable
    {
        Task<List<Slider>> GetAllSliders();

        Task<List<Slider>> GetActiveSliders();

        Task<Slider> GetSliderById(long SliderId);

        Task AddSlider(Slider slider);

        Task UpdateSlider(Slider slider);

        Task RemoveSlider(Slider slider);

        Task RemoveSlider(long SliderId);
    }
}
