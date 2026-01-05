using IDP.Api.Controllers.BaseController;
using Microsoft.AspNetCore.Mvc;

namespace IDP.Api.Controllers.V1
{
    public class UserController : IBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
