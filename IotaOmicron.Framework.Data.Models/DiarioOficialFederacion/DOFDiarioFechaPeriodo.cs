using System.Collections.Generic;

namespace IotaOmicron.Framework.Data.Models.DiarioOficialFederacion
{
    public class DOFEdicionData
    {
        public object CodImagen { get; set; }
        public int CodDiario { get; set; }
        public object Pagina { get; set; }
        public object TipoArchivo { get; set; }
        public object NombreArchivo { get; set; }
        public string CodSeccion { get; set; }
        public object TipoPagina { get; set; }
        public string PaginaIni { get; set; }
        public string PaginaMax { get; set; }
        public int Orden { get; set; }
    }

    public class DOFDiarioFechaPeriodo
    {
        public int MessageCode { get; set; }
        public string Response { get; set; }
        public IEnumerable<DOFEdicionData> Extraordinaria { get; set; }
        public IEnumerable<DOFEdicionData> Vespertina { get; set; }
        public IEnumerable<DOFEdicionData> Matutina { get; set; }
    }
}
