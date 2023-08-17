using AulacLichKham.DTO.Province;
using AulacLichKham.DTO;
using AulacLichKham.Modules.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AulacLichKham.Modules.Entities;

namespace AulacLichKham.Controllers
{
    [Tags("Danh sách huyện")]
    [Route("district")]
    public class DistrictController:BaseController
    {
        private readonly IDistrictService _service;
        private readonly ILogger<DistrictController> _logger;
        private readonly IMapper _mapper;
        public DistrictController(ILogger<DistrictController> logger, IDistrictService service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// Danh sách huyện.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("Get")]
        public ActionResult<SuccessResponse<DistrictDTO[]>> Items([FromQuery] DistrictParam request)
        {
            var Districts = _service.Gets_District(request);
            var DistrictDTOs = Districts.Select(_mapper.Map<DistrictDTO>).ToArray();

            return Ok(new SuccessResponse<DistrictDTO[]>(
                DistrictDTOs
            ));
        }
    }
}
