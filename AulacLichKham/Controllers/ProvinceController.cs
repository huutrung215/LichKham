using AulacLichKham.DTO;
using AulacLichKham.DTO.Province;
using AulacLichKham.Modules.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AulacLichKham.Controllers
{
    [Tags("Danh sách Tỉnh")]
    [Route("Province")]
    public class ProvinceController : BaseController
    {
        private readonly IProvinceService _service;
        private readonly ILogger<ProvinceController> _logger;
        private readonly IMapper _mapper;
        public ProvinceController(ILogger<ProvinceController> logger, IProvinceService service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// Danh sách tỉnh.
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [HttpGet("")]
        public ActionResult<SuccessResponse<ProvinceDTO[]>> Items()
        {
            var result = _service.Gets(null);
            var data = result.Select(_mapper.Map<ProvinceDTO>).ToArray();

            return Ok(new SuccessResponse<ProvinceDTO[]>(
                data
            ));
        }
    }
}
