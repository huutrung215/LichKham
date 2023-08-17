using AulacLichKham.DTO;
using AulacLichKham.DTO.CureExam;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AulacLichKham.Controllers
{
    [Tags("Khám nội trú")]
    [Route("cure-exam")]
    public class CureExamController : BaseController
    {
        private readonly ICureExamService _service;
        private readonly ILogger<CureExamController> _logger;
        private readonly IMapper _mapper;
        public CureExamController(ILogger<CureExamController> logger, ICureExamService service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// Danh mục chức năng khám.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("")]
        public ActionResult<SuccessResponse<CureExamDTO[]>> Items([FromQuery] CureExamRequest request)
        {
            var result = _service.Gets_PntCureOfBedNum(request);
            var data = result.Select(_mapper.Map<CureExamDTO>).ToArray();

            return Ok(new SuccessResponse<CureExamDTO[]>(
                data
            ));
        }

        [HttpGet("bednum")]
        public ActionResult<SuccessResponse<BedNumOfDeptDTO[]>> Items_ListBedNumOfDept([FromQuery] BedNumOfDeptRequest request)
        {
            var result = _service.Gets_BedNumOfDept(request);
            var data = result.Select(_mapper.Map<BedNumOfDeptDTO>).ToArray();

            return Ok(new SuccessResponse<BedNumOfDeptDTO[]>(
                data
            ));
        }
    }
}
