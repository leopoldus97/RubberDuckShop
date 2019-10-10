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
    public class ColorController : ControllerBase
    {
        readonly IDuckColorService _duckColorService;
        public ColorController(IDuckColorService service)
        {
            _duckColorService = service;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<DuckColor>> Get()
        {
            if (_duckColorService.GetDuckColors().ToList().Count == 0)
            {
                return BadRequest($"No duck colors to be listed.");
            }
            return _duckColorService.GetDuckColors();
        }
        [HttpGet("{id}")]
        public ActionResult<DuckColor> Get(int id)
        {
            if (id > _duckColorService.GetDuckColors().Count() || id <= 0)
            {
                return BadRequest($"Color with ID {id} not found. Check your input!");
            }
            return Ok($"Duck color <{_duckColorService.GetDuckColorById(id).Name}> found.");
        }

        // POST api/values
        [HttpPost]
        public ActionResult<DuckColor> Post([FromBody] DuckColor duckColor)
        {
            if (string.IsNullOrEmpty(duckColor.Name))
            {
                return BadRequest($"Check your input!");
            }
            return _duckColorService.AddDuckColor(duckColor);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<DuckColor> Put(int id, [FromBody] DuckColor duckColor)
        {
            if (id == duckColor.ID)
            {
                return _duckColorService.UpdateDuckColor(duckColor);
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
            if (id <= 0 )
            {
                return BadRequest($"Check your input!");
            }
            return _duckColorService.DeleteDuckColor(id);
        }
    }
}