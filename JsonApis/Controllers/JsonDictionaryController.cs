using System.Collections.Generic;
using JsonApis.Interfaces;
using Microsoft.AspNetCore.Mvc;
using JsonApis.Services;

namespace JsonApis.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class JsonDictionaryController : ControllerBase
    {

        [HttpGet]
        public ActionResult<Dictionary<string, string>> Get([FromServices] IJsonReader jsReader)
        {

            return jsReader.GetSerializedJSON<Dictionary<string, string>>("http://country.io/continent.json");
        }
    }
}