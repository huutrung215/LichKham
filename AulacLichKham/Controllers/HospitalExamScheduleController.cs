using AulacLichKham.DTO;
using AulacLichKham.DTO.HospitalExamSchedule;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AulacLichKham.Controllers
{
    [Tags("Thông tin bệnh viện")]
    [Route("hospital-exam")]
    public class HospitalExamScheduleController : BaseController
    {
        private readonly IHospitalExamScheduleService _service;
        private readonly ILogger<HospitalExamScheduleController> _logger;
        private readonly IMapper _mapper;
        public HospitalExamScheduleController(ILogger<HospitalExamScheduleController> logger, IHospitalExamScheduleService service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// Danh sách bệnh viện.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("")]
        public ActionResult<SuccessResponse<HospitalExamScheduleDTO[]>> Items()
        {
            var result = _service.Gets_HospitalExamSchedule();
            var data = result.Select(_mapper.Map<HospitalExamScheduleDTO>).ToArray();

            return Ok(new SuccessResponse<HospitalExamScheduleDTO[]>(
                data
            ));
        }

        /// <summary>
        /// Đăng nhập tài khoản
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("login")]
        public ActionResult<SuccessResponse<LoginESResponseDTO>> Login([FromQuery] LoginRequest request)
        {
            var result = _service.Login_ES(new LoginESRequest() { UserExamID = request.UserExamID, UserExamPass = request.UserExamPass });
            if (result != null)
            {
                var data = _mapper.Map<LoginESResponseDTO>(result);

                return Ok(new SuccessResponse<LoginESResponseDTO>(
                    data
                ));
            }
            return Ok(new ErrorResponse("Tài khoản đăng nhập hoặc mật khẩu không đúng!"));
        }

        /// <summary>
        /// Đăng ký tài khoản
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("register")]
        public ActionResult<SuccessResponse<LoginESResponseDTO>> Register([FromForm] RegisterRequest request)
        {
            var result = _service.Login_ES(new LoginESRequest() { UserExamID = request.UserExamID, UserExamPass = request.UserExamPass });
            if (!string.IsNullOrEmpty(result.UserExamID))
                return Ok(new ErrorResponse("Tài khoản đã tồn tại không thể đăng ký!"));

            if (_service.Register_ES(_mapper.Map<RegisterESRequest>(request)))
                return Ok(new SuccessResponse<string>("Đăng ký tài khoản thành công!"));

            return Ok(new ErrorResponse("Đăng ký tài khoản không thành công!"));
        }
    }
}
