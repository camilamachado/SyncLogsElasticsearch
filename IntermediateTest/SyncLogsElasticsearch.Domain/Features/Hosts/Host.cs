namespace SyncLogsElasticsearch.Domain.Features.Hosts
{
    public class Host
    {
        public string Name { get; set; }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
