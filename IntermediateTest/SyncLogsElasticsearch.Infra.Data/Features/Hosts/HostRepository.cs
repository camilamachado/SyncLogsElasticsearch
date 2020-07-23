using SyncLogsElasticsearch.Domain.Features.Hosts;
using SyncLogsElasticsearch.Infra.Structs;
using System;

namespace SyncLogsElasticsearch.Infra.Data.Features.Hosts
{
    public class HostRepository : IHostRepository
    {
        public Result<Exception, Host> Get()
        {
            var host = new Host();
            host.Name = Environment.MachineName;

            return host;
        }
    }
}
