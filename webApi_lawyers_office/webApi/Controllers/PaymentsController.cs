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
    public class PaymentsController : Controller
    {
        IpaymentsBll bll;
        public PaymentsController(IpaymentsBll _bll)
        {
            bll = _bll;
        }

        [HttpGet("getAll")]
        public ActionResult<List<PaymentsDto>> getAll()
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
        public ActionResult<PaymentsDto> getById(int id)
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
        public ActionResult<CitiesDto> post([FromBody] PaymentsDto obj)
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
        public ActionResult<CitiesDto> put([FromBody] PaymentsDto obj)
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
        public ActionResult<PaymentsDto> delete(int id)
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
