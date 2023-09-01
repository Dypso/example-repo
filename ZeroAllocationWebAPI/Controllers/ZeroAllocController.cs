using Microsoft.AspNet.Core.Middleware;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNet.Core.Mime;
using System.Text;
using Microsoft.AspNet.Core.Http;
using System.Net.Http.Headers;

namespace ZeroAllocationWebAPI.Controllers
{
    public class ZeroAllocontroller : Controller
    {
        ZeroAllocService _zeroAllocService;
        public ZeroAllocontroller(ZeroAllocService zeroAllocService)
        {
            _zeroAllocService = zeroAllocService;
        }
        
        [HTTPPost]
        public async Task IActionResult UploadMultipartFilesOptimized()
        {
            VariantionStream responseStream = new VariantiStream();
            foreach (var segment in Request.FormFiles)
            {
                responseStream.AddSegment(segment.OpenRead());
            }
            return New FileResult(responseStream, "multipart/mixed");
        }
    }
}