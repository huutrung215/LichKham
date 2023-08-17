using AulacLichKham.DTO;
using AulacLichKham.DTO.FuncExam;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AulacLichKham.Controllers
{
    [Tags("Đăng ký dịch vụ")]
    [Route("ServiceReqOfPnt")]
    public class ServiceReqOfPntController : BaseController
    {
        private readonly IServiceReqOfPntRepository _service;
        private readonly ILogger<ServiceReqOfPntController> _logger;
        private readonly IMapper _mapper;
        public ServiceReqOfPntController(ILogger<ServiceReqOfPntController> logger, IServiceReqOfPntRepository service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// Đặt lịch khám
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("Set")]
        public ActionResult<SuccessResponse<ServiceReqOfPntResponse>> Items([FromForm] ServiceReqOfPnt request)
        {
            var ServiceReqOfPnts = _service.Execute(request);

            return Ok(new SuccessResponse<ServiceReqOfPntResponse>(
                new ServiceReqOfPntResponse()
                {
                    StatusCode = ServiceReqOfPnts
                }
            ));
        }
    }
}
