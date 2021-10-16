using System.Collections.Generic;

namespace IotaOmicron.Framework.Data.Models.DiarioOficialFederacion
{
    public class DOFCatalogoAreasData
    {
        public string Id { get; set; }
        public string Value { get; set; }
    }

    public class DOFCatalogoAreas
    {
        public int MessageCode { get; set; }
        public string Response { get; set; }
        public IEnumerable<DOFCatalogoAreasData> Lista { get; set; }
    }
}
