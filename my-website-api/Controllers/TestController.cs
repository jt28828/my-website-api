using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace my_website_api.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {

        // POST api/test/testpost
        [HttpPost("testpost")]
        public void Testpost([FromBody]string value)
        {
         //Change string to a RDTO
         //Change void to a SDTO
        }
    }
}
