using AulacLichKham.DTO.TownWard;
using AulacLichKham.DTO;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using AulacLichKham.DTO.RegExamFrombDoctor;
using Aulac.Service.Rsc;
using Aulac.Service.Rsc.Tags;
using System.Data;
using Aulac.Service.Global;
using Microsoft.AspNetCore.Http;
using System.Numerics;
using AulacLichKham.DTO.FuncExam;
using AulacLichKham.DTO.DoctorPfm;

namespace AulacLichKham.Controllers
{
    [Tags("Lấy thông tin bác sĩ chữa bệnh trong ngày")]
    [Route("doctor-exam-in-day")]
    public class DoctorExamInDayController : BaseController
    {
        private readonly IGetDoctorExamInDayService _service;
        private readonly ILogger<DoctorExamInDayController> _logger;
        private readonly IMapper _mapper;
        public DoctorExamInDayController(ILogger<DoctorExamInDayController> logger, IGetDoctorExamInDayService service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("")]
        public ActionResult<SuccessResponse<DoctorExamDTO[]>> Items([FromQuery] RegExamParam request)
        {
            var result = _service.Gets_DoctorExamInDay(request);
            var data = result.Select(_mapper.Map<DoctorExamDTO>).ToArray();

            return Ok(new SuccessResponse<DoctorExamDTO[]>(
                data
            ));
        }
    }
}
