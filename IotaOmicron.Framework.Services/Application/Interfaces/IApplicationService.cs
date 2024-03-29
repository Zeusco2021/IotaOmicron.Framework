﻿using System.Threading.Tasks;

namespace IotaOmicron.Framework.Services.Application.Interfaces
{
    public interface IApplicationService
    {
        Task<string> CreateApplication(string appCode, string appName, string userName);
        Task<string> UpdateApplication(int appNumber, string appCode, string appName, string userName);
    }
}
