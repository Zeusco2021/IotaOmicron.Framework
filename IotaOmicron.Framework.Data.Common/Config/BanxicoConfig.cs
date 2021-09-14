using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IotaOmicron.Framework.Data.Common.Interfaces;


namespace IotaOmicron.Framework.Data.Common.Config
{
    public class BanxicoConfig : IBanxicoConfig
    {
        public BanxicoToken ApiTokenHeader { get; set; }
        public string BaseUri { get; set; }

        public BanxicoConfig(BanxicoToken banxicoToken)
        {
            ApiTokenHeader = banxicoToken;
        }
    }
}
