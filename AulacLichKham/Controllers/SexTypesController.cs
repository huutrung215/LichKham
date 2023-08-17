using AulacLichKham.DTO.FuncExam;
using AulacLichKham.DTO;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AulacLichKham.DTO.SexTypes;

namespace AulacLichKham.Controllers
{
    [Tags("Danh sách giới tính")]
    [Route("sextypes")]
    public class SexTypesController : BaseController
    {
        private readonly ISexTypesService _service;
        private readonly ILogger<SexTypesController> _logger;
        private readonly IMapper _mapper;
        public SexTypesController(ILogger<SexTypesController> logger, ISexTypesService service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public ActionResult<SuccessResponse<SexTypesDTO[]>> Items()
        {
            var result = _service.Gets(null);
            var data = result.Select(_mapper.Map<SexTypesDTO>).ToArray();

            return Ok(new SuccessResponse<SexTypesDTO[]>(
                data
            ));
        }
    }
}
