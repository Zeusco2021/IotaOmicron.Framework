using System.Threading.Tasks;

namespace IotaOmicron.Framework.Repositories.Application.Interfaces
{
    public interface IApplicationRepository
    {
        Task<string> CreateApplication(string appCode, string appName, string userName);
    }
}
