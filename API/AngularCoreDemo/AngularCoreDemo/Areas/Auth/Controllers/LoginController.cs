using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularCoreDemo.Areas.Auth.Controllers
{
    //[Route("api/[controller]")]
    [Area("Auth")]
    [Route("auth/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public ActionResult<string> See()
        {
            return "Login start";
        }
        public ActionResult<string> See2()
        {
            return "Login start 2";
        }
    }
}