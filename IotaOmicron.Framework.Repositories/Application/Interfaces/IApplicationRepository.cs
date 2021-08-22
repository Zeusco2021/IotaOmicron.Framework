using System.Threading.Tasks;

namespace IotaOmicron.Framework.Repositories.Application.Interfaces
{
    public interface IApplicationRepository
    {
        Task<int> CreateApplication(string appName, string userName);
    }
}
