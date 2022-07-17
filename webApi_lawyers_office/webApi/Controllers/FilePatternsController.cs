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
        public ActionResult<FilePatternsDto> getById(int id)
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
        public ActionResult<FilePatternsDto> post([FromBody] FilePatternsDto obj)
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
        public ActionResult<FilePatternsDto> put([FromBody] FilePatternsDto obj)
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
        public ActionResult<FilePatternsDto> delete(int id)
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
