using AulacLichKham.DTO;
using AulacLichKham.DTO.DeptPfm;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AulacLichKham.Controllers
{
    [Tags("Khoa/Phòng thực hiện")]
    [Route("dept-pfm")]
    public class DeptPfmController : BaseController
    {
        private readonly IDeptPfmService _service;
        private readonly ILogger<DeptPfmController> _logger;
        private readonly IMapper _mapper;
        public DeptPfmController(ILogger<DeptPfmController> logger, IDeptPfmService service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// Danh sách khoa/phòng thực hiện.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("")]
        public ActionResult<SuccessResponse<DeptPfmDTO[]>> Items()
        {
            var result = _service.Gets(null);
            var data = result.Select(_mapper.Map<DeptPfmDTO>).ToArray();

            return Ok(new SuccessResponse<DeptPfmDTO[]>(
                data
            ));
        }
    }
}
