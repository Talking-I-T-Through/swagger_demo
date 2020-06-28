using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/Greeting")]
    public class GreetingController : Controller
    {
   
        public IActionResult SayHello([FromQuery] string name)
        {
            return Ok($"Hello {name}");
        }


        public IActionResult SayHelloByPost([FromBody] string name)
        {
            return Ok($"Hello {name}");
        }
    }
}
