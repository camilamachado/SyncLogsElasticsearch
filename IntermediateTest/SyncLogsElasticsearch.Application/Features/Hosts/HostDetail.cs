using MediatR;
using SyncLogsElasticsearch.Domain.Features.Hosts;
using SyncLogsElasticsearch.Infra.Structs;
using System;
using Microsoft.Extensions.Logging;

namespace SyncLogsElasticsearch.Application.Features.Hosts
{
    public class HostDetail
    {
        public class Query : IRequest<Result<Exception, Host>> { }

        public class QueryHandler : RequestHandler<Query, Result<Exception, Host>>
        {
            private readonly IHostRepository _repository;
            public ILogger<HostDetail> _logger;

            public QueryHandler(IHostRepository repository, ILogger<HostDetail> logger)
            {
                _repository = repository;
                _logger = logger;
            }

            protected override Result<Exception, Host> Handle(Query request)
            {
                _logger.LogError("ESSE É UM LOG DA CAMADA DE APLICAÇÃO");
                return _repository.Get();
            }
        }
    }
}
