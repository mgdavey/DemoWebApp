using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoSvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShutdownTestController : ControllerBase
    {
        // GET: api/ShutdownTest
        [HttpGet(Name ="GetNoDelay")]
        [Route("GetNoDelay")]
        public async Task<IActionResult> GetNoDelay()
        {
            await Task.Delay(100);
            return Ok("No-delay call returned");
            
        }

        // GET: api/ShutdownTest/5
        [HttpGet( Name = "GetWithDelay")]
        [Route("GetWithDelay")]
        public async Task<string> GetWithDelay()
        {
           // var delay = int.Parse(Environment.GetEnvironmentVariable("CallDelayTime"));
            await Task.Delay(60000);
            return "60 sec Delay request returned";
        }

       
       
    }
}
