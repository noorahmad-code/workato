using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WorkatoPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        { 
            return "value";
        }

        // POST api/values
        [HttpPost]
        public TestPOST Post([FromForm] string value)
        {
            TestPOST testPOST = new TestPOST();
            testPOST.ReturnValue = "We received your request from WorkAto, our support team is working on it. Your email address is " + value;
            return testPOST;
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
    public class TestPOST
    {
        public string ReturnValue { get; set; }
    }
}
