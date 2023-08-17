using AulacLichKham.DTO;
using AulacLichKham.Modules.Interfaces.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AulacLichKham.DTO.FuncExam;
using AulacLichKham.Modules.Entities;

namespace AulacLichKham.Controllers
{
    [Tags("Thực hiện dịch vụ")]
    [Route("ServicePfm")]
    public class ServicePfmOfPntController : BaseController
    {
        private readonly IServicePfmOfPntRepository _service;
        private readonly ILogger<ServicePfmOfPntController> _logger;
        private readonly IMapper _mapper;
        public ServicePfmOfPntController(ILogger<ServicePfmOfPntController> logger, IServicePfmOfPntRepository service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// CancelServicePfmOfPnt
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("Cancel")]
        public ActionResult<SuccessResponse<ServicePfmOfPntResponse>> ItemsCancel([FromForm] ServicePfmOfPnt request)
        {
            var ServicePfmOfPnts = _service.Execute(request);

            return Ok(new SuccessResponse<ServicePfmOfPntResponse>(
                new ServicePfmOfPntResponse()
                {
                    StatusCode = ServicePfmOfPnts
                }
            ));
        }

        /// <summary>
        /// dich vụ PfmOfPnt
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("Set")]
        public ActionResult<SuccessResponse<ServicePfmOfPntResponse>> ItemsSet([FromForm] ServicePfmOfPnt request)
        {
            var ServicePfmOfPnts = _service.Execute(request);

            return Ok(new SuccessResponse<ServicePfmOfPntResponse>(
                new ServicePfmOfPntResponse()
                {
                    StatusCode = ServicePfmOfPnts
                }
            ));
        }
    }
}
