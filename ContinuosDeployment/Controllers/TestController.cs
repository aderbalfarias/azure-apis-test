using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ContinuosDeployment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET: api/Test
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[]
            {
                "Aderbal Farias",
                "Test App",
                "Wow"
            };
        }

        // GET: api/Test/go
        [HttpGet]
        public IEnumerable<string[]> Go()
        {
            var v1 = new string[]
            {
                "Say my name",
                "I give up on you",
                "Tell me something more"
            };

            var v2 = new string[]
            {
                "Pizza hut is the best",
            };

            var list = new List<string[]> { v1, v2 };

            return list;
        }

        // GET: api/Test/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Test
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Test/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
