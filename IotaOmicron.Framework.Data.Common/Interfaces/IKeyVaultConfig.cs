namespace IotaOmicron.Framework.Data.Common.Interfaces
{
    public interface IKeyVaultConfig
    {
        public string LocalConnectionString { get; set; }
        public string RemoteConnectionString { get; set; }
    }
}
