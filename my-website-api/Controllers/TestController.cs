using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace my_website_api.Controllers
{

    public class myDTO
    {
        public string name;
        public string pass;
        public int count;
    }

    [Route("api/[controller]")]
    public class TestController : Controller
    {

        // POST api/test/testpost
        [HttpPost("testpost")]
        public myDTO Testpost([FromBody]myDTO value)
        {
            Console.WriteLine(value.name);
            value.count++;
            return value;
            //Change string to a RDTO
            //Change void to a SDTO
        }
    }
}
