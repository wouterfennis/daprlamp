using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BuildService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuildController : ControllerBase
    {
        private readonly ILogger<BuildController> _logger;

        public BuildController(ILogger<BuildController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ActionResult Webhook()
        {
            // Convert json to event and publish to topic using dapr
            return Ok();
        }
    }
}
