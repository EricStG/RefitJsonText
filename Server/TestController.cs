using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server
{
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string[] values)
        {
            Console.WriteLine(values.Length);
        }
    }
}
