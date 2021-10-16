namespace IotaOmicron.Framework.Data.Common.Interfaces
{
    public interface IAppManagementConfig
    {
        string LocalAppManagementConnectionString { get; set; }
        string RemoteAppManagementConnectionString { get; set; }
    }
}
