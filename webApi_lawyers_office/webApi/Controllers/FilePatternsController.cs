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
    public class FilePatternsController : ControllerBase
    {
        IfilePatternsBll bll;
        public FilePatternsController(IfilePatternsBll _bll)
        {
            bll = _bll;
        }

        [HttpGet("getAll")]
        public ActionResult<List<FilePatternsDto>> getAll()
        {
            return Ok(bll.GetAll());
        }

        [HttpGet("getById/{id}")]
        public ActionResult<FilePatternsDto> getById(int id)
        {
            return Ok(bll.GetById(id));
        }

        [HttpPost("post")]
        public ActionResult<FilePatternsDto> post([FromBody] FilePatternsDto obj)
        {
            return Ok(bll.post(obj));
        }


        [HttpPut("put")]
        public ActionResult<FilePatternsDto> put([FromBody] FilePatternsDto obj)
        {
            return Ok(bll.put(obj));
        }


        [HttpDelete("delete/{id}")]
        public ActionResult<FilePatternsDto> delete(int id)
        {
            return Ok(bll.delete(id));
        }

    }
}
