﻿using BLL.interfaces;
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
    public class CitiesController : ControllerBase
    {
        IcitiesBll bll;
        public CitiesController(IcitiesBll _bll)
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

        [HttpPost("post")]
        public ActionResult<CitiesDto> post([FromBody] CitiesDto obj)
        {
            return Ok(bll.post(obj));
        }


        [HttpPut("put")]
        public ActionResult<CitiesDto> put([FromBody] CitiesDto obj)
        {
            return Ok(bll.put(obj));
        }


        [HttpDelete("delete/{id}")]
        public ActionResult<CitiesDto> delete(int id)
        {
            return Ok(bll.delete(id));
        }

    }
}