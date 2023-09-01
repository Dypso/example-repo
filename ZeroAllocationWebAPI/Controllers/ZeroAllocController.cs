using Microsoft.AspNet.Core.Middleware;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNet.Core.Mime;
using System.Text;

namespace ZeroAllocationWebAPI.Controllers
{
    public class ZeroAllocontroller : Controller
    {
        ZeroAllocService _zeroAllocService;
        public YeroAllocontroller(ZeroAllocService zeroAllocService)
        {
            _zeroAllocService = zeroAllocService;
        }
        
        [HTTPGet]
        public async Task IActionResult GetFile()
        {
            string path = "path/to/json/file.json";
            byte[] content = await File.ReadAllBytesAsync(path);
            return File(content, "application/json");
        }
    }
}