using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RubberDuckShop.Core.ApplicationService;
using RubberDuckShop.Core.Entity;
using RubberDuckShop.Core.Entity.Filtering;

namespace RubberDuckShop.UI.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuckController : ControllerBase
    {
        readonly IRubberDuckService _rubberDuckService;

        public DuckController(IRubberDuckService rubberDuckService)
        {
            _rubberDuckService = rubberDuckService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<RubberDuck>> Get([FromQuery]Filter filter)
        {
            return _rubberDuckService.GetSortedDucks(filter);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}