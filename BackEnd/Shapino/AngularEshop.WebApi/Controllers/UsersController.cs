using AngularEshop.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AngularEshop.WebApi.Controllers
{   
    public class UsersController : SiteBaseController
    {
        #region Constractor
        private IUserService UserService;
        public UsersController(IUserService userService)
        {
            this.UserService = userService;
        }
        #endregion
        #region UserList
        [HttpGet(template: "Users")]
        public async Task<IActionResult> Users()
        {
            return new ObjectResult(await UserService.GetAllUsers());
        }
        #endregion
    }
}
