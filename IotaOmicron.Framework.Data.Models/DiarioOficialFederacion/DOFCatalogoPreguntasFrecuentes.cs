using System.Collections.Generic;

namespace IotaOmicron.Framework.Data.Models.DiarioOficialFederacion
{
    public class DOFCatalogoPreguntasFrecuentesData
    {
        public string Id { get; set; }
        public string Value { get; set; }
    }

    public class DOFCatalogoPreguntasFrecuentes
    {
        public int MessageCode { get; set; }
        public string Response { get; set; }
        public IEnumerable<DOFCatalogoPreguntasFrecuentesData> Lista { get; set; }
    }
}
