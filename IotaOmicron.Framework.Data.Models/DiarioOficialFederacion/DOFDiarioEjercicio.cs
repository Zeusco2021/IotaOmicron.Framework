using System.Collections.Generic;

namespace IotaOmicron.Framework.Data.Models.DiarioOficialFederacion
{
    public class DOFDiarioData
    {
        public int CodDiario { get; set; }
        public string CodEdicion { get; set; }
        public string Fecha { get; set; }
        public object Estado { get; set; }
    }

    public class DOFDiarioEjercicio
    {
        public int MessageCode { get; set; }
        public string Response { get; set; }
        public IEnumerable<DOFDiarioData> ListaDiarios { get; set; }
        public IEnumerable<string> FechasSinPublicacion { get; set; }
    }
}
