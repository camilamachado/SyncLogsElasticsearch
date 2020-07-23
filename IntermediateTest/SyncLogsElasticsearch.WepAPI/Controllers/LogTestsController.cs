using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SyncLogsElasticsearch.Application.Features.Hosts;

namespace SyncLogsElasticsearch.WepAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogTestsController : ControllerBase
    {
        public ILogger<LogTestsController> _logger;
        private readonly IMediator _mediator;

        public LogTestsController(ILogger<LogTestsController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
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

        /// <summary>
        /// Retorna o nome do servidor
        /// </summary>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var response = await _mediator.Send(new HostDetail.Query());

            _logger.LogError("ESSE É UM LOG DA CAMADA DE DISTRIBUIÇÃO");

            return Ok(response);
        }

    }
}
