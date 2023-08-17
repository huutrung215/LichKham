using AulacLichKham.DTO;
using AulacLichKham.DTO.TaskCareOfPnt;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AulacLichKham.Controllers
{
    [Tags("Chăm sóc bệnh nhân")]
    [Route("task-care-of-pnt")]
    public class TaskCareOfPntController : BaseController
    {
        private readonly ITaskCareOfPntService _service;
        private readonly ILogger<TaskCareOfPntController> _logger;
        private readonly IMapper _mapper;
        public TaskCareOfPntController(ILogger<TaskCareOfPntController> logger, ITaskCareOfPntService service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// Thông tin chăm sóc bệnh nhân.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("")]
        public ActionResult<SuccessResponse<TaskCareOfPntDTO[]>> Items([FromQuery]TaskCareOfPntRequest request)
        {
            var result = _service.Gets_ListTaskCareTreamentOfPnt(request);
            var data = result.Select(_mapper.Map<TaskCareOfPntDTO>).ToArray();

            return Ok(new SuccessResponse<TaskCareOfPntDTO[]>(
                data
            ));
        }

        [HttpGet("info")]
        public ActionResult<SuccessResponse<TaskCareOfPntDTO>> Item_InfoTaskCareTreamentOfPntRequest([FromQuery] InfoTaskCareTreamentOfPntRequest request)
        {
            var result = _service.Get_InfoTaskCareTreamentOfPnt(request);
            var data = _mapper.Map<TaskCareOfPntDTO>(result);
            return Ok(new SuccessResponse<TaskCareOfPntDTO>(
                data
            ));
        }

        [HttpPost("")]
        public ActionResult Set([FromForm] SetTaskCareOfPntRequest request)
        {
            if (_service.Set_TaskCareTreamentOfPnt(request))
            {
                return Ok();
            }
            else { return BadRequest(); }
            
        }
        [HttpDelete("")]
        public ActionResult Delete([FromForm] InfoTaskCareTreamentOfPntRequest request)
        {
            if (_service.Delete_TaskCareTreamentOfPnt(request))
            {
                return Ok();
            }
            else { return BadRequest(); }

        }
        [HttpGet("infoptt")]
        public ActionResult<SuccessResponse<VchPttPntDTO[]>> Items_VchPttPnt([FromQuery] TaskCareOfPntRequest request)
        {
            var result = _service.Gets_InfoVchPttPnt(request);
            var data = result.Select(_mapper.Map<VchPttPntDTO>).ToArray();

            return Ok(new SuccessResponse<VchPttPntDTO[]>(
                data
            ));
        }
        [HttpGet("mdnitems")]
        public ActionResult<SuccessResponse<MdnItemsDTO[]>> Items_MdnItems([FromQuery] MdnItemsRequest request)
        {
            var result = _service.Gets_MdnItems(request);
            var data = result.Select(_mapper.Map<MdnItemsDTO>).ToArray();

            return Ok(new SuccessResponse<MdnItemsDTO[]>(
                data
            ));
        }
        [HttpGet("item-subtype")]
        public ActionResult<SuccessResponse<ItemsSubTypeDTO[]>> Items_ItemsSubType()
        {
            var result = _service.Gets_ItemsSubType();
            var data = result.Select(_mapper.Map<ItemsSubTypeDTO>).ToArray();

            return Ok(new SuccessResponse<ItemsSubTypeDTO[]>(
                data
            ));
        }
        [HttpGet("deptpfm-cls")]
        public ActionResult<SuccessResponse<DeptPfmClsDTO[]>> Items_DeptPfmCls()
        {
            var result = _service.Gets_DeptPfmCls();
            var data = result.Select(_mapper.Map<DeptPfmClsDTO>).ToArray();

            return Ok(new SuccessResponse<DeptPfmClsDTO[]>(
                data
            ));
        }
    }
}
