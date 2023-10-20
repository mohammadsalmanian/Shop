

using AngularEshop.Core.Services.Interfaces;
using AngularEshop.Core.Utilities.Common;
using Microsoft.AspNetCore.Mvc;

namespace AngularEshop.WebApi.Controllers
{   
    public class SliderController : SiteBaseController
    {
        #region constractor
        private ISliderService SliderService;
        public SliderController(ISliderService sliderService)
        {
            this.SliderService = sliderService;
        }
        #endregion
        [HttpGet(template: "GetActiveSlider")]
        public async Task<IActionResult> GetActiveSlider()
        {
            var resault = await SliderService.GetActiveSliders();
            return JsonResponseStatus.Success(resault);
        }
    }
}
