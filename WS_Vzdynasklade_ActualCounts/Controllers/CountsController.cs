using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WS_Vzdynasklade_ActualCounts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountsController : ControllerBase
    {
        // GET: api/Counts
        [HttpGet]
        public IEnumerable<int> Get()
        {
            CountsObject co = new CountsObject();
            //co.TestData();  //int[] counts = new int[] { 10, 20, 30, 40, 50, 60 };
            co.RandomData();
            int[] counts = co.GetValues();

            return counts;
        }

        // GET: api/Counts/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Counts
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Counts/5
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
