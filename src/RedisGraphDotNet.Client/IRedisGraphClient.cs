using System.Threading.Tasks;

namespace RedisGraphDotNet.Client
{
    public interface IRedisGraphClient
    {
        Task<bool> DeleteGraphAsync(string graphName);
        Task<ResultSet> QueryAsync(string graphName, string query);
        Task<string> ExplainAsync(string graphName, string query);
    }
}