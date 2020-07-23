using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SyncLogsElasticsearch.Domain.Features.Hosts;
using SyncLogsElasticsearch.Infra.Data.Features.Hosts;

namespace SyncLogsElasticsearch.WepAPI.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {

            //services.AddScoped<NDDIntegrationToolDbContext>();
            services.AddScoped<IHostRepository, HostRepository>();

        }
    }
}