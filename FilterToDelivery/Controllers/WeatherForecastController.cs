using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FilterToDelivery.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private ILoggerManager _logger;

        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Here is info message");
            _logger.LogError("Here is error message");
            _logger.LogWarning("Here is warning");
            _logger.LogDebug("Here is debug message");
            return new string[] { "value1", "value2" };
        }
}
}
