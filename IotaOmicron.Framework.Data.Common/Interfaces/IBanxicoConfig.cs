using IotaOmicron.Framework.Data.Common.Config;

namespace IotaOmicron.Framework.Data.Common.Interfaces
{
    public interface IBanxicoConfig
    {
        public BanxicoToken ApiTokenHeader { get; set; }
        public string BaseUri { get; set; }
    }
}
