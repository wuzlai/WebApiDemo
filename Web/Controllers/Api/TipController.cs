using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers.Api
{
    [ApiController]
    [Route("[controller]/[action]")]
    //[Route("Msg/[action]")]
    public class TipController : Controller
    {

        [HttpGet]
        public IActionResult Test()
        {
            return Content("test");
        }

        [HttpGet]
        public IActionResult TestId(string id)
        {
            return Content("test:"+id);
        }

        [HttpGet]
        public IActionResult TestModel([FromQuery] RequestDTO dto)
        {

            return Content("TestModel:" + dto.id+","+dto.name);
        }

    }


    public class RequestDTO
    {
        public string id { get; set; }

        public string name { get; set; }
    }
}
