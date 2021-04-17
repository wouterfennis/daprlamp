using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dapr.Client;

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
        public ActionResult Webhook([FromServices] DaprClient daprClient)
        {
            // Convert json to event and publish to topic using dapr
            daprClient.PublishEventAsync("pubsub", "buildname");
            return Ok();
        }
    }
}
