using AulacLichKham.DTO;
using AulacLichKham.DTO.FuncExam;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AulacLichKham.Controllers
{
    [Tags("Danh sách chức năng khám")]
    [Route("func-exam")]
    public class FuncExamController : BaseController
    {
        private readonly IFuncExamService _service;
        private readonly ILogger<FuncExamController> _logger;
        private readonly IMapper _mapper;
        public FuncExamController(ILogger<FuncExamController> logger, IFuncExamService service, IMapper mapper)
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
        public ActionResult<SuccessResponse<FuncExamDTO[]>> Items()
        {
            var result = _service.Gets(null);
            var data = result.Select(_mapper.Map<FuncExamDTO>).ToArray();

            return Ok(new SuccessResponse<FuncExamDTO[]>(
                data
            ));
        }
    }
}
