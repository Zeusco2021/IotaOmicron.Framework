using IotaOmicron.Framework.Data.Common.Interfaces;
using IotaOmicron.Framework.Utilities.Azure;

namespace IotaOmicron.Framework.Data.Common
{
    public class KeyVaultConfig : IKeyVaultConfig
    {
        public string LocalConnectionString { get; set; }
        public string RemoteConnectionString { get; set; }

        public KeyVaultConfig(string KeyVaultName)
        {
            LocalConnectionString = IotaOmicronKeyVault.GetSecretFromKeyVault(KeyVaultName, "LocalDBConnectionString");
            RemoteConnectionString = IotaOmicronKeyVault.GetSecretFromKeyVault(KeyVaultName, "RemoteDBConnectionString");
        }
    }
}
