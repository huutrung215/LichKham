using AulacLichKham.Controllers;
using AulacLichKham.DTO.FuncExam;
using AulacLichKham.DTO;
using AulacLichKham.Modules.Interfaces.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AulacLichKham.Modules.Entities;
using AulacLichKham.DTO.Upload;

namespace AulacLichKham.Controllers
{
    [Tags("Upload File")]
    [Route("File")]
    public class FilesController : ControllerBase
    {
        private readonly IFileRepository _service;
        private readonly IMapper _mapper;
        private readonly ILogger<FilesController> _logger;
        public FilesController(ILogger<FilesController> logger, IFileRepository service, IMapper mapper)
         {
             _logger = logger;
             _service = service;
             _mapper = mapper;
         }

        [HttpPost("Upload")]
        public ActionResult<SuccessResponse<FileDTO[]>> Items([FromForm] UploadFileParam data)
        {
            try
            {
                if (data == null)
                    return BadRequest();

                string CLSPntPrkID = data.CLSPntPrkID;
                string FolderName = data.FolderName;
                string FileName = data.FileName;
                string Image = data.Image;

                string pDirectoryInfo = Path.Combine(Directory.GetCurrentDirectory(), FolderName, CLSPntPrkID);
                if (!Directory.Exists(pDirectoryInfo))
                    Directory.CreateDirectory(pDirectoryInfo);

                if (!string.IsNullOrEmpty(Image))
                {
                    byte[] imageBytes = Convert.FromBase64String(Image);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                        image.Save(Path.Combine(pDirectoryInfo, FileName), System.Drawing.Imaging.ImageFormat.Bmp);
                    }
                }

                return Ok(new SuccessResponse<string>("Thành công!"));
            }
            catch (Exception ex)
            {
                return Ok(new ErrorResponse("Thất bại!"));
            }
        }
    }
}
