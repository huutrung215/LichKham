using AulacLichKham.DTO.FuncExam;
using AulacLichKham.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AulacLichKham.Modules.Interfaces.Repositories;
using AulacLichKham.Modules.Entities;

namespace AulacLichKham.Controllers
{
    [Tags("Thông tin bệnh nhân nội trú")]
    [Route("PntCure")]
    public class InfoPntCureInDeptController : BaseController
    {
        private readonly IInfoPntCureInDeptRepository _service;
        private readonly ILogger<InfoPntCureInDeptController> _logger;
        private readonly IMapper _mapper;
        public InfoPntCureInDeptController(ILogger<InfoPntCureInDeptController> logger, IInfoPntCureInDeptRepository service, IMapper mapper)
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
        public ActionResult<SuccessResponse<InfoPntCureInDeptDTO[]>> Items([FromQuery] InfoPntCureInDeptParam request)
        {
            var InfoPntCureInDepts = _service.Gets_InfoPntCureInDept(request);
            var InfoPntCureInDeptDTOs = InfoPntCureInDepts.Select(_mapper.Map<InfoPntCureInDeptDTO>).ToArray();

            return Ok(new SuccessResponse<InfoPntCureInDeptDTO[]>(
                InfoPntCureInDeptDTOs
            ));
        }
     }
}
