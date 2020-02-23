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
            //return Ok("Healthy");

            var items = new List<Item>
            {
                new Item()
                {
                    ImageUrl = "http",
                    Name = "Thigs",
                    Price = 50,
                    ProductId = Guid.NewGuid(),
                    Quantity = 20
                },
                new Item()
                {
                    ImageUrl = "http",
                    Name = "liver",
                    Price = 50,
                    ProductId = Guid.NewGuid(),
                    Quantity = 20
                },
                new Item()
                {
                    ImageUrl = "http",
                    Name = "wholebody",
                    Price = 50,
                    ProductId = Guid.NewGuid(),
                    Quantity = 20
                },
                new Item()
                {
                    ImageUrl = "http",
                    Name = "Thigs",
                    Price = 50,
                    ProductId = Guid.NewGuid(),
                    Quantity = 20
                },
                new Item()
                {
                    ImageUrl = "http",
                    Name = "Thigs",
                    Price = 50,
                    ProductId = Guid.NewGuid(),
                    Quantity = 20
                }
            };

            return Ok(items);
        }

    }
}