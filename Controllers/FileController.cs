using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapi.Models;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {
        ILogger<FileController> logger;
        public FileController(ILogger<FileController> _logger)
        {
            logger = _logger;
        }
        [HttpPost]
        [Route("upload")]
        [ProducesResponseType(typeof(List<FileUploadResponse>), StatusCodes.Status202Accepted)]
        public ActionResult UploadFile([Required] List<IFormFile> filesToUpload)
        {
            List<FileUploadResponse> fileUploadResponses = new List<FileUploadResponse>();
            foreach (var file in filesToUpload)
            {
                logger.LogInformation($"Received file : {file.FileName} and size : {file.Length} bytes");    
                fileUploadResponses.Add(new FileUploadResponse {FileName = file.FileName, FileSize = file.Length});
            }
            return Accepted(fileUploadResponses);
        }
    }
}

