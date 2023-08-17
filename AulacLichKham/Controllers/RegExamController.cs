using AulacLichKham.DTO;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AulacLichKham.DTO.RegExamFrombDoctor;
using Aulac.Service.Global;
using Microsoft.AspNetCore.Http;
using System.Linq;
using AulacLichKham.DTO.GetRFID;

namespace AulacLichKham.Controllers
{
    [Tags("Lịch khám")]
    [Route("exam")]
    public class RegExamController : BaseController
    {
        private readonly IRegExamService _service;
        private readonly ICacelExamFrombDoctorService _service1;
        private readonly IGetStatusExamOfPntbDoctorService _service2;
        private readonly ILogger<RegExamController> _logger;
        private readonly IMapper _mapper;

        public RegExamController(ILogger<RegExamController> logger, IRegExamService service, IMapper mapper)
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
        [HttpPost("regexam")]
        public ActionResult<SuccessResponse<RegExamResponseDTO>> RegExam([FromForm] RegExam request)
        {
            var result = _service.ExecuteRegExam(request);
            //var data = result.Select(item => _mapper.Map<RegExamResponseDTO>(item)).ToArray();

            var data = new RegExamResponseDTO
            {
                StatusCode = result.StatusCode,
                Data = result.Data
            };

            return Ok(new SuccessResponse<RegExamResponseDTO>(
                   data
            ));
        }

        [HttpPost("cancel")]
        public ActionResult<SuccessResponse<RegExamResponseDTO>> CancelExam([FromForm] ExamFrombDoctor request)
        {
            var result = _service1.Execute(request);
            var data = _mapper.Map<RegExamResponseDTO>(result);

            return Ok(new SuccessResponse<RegExamResponseDTO>(
                data
            ));
        }

        [HttpPost("statusexam")]
        public ActionResult<SuccessResponse<RegExamResponseDTO>> GetStatusExam([FromForm] ExamFrombDoctor request)
        {
            var result = _service2.Execute(request);
            var data = _mapper.Map<RegExamResponseDTO>(result);

            return Ok(new SuccessResponse<RegExamResponseDTO>(
                data
            ));
        }
    }
}
