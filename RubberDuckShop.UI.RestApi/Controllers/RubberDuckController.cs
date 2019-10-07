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
    public class RubberDuckController : ControllerBase
    {
        readonly IRubberDuckService _rubberDuckService;

        public RubberDuckController(IRubberDuckService rubberDuckService)
        {
            _rubberDuckService = rubberDuckService;
        }

        [HttpGet]
        public ActionResult<RubberDuck> Get()
        {
            return null;
        }

        [HttpPost]
        public ActionResult<RubberDuck> Post()
        {
            return null;
        }

        [HttpPut]
        public ActionResult<RubberDuck> Put()
        {
            return null;
        }

        [HttpDelete]
        public ActionResult<bool> Delete()
        {
            return null;
        }

        [HttpGet]
        public ActionResult<List<RubberDuck>> GetSorted()
        {
            return null;
        }
    }
}