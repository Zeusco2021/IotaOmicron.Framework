namespace IotaOmicron.Framework.Data.Common.Interfaces
{
    public interface IAppManagementConfig
    {
        public string LocalAppManagementConnectionString { get; set; }
        public string RemoteAppManagementConnectionString { get; set; }
    }
}
