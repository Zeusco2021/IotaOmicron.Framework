using System;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace IotaOmicron.Framework.Utilities.Azure
{
    public static class IotaOmicronKeyVault
    {
        public static string GetSecretFromKeyVault(string keyVaultName, string secretName)
        {
            var client = new SecretClient(new Uri($"https://{keyVaultName}.vault.azure.net/"), new DefaultAzureCredential());
            KeyVaultSecret iotaOmicronSecret = client.GetSecret(secretName);
            return iotaOmicronSecret.Value;
        }
    }
}
