using AulacLichKham.DTO.GetRFID;
using AulacLichKham.DTO;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Aulac.Service.Global;

namespace AulacLichKham.Controllers
{
    namespace AulacLichKham.Controllers
{
    [Tags("Xữ lý dự liệu doc the RFID")]
    [Route("rfid")]
    public class RFIDController : Controller
    {
        private readonly IGetRFIDService _service;
        private readonly IGetRFID2Service _service2;
        private readonly ILogger<RFIDController> _logger;
        private readonly IMapper _mapper;

        public RFIDController(ILogger<RFIDController> logger, IGetRFIDService service, IGetRFID2Service service2, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _service2 = service2;
            _mapper = mapper;
        }

        /// <summary>
        /// Xu ly du lieu doc the RFID
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("rfid")]
        public ActionResult<SuccessResponse<GetRFIDPResponse>> GetRFID([FromQuery] GetRFID request)
        {
            try
            {
                int lenID = request.ID.Length;
                if (lenID < 10)
                {
                    for (int i = 0; i < 10 - lenID; i++)
                        request.ID = "0" + request.ID;
                }

                var statusCode = _service.Execute(request);

                if (statusCode == ErrorCodeMsg.R000)
                {
                    return Ok(new SuccessResponse<string>("Thành công!"));
                }
                else
                {
                    return Ok(new ErrorResponse("Không thành công!"));
                }
            }
            catch (Exception ex)
            {
                return Ok(new ErrorResponse("Không thành công!"));
            }
        }

        /// <summary>
        /// Xu ly du lieu doc the RFID 2
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("rfid2")]
        public ActionResult<SuccessResponse<GetRFID2Response>> GetRFID2([FromQuery] GetRFID2 request)
        {
            try
            {
                int lenID = request.ID.Length;
                if (lenID < 10)
                {
                    for (int i = 0; i < 10 - lenID; i++)
                        request.ID = "0" + request.ID;
                }

                var result = _service2.Execute1(request);
                var data = new GetRFID2Response
                {
                    StatusCode = result.StatusCode,
                    Data = result.Data
                };

                return Ok(new SuccessResponse<GetRFID2Response>(
                    data
                ));
            }
            catch (Exception ex)
            {
                return Ok(new ErrorResponse("CHUA XAC DINH"));
            }
        }
    }
}

}
