using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdTest.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdTest.Controllers
{
    // BlobController.cs
    [Route("api/[controller]")]
    [ApiController]
    public class BlobController : Controller
    {
        private readonly IBlobService _blobService;

        public BlobController(IBlobService blobService)
        {
            _blobService = blobService;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadBlob(IFormFile file, string containerName, string blobName)
        {
            using var stream = file.OpenReadStream();
            await _blobService.UploadBlobAsync(containerName, blobName, stream);
            return Ok();
        }

        [HttpGet("download")]
        public async Task<IActionResult> DownloadBlob(string containerName, string blobName)
        {
            var stream = await _blobService.GetBlobAsync(containerName, blobName);
            return File(stream, "application/octet-stream", blobName);
        }
    }

}

