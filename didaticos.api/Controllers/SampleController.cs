using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace didaticos.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        public SampleController()
        {
            
        }

        [HttpGet]
        [Route("select")]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}
