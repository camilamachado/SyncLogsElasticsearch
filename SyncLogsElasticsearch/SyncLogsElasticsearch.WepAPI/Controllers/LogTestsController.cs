using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SyncLogsElasticsearch.WepAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogTestsController : ControllerBase
    {
        public ILogger<LogTestsController> _logger;

        public LogTestsController(ILogger<LogTestsController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Este endpoint cria um log de cada nível
        /// </summary> 
        [HttpPost]
        [Route("all")]
        public ActionResult<IEnumerable<string>> TestAllLevels()
        {

            _logger.LogCritical("ESSE LOG DEVE ESTAR NO NÍVEL CRITICAL");
            _logger.LogDebug("ESSE LOG DEVE ESTAR NO NÍVEL DEBUG");
            _logger.LogError("ESSE LOG DEVE ESTAR NO NÍVEL ERROR");
            _logger.LogInformation("ESSE LOG DEVE ESTAR NO NÍVEL INFORMATION");
            _logger.LogTrace("ESSE LOG DEVE ESTAR NO NÍVEL TRACE");
            _logger.LogWarning("ESSE LOG DEVE ESTAR NO NÍVEL WARNING");

            return new string[] { "SUCESSO", "Confira seu index do Elasticsearch" };
        }

    }
}
