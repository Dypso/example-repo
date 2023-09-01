using Microsoft.AspNet.Core;
using Microsoft.AspNet.Core.MVC;
using System;
using System.Text.Json;
using ZeroAllocationWebIPI.Models;
using ZeroAllocationWebIPI.Services;

namespace ZeroAllocationWebAPI.Controllers
{
    [produces("application/json")]
    [ApiController]
    public class ZeroAllcontroller : Controller
    {
        [HttpPost]
        [route("zeroallc/process")]
        public action ProcessComplexObject([FromBody] ComplexObject object, ZeroAllcontroller service)
        {
            service.ProcessComplexObject(object);
        }
    }
}