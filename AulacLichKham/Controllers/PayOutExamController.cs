using AulacLichKham.DTO;
using AulacLichKham.DTO.PayOutExam;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AulacLichKham.Controllers
{
    [Tags("Thông tin thanh toán")]
    [Route("payout")]
    public class PayOutExamController : BaseController
    {
        private readonly IPayOutExamService _service;
        private readonly ILogger<PayOutExamController> _logger;
        private readonly IMapper _mapper;
        public PayOutExamController(ILogger<PayOutExamController> logger, IPayOutExamService service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// Thông tin thanh toán bệnh nhân.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("")]
        public ActionResult<SuccessResponse<PayOutExamDTO[]>> Items([FromQuery] PayOutExamRequest request)
        {
            var result = _service.Gets_DetailPayOutExamService(request);
            var data = result.Select(_mapper.Map<PayOutExamDTO>).ToArray();

            return Ok(new SuccessResponse<PayOutExamDTO[]>(
                data
            ));
        }
    }
}
