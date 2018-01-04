using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EverythingIsFine.Controllers
{
    [Route("")]
    public class DefaultController : Controller
    {        
        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Post()
        {
            return Ok();
        }

        [HttpPut]
        public ActionResult Put()
        {
            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return Ok();
        }
    }
}
