using Microsoft.AspNet.Core;
using Microsoft.AspNet.Core.MVC;
using System;
using System.Text.Json;

namespace ZeroAllocationWebIPI.Controllers
{
    [produces("application/json")]
    [ApiController]
    public class ZeroAllcontroller : Controller
    {
        [HttpPost]
        [route("zeroallc/process")]
        public action ProcessJsonObject([Object object])
        {
            // To be implemented
        }
    }
}