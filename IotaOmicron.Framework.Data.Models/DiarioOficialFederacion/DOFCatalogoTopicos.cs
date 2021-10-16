using System.Collections.Generic;

namespace IotaOmicron.Framework.Data.Models.DiarioOficialFederacion
{
    public class DOFCatalogoTopicosData
    {
        public string Id { get; set; }
        public string Value { get; set; }
    }

    public class DOFCatalogoTopicos
    {
        public int MessageCode { get; set; }
        public string Response { get; set; }
        public IEnumerable<DOFCatalogoTopicosData> Lista { get; set; }
    }
}
