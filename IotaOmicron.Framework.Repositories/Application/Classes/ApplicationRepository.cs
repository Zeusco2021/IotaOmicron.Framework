using IotaOmicron.Framework.Data.Common.Interfaces;
using IotaOmicron.Framework.Repositories.Application.Interfaces;
using System.Threading.Tasks;
using System.Data;

namespace IotaOmicron.Framework.Repositories.Application.Classes
{
    public class ApplicationRepository : IApplicationRepository
    {
        private string _connectionString;
        private ISqlHandler _dbHandler;

        public ApplicationRepository(IAppManagementConfig appManagementConfig, ISqlHandler dbHandler)
        {
            _connectionString = appManagementConfig.LocalAppManagementConnectionString;
            _dbHandler = dbHandler;
        }

        public async Task<int> CreateApplication(string appName, string userName)
        {
            var parameters = new { pApplicationName = appName, pCreatedBy = userName };
            return await _dbHandler.ExecuteAsync(_connectionString, "application_management.CreateApplication", CommandType.StoredProcedure, parameters);
        }
    }
}
