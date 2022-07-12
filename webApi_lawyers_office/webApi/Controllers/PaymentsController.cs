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
            return Ok(bll.GetAll());
        }

        [HttpGet("getById/{id}")]
        public ActionResult<PaymentsDto> getById(int id)
        {
            return Ok(bll.GetById(id));
        }

        [HttpPost("post")]
        public ActionResult<CitiesDto> post([FromBody] PaymentsDto obj)
        {
            return Ok(bll.post(obj));
        }


        [HttpPut("put")]
        public ActionResult<CitiesDto> put([FromBody] PaymentsDto obj)
        {
            return Ok(bll.put(obj));
        }


        [HttpDelete("delete/{id}")]
        public ActionResult<PaymentsDto> delete(int id)
        {
            return Ok(bll.delete(id));
        }
    }
}
