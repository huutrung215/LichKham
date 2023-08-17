using AulacLichKham.DTO;
using AulacLichKham.Modules.Interfaces.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AulacLichKham.DTO.FuncExam;
using AulacLichKham.Modules.Entities;

namespace AulacLichKham.Controllers
{

    [Tags("Danh sách bệnh nhân thực hiện")]
    [Route("PntPfm")]
    public class PntPfmServiceController : BaseController
    {
        private readonly IPntPfmServiceRepository _service;
        private readonly ILogger<PntPfmServiceController> _logger;
        private readonly IMapper _mapper;
        public PntPfmServiceController(ILogger<PntPfmServiceController> logger, IPntPfmServiceRepository service, IMapper mapper)
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
        public ActionResult<SuccessResponse<PntPfmServiceDTO[]>> Items([FromQuery] PntPfmServiceParam request)
        {
            var PntPfmServices = _service.Gets_PntPfmService(request);
            var PntPfmServiceDTOs = PntPfmServices.Select(_mapper.Map<PntPfmServiceDTO>).ToArray();

            return Ok(new SuccessResponse<PntPfmServiceDTO[]>(
                PntPfmServiceDTOs
            ));
        }
    }
}
