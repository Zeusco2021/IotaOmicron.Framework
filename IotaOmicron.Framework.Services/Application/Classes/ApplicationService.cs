using IotaOmicron.Framework.Services.Application.Interfaces;
using IotaOmicron.Framework.Repositories.Application.Interfaces;
using System.Threading.Tasks;

namespace IotaOmicron.Framework.Services.Application.Classes
{
    public class ApplicationService : IApplicationService
    {
        private readonly IApplicationRepository _applicationRepository;

        public ApplicationService(IApplicationRepository appRepository)
        {
            _applicationRepository = appRepository;
        }

        public async Task<string> CreateApplication(string appCode, string appName, string userName)
        {
            return await _applicationRepository.CreateApplication(appCode, appName, userName);
        }
    }
}
