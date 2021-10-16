using System.Collections.Generic;

namespace IotaOmicron.Framework.Data.Models.DiarioOficialFederacion
{
    public class DOFIndicadoresData
    {
        public int CodIndicador { get; set; }
        public int CodTipoIndicador { get; set; }
        public string Fecha { get; set; }
        public string Valor { get; set; }
    }

    public class DOFIndicadores
    {
        public int MessageCode { get; set; }
        public string Response { get; set; }
        public IEnumerable<DOFIndicadoresData> ListaIndicadores { get; set; }
        public int? TotalIndicadores { get; set; }
    }
}
