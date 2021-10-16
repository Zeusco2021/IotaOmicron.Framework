using System.Collections.Generic;

namespace IotaOmicron.Framework.Data.Models.DiarioOficialFederacion
{
    public class CatalogoEstadosData
    {
        public string Id { get; set; }
        public string Value { get; set; }
    }

    public class DOFCatalogoEstados
    {
        public int MessageCode { get; set; }
        public string Response { get; set; }
        public IEnumerable<CatalogoEstadosData> Lista { get; set; }
    }
}
