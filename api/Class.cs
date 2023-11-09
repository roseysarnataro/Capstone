using System;
using Microsoft.AspNetCore.Mvc;

namespace apicalls
{
    [Route("api/users")]
    public class ApiController : ControllerBase
    {
        [HttpPost]
        public IActionResult Testing()
        {
            return Ok("hi");
        }
    }
}
