using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shops.Core.Services.Interface;

namespace Shops.WebApi.Controllers
{

    public class UsersController : SiteBaseController
    {
        private IUserService userService;
        public UsersController(IUserService Service)
        {
            this.userService = Service;
        }
        [HttpGet(template:"Users")]
        public async Task<IActionResult> GetAllUser()
        {
            var json = await this.userService.GetAllUser();
            return new JsonResult(json);
        }

    }
}
