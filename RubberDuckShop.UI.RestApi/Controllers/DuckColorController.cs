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
    public class DuckColorController : ControllerBase
    {
        readonly IDuckColorService _duckColorService;
        public DuckColorController(IDuckColorService service)
        {
            _duckColorService = service;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<DuckColor>> Get()
        {
            if (_duckColorService.getDuckColors().ToList().Count == 0)
            {
                return BadRequest($"No duck colors to be listed.");
            }
            return _duckColorService.getDuckColors();
        }
        [HttpGet("{id}")]
        public ActionResult<DuckColor> Get(int id)
        {
            List<DuckColor> duckColors = _duckColorService.getDuckColors().ToList();
            foreach (DuckColor duckColor in duckColors)
            {
                if (duckColor.ID != _duckColorService.getDuckColorById(id).ID)
                {
                    return BadRequest($"Duck color not found");
                }
            }
            return Ok($"{_duckColorService.getDuckColorById(id).Name} found.");
        }

        // POST api/values
        [HttpPost]
        public ActionResult<DuckColor> Post([FromBody] DuckColor duckColor)
        {
            List<DuckColor> allDuckColors = _duckColorService.getDuckColors().ToList();
            foreach (var item in allDuckColors)
            {
                if (string.IsNullOrEmpty(duckColor.Name) || duckColor.ID <= 0)
                {
                    return BadRequest($"Check your input!");
                }
                if (item.ID == duckColor.ID)
                {
                    return BadRequest($"ID already taken. Choose another ID!");
                }

            }
            return _duckColorService.addDuckColor(duckColor);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<DuckColor> Put(int id, [FromBody] DuckColor duckColor)
        {
            if (id == duckColor.ID)
            {
                return _duckColorService.updateDuckColor(duckColor);
            }

            else if (id < 1)
            {
                return BadRequest($"ID not valid. It must be higher then 0.");
            }

            return duckColor;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<DuckColor> Delete(int id)
        {
            var duckColor = _duckColorService.getDuckColorById(id);
            if (duckColor == null)
            {
                return StatusCode(404, $"Duck color not found with ID \"{id}\"");
            }
            return _duckColorService.deleteDuckColor(id);
        }
    }
}