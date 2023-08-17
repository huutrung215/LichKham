using AulacLichKham.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AulacLichKham.DTO.Check;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;

namespace AulacLichKham.Controllers
{
    [Tags("Check Ins Card Fast Machine")]
    [Route("InsCardFastMachine")]
    public class InsCardFastMachineController : BaseController
    {
        private readonly IInsCardFastMachineRepository _service;
        private readonly ILogger<InsCardFastMachineController> _logger;
        private readonly IMapper _mapper;
        public InsCardFastMachineController(ILogger<InsCardFastMachineController> logger, IInsCardFastMachineRepository service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// dich vụ PfmOfPnt
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("")]
        public ActionResult<SuccessResponse<InsCardFastMachineResponse>> Items([FromQuery] InsCardFastMachine request)
        {
            var InsCardFastMachines = _service.Execute(request);

            return Ok(new SuccessResponse<InsCardFastMachineResponse>(
                new InsCardFastMachineResponse()
                {
                    Account = InsCardFastMachines
                }
            ));
        }
    }
}
