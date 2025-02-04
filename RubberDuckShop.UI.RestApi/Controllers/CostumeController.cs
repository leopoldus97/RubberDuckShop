﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RubberDuckShop.Core.ApplicationService;
using RubberDuckShop.Core.DomainService;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.UI.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostumeController : ControllerBase
    {
        readonly IDuckCostumeService _duckCostumeService;
        public CostumeController(IDuckCostumeService service)
        {
            _duckCostumeService = service;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<DuckCostume>> Get()
        {
            if (_duckCostumeService.GetDuckCostume().ToList().Count == 0)
            {
                return BadRequest($"No duck costumes to be listed.");
            }
            return _duckCostumeService.GetDuckCostume();
        }
        [HttpGet("{id}")]
        public ActionResult<DuckCostume> Get(int id)
        {
            if (id > _duckCostumeService.GetDuckCostume().Count() || id <= 0)
            {
                return BadRequest($"Costume with ID {id} not found. Check your input!");
            }
            return Ok($"Duck Costume <{_duckCostumeService.GetDuckCostumeById(id).Name}> found.");
        }

        // POST api/values
        [HttpPost]
        public ActionResult<DuckCostume> Post([FromBody] DuckCostume duckCostume)
        {
            if (string.IsNullOrEmpty(duckCostume.Name))
            {
                return BadRequest($"Check your input!");
            }
            return _duckCostumeService.AddDuckCostume(duckCostume);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<DuckCostume> Put(int id, [FromBody] DuckCostume duckCostume)
        {
            if (id == duckCostume.ID)
            {
                return _duckCostumeService.UpdateDuckCostume(duckCostume);
            }

            else if (id < 1)
            {
                return BadRequest($"ID not valid. It must be higher then 0.");
            }

            return duckCostume;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<DuckCostume> Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest($"Check your input!");
            }
            return _duckCostumeService.DeleteDuckCostume(id);
        }
    }
}