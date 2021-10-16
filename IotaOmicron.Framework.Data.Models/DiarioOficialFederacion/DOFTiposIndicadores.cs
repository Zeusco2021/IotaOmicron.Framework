using System.Collections.Generic;

namespace IotaOmicron.Framework.Data.Models.DiarioOficialFederacion
{
    public class DOFTiposIndicadoresData
    {
        public string Id { get; set; }
        public string Value { get; set; }
    }

    public class DOFTiposIndicadores
    {
        public int MessageCode { get; set; }
        public string Response { get; set; }
        public IEnumerable<DOFTiposIndicadoresData> Lista { get; set; }
    }
}
