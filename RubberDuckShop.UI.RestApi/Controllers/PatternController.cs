﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RubberDuckShop.Core.ApplicationService;
using RubberDuckShop.Core.Entity;

namespace RubberDuckShop.UI.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatternController : ControllerBase
    {
        readonly IDuckPatternService _duckPatternService;
        public PatternController(IDuckPatternService service)
        {
            _duckPatternService = service;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<DuckPattern>> Get()
        {
            if (_duckPatternService.GetDuckPatterns().ToList().Count == 0)
            {
                return BadRequest($"No duck patterns to be listed.");
            }
            return _duckPatternService.GetDuckPatterns();
        }
        [HttpGet("{id}")]
        public ActionResult<DuckPattern> Get(int id)
        {
            if (id > _duckPatternService.GetDuckPatterns().Count() || id <= 0)
            {
                return BadRequest($"Pattern with ID {id} not found. Check your input!");
            }
            return Ok($"Duck pattern <{_duckPatternService.GetDuckPatternById(id).Name}> found.");
        }

        // POST api/values
        [HttpPost]
        public ActionResult<DuckPattern> Post([FromBody] DuckPattern duckPattern)
        {
            if (string.IsNullOrEmpty(duckPattern.Name))
            {
                return BadRequest($"Check your input!");
            }
            return _duckPatternService.AddDuckPattern(duckPattern);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<DuckPattern> Put(int id, [FromBody] DuckPattern duckPattern)
        {
            if (id == duckPattern.ID)
            {
                return _duckPatternService.UpdateDuckPattern(duckPattern);
            }

            else if (id < 1)
            {
                return BadRequest($"ID not valid. It must be higher then 0.");
            }

            return duckPattern;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<DuckPattern> Delete(int id)
        {
            if (id <= 0 )
            {
                return BadRequest($"Check your input!");
            }
            return _duckPatternService.DeleteDuckPattern(id);
        }
    }
}