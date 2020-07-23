using SyncLogsElasticsearch.Infra.Structs;
using System;

namespace SyncLogsElasticsearch.Domain.Features.Hosts
{
    public interface IHostRepository
    {
        Result<Exception, Host> Get();
    }
}
