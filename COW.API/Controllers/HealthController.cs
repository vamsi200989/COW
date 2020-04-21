using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using COW.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace COW.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        [Route("healthcheck")]
        public IActionResult HealthCheck()
        {
            return Ok("Healthy");
        }

    }
}