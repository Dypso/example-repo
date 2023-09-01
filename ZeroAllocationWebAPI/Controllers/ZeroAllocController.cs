using Microsoft.AspNet.Core.Middleware;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNet.Core.Mime;
using System.Text;
using Microsoft.AspNet.Core.Http;

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
        public async Task IActionResult UploadMultipartFiles(IFormFileCollection files)
        {
            list<FileStream> resultFiles = new List<FileStream>();
            foreach(var file in files)
            {
                resultFiles.Add(new FileStream(file.OpenRead(), file.Length, string.Empty));
            }
            return New MultipartResult(resultFiles);
        }
    }
}