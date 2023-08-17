using AulacLichKham.DTO.RegExamFrombDoctor;
using AulacLichKham.DTO;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Aulac.Service.Global;
using Microsoft.AspNetCore.Http;
using Aulac.Service.Rsc.Tags;
using System.Data;
using AulacLichKham.DTO.Quantity;

namespace AulacLichKham.Controllers
{
    [Tags("Lấy số lượng đặt lịch")]
    [Route("quantity-pnt")]
    public class QuantityPntController : BaseController
    {
        private readonly IGetQuantityPntInDayService _service;
        private readonly ILogger<QuantityPntController> _logger;
        private readonly IMapper _mapper;
        public QuantityPntController(ILogger<QuantityPntController> logger, IGetQuantityPntInDayService service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("")]
        public ActionResult<SuccessResponse<QuantityDTO[]>> Items([FromQuery] RegExamParam request)
        {
                var result = _service.Gets_QuantityPntInDay(request);
                var data = result.Select(_mapper.Map<QuantityDTO>).ToArray();

                return Ok(new SuccessResponse<QuantityDTO[]>(
                    data
                ));      
        }
    }
}
