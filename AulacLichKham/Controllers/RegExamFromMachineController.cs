using AulacLichKham.DTO.FuncExam;
using AulacLichKham.DTO;
using AulacLichKham.Modules.Interfaces.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AulacLichKham.DTO.RegExam;
using AulacLichKham.Modules.Entities;

namespace AulacLichKham.Controllers
{
    [Tags("Đăng ký kỳ thi từ máy")]
    [Route("ExamFromMachine")]
    public class RegExamFromMachineController : BaseController
    {
        private readonly IRegExamFromMachineRepository _service;
        private readonly ILogger<RegExamFromMachineController> _logger;
        private readonly IMapper _mapper;
        public RegExamFromMachineController(ILogger<RegExamFromMachineController> logger, IRegExamFromMachineRepository service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// Đặt lịch khám
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("")]
        public ActionResult<SuccessResponse<RegExamFromMachineResponse>> Items([FromQuery] RegExamFromMachine request)
        {
            string[] result;
            _service.Execute_RegExamFromMachine(request, out result);

            string statusCode = result[0];
            string outputData = result[1];

            return Ok(new SuccessResponse<RegExamFromMachineResponse>(
                new RegExamFromMachineResponse()
                {
                    StatusCode = statusCode,
                    Data = outputData
                }
            ));
        }

    }
}
