using Microsoft.AspNetCore.Mvc;
namespace Shops.Core.common
{
    public static class JsonResponseStatus
    {
        public static JsonResult Success(object Data)
        {
            return new JsonResult(new {status = "success", data = Data});
        }
        public static JsonResult Success()
        {
            return new JsonResult(new { status = "success"});
        }
    }
}
