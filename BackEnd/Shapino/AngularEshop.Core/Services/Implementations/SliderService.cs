
using AngularEshop.Core.Services.Interfaces;
using AngularEshop.DataLayer.Entities.Site;
using AngularEshop.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace AngularEshop.Core.Services.Implementations
{
    public class SliderService : ISliderService
    {
        #region Constractor
        private IGenericRepository<Slider> SliderRepository;
        public SliderService(IGenericRepository<Slider> sliderRepository)
        {
            this.SliderRepository = sliderRepository;
        }

        public Task AddSlider(Slider slider)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Slider
        public async Task<List<Slider>> GetActiveSliders()
        {
            return await this.SliderRepository.GetEntitiesQuery().Where(t => !t.IsDelete).ToListAsync();
        }

        public async Task<List<Slider>> GetAllSliders()
        {
            return await this.SliderRepository.GetEntitiesQuery().ToListAsync();
        }

        public async Task<Slider> GetSliderById(long SliderId)
        {
            return await this.SliderRepository.GetEntityById(SliderId);
        }

        public async Task RemoveSlider(Slider slider)
        {
           this.SliderRepository.RemoveEntity(slider);
            await this.SliderRepository.SaveChanges();
        }

        public async Task RemoveSlider(long SliderId)
        {
            await this.SliderRepository.RemoveEntity(SliderId);
            await this.SliderRepository.SaveChanges();
        }

        public async Task UpdateSlider(Slider slider)
        {
            this.SliderRepository.UpdateEntity(slider);
            await this.SliderRepository.SaveChanges();
        }

        #endregion
        #region dispose
        public void Dispose()
        {
            SliderRepository?.Dispose();
        }
       
        #endregion
    }
}
