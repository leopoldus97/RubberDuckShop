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
            
        }

        [HttpPost]
        public ActionResult<RubberDuck> Post()
        {

        }

        [HttpPut]
        public ActionResult<RubberDuck> Put()
        {

        }

        [HttpDelete]
        public ActionResult<bool> Delete()
        {

        }

        [HttpGet]
        public ActionResult<List<RubberDuck>> GetSorted()
        {

        }
    }
}