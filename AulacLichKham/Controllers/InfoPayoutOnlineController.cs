using AulacLichKham.DTO.FuncExam;
using AulacLichKham.DTO;
using AulacLichKham.Modules.Interfaces.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AulacLichKham.DTO.Info;
using AulacLichKham.Modules.Entities;

namespace AulacLichKham.Controllers
{
    [Tags("Thông tin thanh toán online")]
    [Route("PayoutOnline")]
    public class InfoPayoutOnlineController : BaseController
    {
        private readonly IInfoPayoutOnlineRepository _service;
        private readonly ILogger<InfoPayoutOnlineController> _logger;
        private readonly IMapper _mapper;
        public InfoPayoutOnlineController(ILogger<InfoPayoutOnlineController> logger, IInfoPayoutOnlineRepository service, IMapper mapper)
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
        public ActionResult<SuccessResponse<InfoPayoutOnlineDTO[]>> Items([FromQuery] InfoPayoutOnlineParam request)
        {
            var InfoPayoutOnlines = _service.Gets_InfoPayoutOnline(request);
            var InfoPayoutOnlineDTOs = InfoPayoutOnlines.Select(_mapper.Map<InfoPntCureInDeptDTO>).ToArray();

            return Ok(new SuccessResponse<InfoPntCureInDeptDTO[]>(
                InfoPayoutOnlineDTOs
            ));
        }
    }
}
