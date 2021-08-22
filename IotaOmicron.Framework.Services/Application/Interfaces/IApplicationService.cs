using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IotaOmicron.Framework.Services.Application.Interfaces
{
    public interface IApplicationService
    {
        Task<int> CreateApplication(string appName, string userName);
    }
}
