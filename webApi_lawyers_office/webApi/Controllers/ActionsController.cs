using BLL.interfaces;
using EntitiesDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionsController : ControllerBase
    {
        IactionsBll bll;
        public ActionsController(IactionsBll _bll)
        {
            bll = _bll;
        }

        [HttpGet("getAll")]
        public ActionResult<List<ActionsDto>> getAll()
        {
            try
            {
                return Ok(bll.GetAll());
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("getById/{id}")]
        public ActionResult<ActionsDto> getById(int id)
        {
            try
            {
                return Ok(bll.GetById(id));
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpPost("post")]
        public ActionResult<ActionsDto> post([FromBody] ActionsDto obj)
        {
            try
            {
                return Ok(bll.post(obj));
            }
            catch
            {
                return BadRequest();
            }
        }


        [HttpPut("put")]
        public ActionResult<ActionsDto> put([FromBody] ActionsDto obj)
        {
            try
            {
                return Ok(bll.put(obj));
            }
            catch
            {
                return NotFound();
            }
        }


        [HttpDelete("delete/{id}")]
        public ActionResult<ActionsDto> delete(int id)
        {
            try
            {
                return Ok(bll.delete(id));
            }
            catch
            {
                return NotFound();
            }
        }

    }
}
