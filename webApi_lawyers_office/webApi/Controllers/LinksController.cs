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
    public class LinksController : ControllerBase
    {
        IlinksBll bll;
        public LinksController(IlinksBll _bll)
        {
            bll = _bll;
        }

        [HttpGet("getAll")]
        public ActionResult<List<LinksDto>> getAll()
        {
            return Ok(bll.GetAll());
        }

        [HttpGet("getById/{id}")]
        public ActionResult<LinksDto> getById(int id)
        {
            return Ok(bll.GetById(id));
        }

        [HttpPost("post")]
        public ActionResult<LinksDto> post([FromBody] LinksDto obj)
        {
            return Ok(bll.post(obj));
        }


        [HttpPut("put")]
        public ActionResult<LinksDto> put([FromBody] LinksDto obj)
        {
            return Ok(bll.put(obj));
        }


        [HttpDelete("delete/{id}")]
        public ActionResult<LinksDto> delete(int id)
        {
            return Ok(bll.delete(id));
        }

    }
}
