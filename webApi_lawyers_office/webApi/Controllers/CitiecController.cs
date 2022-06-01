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
    public class CitiecController : ControllerBase
    {
        IcitiesBll bll;
        public CitiecController(IcitiesBll _bll)
        {
            bll = _bll;
        }

        [HttpGet("getAll")]
        public ActionResult<List<CitiesDto>> getAll()
        {
            return Ok(bll.GetAll());
        }

        [HttpGet("getById/{id}")]
        public ActionResult<CitiesDto> getById(int id)
        {
            return Ok(bll.GetById(id));
        }

        [HttpPost("postCity")]
        public ActionResult<CitiesDto> postCity([FromBody] CitiesDto c)
        {

            return Ok(bll.post(c));
        }
    }
}
