using System;
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
    public class DuckCostumeController : ControllerBase
    {
        readonly IDuckCostumeService _duckCostumeService;
        public DuckCostumeController(IDuckCostumeService service)
        {
            _duckCostumeService = service;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<DuckCostume>> Get()
        {
            if (_duckCostumeService.getDuckCostume().ToList().Count == 0)
            {
                return BadRequest($"No duck costumes to be listed.");
            }
            return _duckCostumeService.getDuckCostume();
        }
        [HttpGet("{id}")]
        public ActionResult<DuckCostume> Get(int id)
        {
            List<DuckCostume> duckCostumes = _duckCostumeService.getDuckCostume().ToList();
            foreach (DuckCostume duckCostume in duckCostumes)
            {
                if (duckCostume.ID != _duckCostumeService.getDuckCostumeById(id).ID)
                {
                    return BadRequest($"Duck costume not found");
                }
            }
            return Ok($"{_duckCostumeService.getDuckCostumeById(id).Name} found.");
        }

        // POST api/values
        [HttpPost]
        public ActionResult<DuckCostume> Post([FromBody] DuckCostume duckCostume)
        {
            List<DuckCostume> allDuckCostumes = _duckCostumeService.getDuckCostume().ToList();
            foreach (var item in allDuckCostumes)
            {
                if (string.IsNullOrEmpty(duckCostume.Name) || duckCostume.ID <= 0)
                {
                    return BadRequest($"Check your input!");
                }
                if (item.ID == duckCostume.ID)
                {
                    return BadRequest($"ID already taken. Choose another ID!");
                }

            }
            return _duckCostumeService.addDuckCostume(duckCostume);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<DuckCostume> Put(int id, [FromBody] DuckCostume duckCostume)
        {
            if (id == duckCostume.ID)
            {
                return _duckCostumeService.updateDuckCostume(duckCostume);
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
            var duckCostume = _duckCostumeService.getDuckCostumeById(id);
            if (duckCostume == null)
            {
                return StatusCode(404, $"Duck costume not found with ID \"{id}\"");
            }
            return _duckCostumeService.deleteDuckCostume(id);
        }
    }
}