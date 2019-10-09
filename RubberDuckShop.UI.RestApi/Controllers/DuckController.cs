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
        public ActionResult<RubberDuck> Get(int id)
        {
            return _rubberDuckService.GetDuckById(id);
        }

        // POST api/values
        [HttpPost]
        public ActionResult<RubberDuck> Post([FromBody] RubberDuck rubberDuck)
        {
            return _rubberDuckService.AddDuck(rubberDuck);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<RubberDuck> Put(int id, [FromBody] RubberDuck rubberDuck)
        {
            return _rubberDuckService.UpdateDuck(rubberDuck);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<RubberDuck> Delete(int id)
        {
            return _rubberDuckService.DeleteDuck(id);
        }
    }
}