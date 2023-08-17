using AulacLichKham.DTO;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AulacLichKham.DTO.TownWard;

namespace AulacLichKham.Controllers
{
    [Tags("Danh sách phường xã")]
    [Route("townward")]
    public class TownWardController : BaseController
    {
        private readonly ITownWardService _service;
        private readonly ILogger<TownWardController> _logger;
        private readonly IMapper _mapper;

        public TownWardController(ILogger<TownWardController> logger, ITownWardService service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// Danh mục phường xã
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("")]
        public ActionResult<SuccessResponse<TownWardDTO[]>> Items([FromQuery] TownWardParam request)
        {
            //if (string.IsNullOrEmpty(districtID))
            //{
            //    // Nếu districtID không được cung cấp, trả về BadRequest
            //    return BadRequest("districtID is required");
            //}

            //var townWardEntity = new TownWard { DistrictID = districtID };
            var townWards = _service.Gets_TownWard(request);
            var townWardDTOs = townWards.Select(_mapper.Map<TownWardDTO>).ToArray();

            return Ok(new SuccessResponse<TownWardDTO[]>(
                townWardDTOs
            ));
        }
    }
}
