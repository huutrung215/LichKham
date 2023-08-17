using AulacLichKham.DTO;
using AulacLichKham.DTO.DoctorPfm;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AulacLichKham.Controllers
{
    [Tags("Thông tin bác sĩ")]
    [Route("doctor-pfm")]
    public class DoctorPfmController : BaseController
    {
        private readonly IDoctorPfmService _service;
        private readonly ILogger<DoctorPfmController> _logger;
        private readonly IMapper _mapper;
        public DoctorPfmController(ILogger<DoctorPfmController> logger, IDoctorPfmService service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// Danh sách bác sỹ thực hiện.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("")]
        public ActionResult<SuccessResponse<DoctorPfmDTO[]>> Items([FromQuery] DoctorPfmRequest request)
        {
            var result = _service.Gets_DoctorPfm(request);
            var data = result.Select(_mapper.Map<DoctorPfmDTO>).ToArray();

            return Ok(new SuccessResponse<DoctorPfmDTO[]>(
                data
            ));
        }
    }
}
