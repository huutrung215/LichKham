using AulacLichKham.DTO;
using AulacLichKham.DTO.RegExamFrombDoctor;
using AulacLichKham.DTO.TestCardDTO;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Services;
using AulacLichKham.Modules.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using static Aulac.Service.Rsc.Tags.StoredProcedure;

namespace AulacLichKham.Controllers
{
    [Tags("Xử lý kiểm tra doc du lieu the RFID")]
    [Route("testcard")]
    public class TestCardController : BaseController
    {
        private readonly ITestCardService _service;
        private readonly ILogger<TestCardController> _logger;
        private readonly IMapper _mapper;

        public TestCardController(ILogger<TestCardController> logger, ITestCardService service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// Xu ly kiem tra doc du lieu the RFID
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>

        [HttpGet("")]

        public ActionResult<SuccessResponse<string>> TestCard([FromForm] TestCard model)
        {
            try
            {
                if (model.ID.Length < 10)
                {
                    int lenght = model.ID.Length;
                    for (int i = 0; i < 10 - lenght; i++)
                        model.ID = "0" + model.ID;
                }

                _service.TestCard(model.DeviceID, model.ID);

                return Ok(new SuccessResponse<string>("Thành công!"));
            }
            catch (Exception ex)
            {
                return Ok(new ErrorResponse("Thất bại!"));
            }
        }
    }
}
