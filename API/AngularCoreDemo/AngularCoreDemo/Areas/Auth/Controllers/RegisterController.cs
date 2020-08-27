using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularCoreDemo.Areas.Auth.Controllers
{
    [Area("Auth")]
    [Route("auth/[controller]/[action]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
    }
}