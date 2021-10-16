using System.Collections.Generic;

namespace IotaOmicron.Framework.Data.Models.DiarioOficialFederacion
{

    public class DOFCatalogoQuejasContactoData
    {
        public string Id { get; set; }
        public string Value { get; set; }
    }

    public class DOFCatalogoQuejasContacto
    {
        public int MessageCode { get; set; }
        public string Response { get; set; }
        public IEnumerable<DOFCatalogoQuejasContactoData> Lista { get; set; }
    }
}
