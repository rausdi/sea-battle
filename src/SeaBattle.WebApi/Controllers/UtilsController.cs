using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaBattle.WebApi.Controllers
{
    [Route("[controller]")]
    public class UtilsController : BaseController
    {
        [AllowAnonymous]
        [HttpGet("ping")]
        //http://localhost:5000/utils/ping
        public IActionResult Ping()
        {
            return Ok("pong");
        }
    }
}
