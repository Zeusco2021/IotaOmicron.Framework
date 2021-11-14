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
            _dbHandler        = dbHandler;
        }

        public async Task<string> CreateApplication(string appCode, string appName, string userName)
        {
            var parameters = new { pApplicationCode = appCode, pApplicationName = appName, pCreatedBy = userName, pErrorNumber = string.Empty };
            var response   = await _dbHandler.ExecuteAsync(_connectionString, "application_management.CreateApplication", CommandType.StoredProcedure, parameters);
            return parameters.pErrorNumber;
        }
        public async Task<string> UpdateApplication(int appNumber, string appCode, string appName, string userName)
        {
            var parameters = new { pApplicationCode = appCode, pApplicationName = appName, pCreatedBy = userName, pErrorNumber = string.Empty };
            var response = await _dbHandler.ExecuteAsync(_connectionString, "application_management.UpdateApplication", CommandType.StoredProcedure, parameters);
            return parameters.pErrorNumber;
        }
    }
}