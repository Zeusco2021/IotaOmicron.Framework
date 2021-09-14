using IotaOmicron.Framework.Data.Common.Interfaces;

namespace IotaOmicron.Framework.Data.Common.Config
{
    public class BanxicoToken : IBanxicoToken
    {
        public const string TokenName = "Token";

        public string HeaderName { get; set; }
        public string APIKey { get; set; }
    }
}
