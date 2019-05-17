using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values/7
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<string>> Get(int id)
        {
            return new string[] { "Jorge Alexis Reuto Salazar", "1018430912" };
        }

        // POST api/values/7
        [HttpPost("{id}")]
        public ActionResult<IEnumerable<string>> Post(int id)
        {
            return new string[] { "Jorge Alexis Reuto Salazar", "1018430912" };
        }
    }
}
