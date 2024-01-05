using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shops.Core.common;
using Shops.Core.Services.Interface;

namespace Shops.WebApi.Controllers
{
    public class SlidersController : SiteBaseController
    {
        #region constractor
        private ISliderService SliderService;

        public SlidersController(ISliderService sliderService)
        {
            this.SliderService = sliderService;
        }
        #endregion
        [HttpGet(template:"Sliders")]
        public async Task<IActionResult> Sliders()
        {
            var resault = await SliderService.GetAllSlider();
            return JsonResponseStatus.Success(resault);
        }
        [HttpGet(template: "GetActiveSlider")]
        public async Task<IActionResult> GetActiveSlider()
        {
            var resault = await SliderService.GetActiveSlider();
            return JsonResponseStatus.Success(resault);
        }
    }
}
