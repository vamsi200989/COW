using COW.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace COW.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeatController : ControllerBase
    {
        private readonly ILogger<MeatController> logger;
        private readonly IMeatRepository meatRepository;

        public MeatController(ILogger<MeatController> logger, IMeatRepository meatRepository)
        {
            this.logger = logger;
            this.meatRepository = meatRepository;
        }

        [HttpGet]
        [Route("chickenMenu")]
        public IActionResult GetChickenMenu()
        {
            return Ok(meatRepository.GetChickenItems());
        }
    }
}