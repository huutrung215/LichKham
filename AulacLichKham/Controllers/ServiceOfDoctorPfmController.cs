using AulacLichKham.DTO.Province;
using AulacLichKham.DTO;
using AulacLichKham.Modules.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AulacLichKham.Modules.Interfaces.Repositories;
using AulacLichKham.DTO.FuncExam;
using AulacLichKham.Modules.Entities;

namespace AulacLichKham.Controllers
{
    [Tags("Dịch vụ thực hiện theo bác sỹ")]
    [Route("ServiceOfDoctorPfm")]
    public class ServiceOfDoctorPfmController : BaseController
    {
        private readonly IServiceOfDoctorPfmRepository _service;
        private readonly ILogger<ServiceOfDoctorPfmController> _logger;
        private readonly IMapper _mapper;
        public ServiceOfDoctorPfmController(ILogger<ServiceOfDoctorPfmController> logger, IServiceOfDoctorPfmRepository service, IMapper mapper)
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
        public ActionResult<SuccessResponse<ServiceOfDoctorPfmDTO[]>> Items([FromQuery] ServiceOfDoctorPfmParam request)
        {
            var ServiceOfDoctorPfms = _service.Gets_ServiceOfDoctorPfm(request);
            var ServiceOfDoctorPfmDTOs = ServiceOfDoctorPfms.Select(_mapper.Map<ServiceOfDoctorPfmDTO>).ToArray();

            return Ok(new SuccessResponse<ServiceOfDoctorPfmDTO[]>(
                ServiceOfDoctorPfmDTOs
            ));
        }
    }
}
