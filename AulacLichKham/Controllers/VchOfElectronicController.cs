using AulacLichKham.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AulacLichKham.DTO.Vch;
using AulacLichKham.Modules.Interfaces.Repositories;
using AulacLichKham.Modules.Entities;

namespace AulacLichKham.Controllers
{
    [Tags("Chứng từ điện tử")]
    [Route("VchOfElectronic")]
    public class VchOfElectronicController : BaseController
    {
        private readonly IVchOfElectronicRepository _service;
        private readonly ILogger<VchOfElectronicController> _logger;
        private readonly IMapper _mapper;
        public VchOfElectronicController(ILogger<VchOfElectronicController> logger, IVchOfElectronicRepository service, IMapper mapper)
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
        public ActionResult<SuccessResponse<VchOfElectronicDTO[]>> Items([FromQuery] VchOfElectronicParam request)
        {
            var VchOfElectronics = _service.Gets_VchOfElectronic(request);
            var VchOfElectronicDTOs = VchOfElectronics.Select(_mapper.Map<VchOfElectronicDTO>).ToArray();

            return Ok(new SuccessResponse<VchOfElectronicDTO[]>(
                VchOfElectronicDTOs
            ));
        }
    }
}
