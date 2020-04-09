using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JsonApis.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Ping";
        }
    }
}