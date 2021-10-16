namespace IotaOmicron.Framework.Data.Common.Interfaces
{
    public interface IKeyVaultConfig
    {
        string LocalConnectionString { get; set; }
        string RemoteConnectionString { get; set; }
    }
}
