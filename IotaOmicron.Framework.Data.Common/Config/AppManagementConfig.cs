using IotaOmicron.Framework.Data.Common.Interfaces;

namespace IotaOmicron.Framework.Data.Common.Config
{
    public class AppManagementConfig : IAppManagementConfig
    {
        public string LocalAppManagementConnectionString { get; set; }
        public string RemoteAppManagementConnectionString { get; set; }

        public AppManagementConfig(IKeyVaultConfig keyVaultConfig)
        {
            LocalAppManagementConnectionString = keyVaultConfig.LocalConnectionString;
            RemoteAppManagementConnectionString = keyVaultConfig.RemoteConnectionString;
        }
    }
}
