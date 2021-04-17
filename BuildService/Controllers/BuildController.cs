using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dapr.Client;
using System.Threading.Tasks;

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
        public async Task<ActionResult> Webhook([FromServices] DaprClient daprClient)
        {
            // Convert json to event and publish to topic using dapr
            await daprClient.PublishEventAsync("pubsub", "asdf");
            return Ok();
        }
    }
}
