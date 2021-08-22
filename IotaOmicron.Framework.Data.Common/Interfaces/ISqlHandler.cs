using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data;

namespace IotaOmicron.Framework.Data.Common.Interfaces
{
    public interface ISqlHandler
    {
        Task<IEnumerable<T>> QueryAsync<T>(string connectionString, string command, CommandType commandType, object parameters) where T : class;
        Task<int> ExecuteAsync(string connectionString, string command, CommandType commandType, object parameters);
    }
}
