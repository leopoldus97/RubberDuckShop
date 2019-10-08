using System;
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
            List<DuckPattern> duckPatterns = _duckPatternService.GetDuckPatterns().ToList();
            foreach (DuckPattern duckPattern in duckPatterns)
            {
                if (duckPattern.ID != _duckPatternService.GetDuckPatternById(id).ID)
                {
                    return BadRequest($"Duck pattern not found");
                }
            }
            return Ok($"{_duckPatternService.GetDuckPatternById(id).Name} found.");
        }

        // POST api/values
        [HttpPost]
        public ActionResult<DuckPattern> Post([FromBody] DuckPattern duckPattern)
        {
            List<DuckPattern> allDuckPatterns = _duckPatternService.GetDuckPatterns().ToList();
            foreach (var item in allDuckPatterns)
            {
                if (string.IsNullOrEmpty(duckPattern.Name) || duckPattern.ID <= 0)
                {
                    return BadRequest($"Check your input!");
                }
                if (item.ID == duckPattern.ID)
                {
                    return BadRequest($"ID already taken. Choose another ID!");
                }

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
            var duckPattern = _duckPatternService.GetDuckPatternById(id);
            if (duckPattern == null)
            {
                return StatusCode(404, $"Duck pattern not found with ID \"{id}\"");
            }
            return _duckPatternService.DeleteDuckPattern(id);
        }
    }
}