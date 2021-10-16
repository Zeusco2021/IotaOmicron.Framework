using System.Collections.Generic;

namespace IotaOmicron.Framework.Data.Models.DiarioOficialFederacion
{
    public class DOFNotasTopicoData
    {
        public int CodNota { get; set; }
        public int CodDiario { get; set; }
        public string CodEdicion { get; set; }
        public string CodSeccion { get; set; }
        public string Fecha { get; set; }
        public string Pagina { get; set; }
        public string Titulo { get; set; }
        public string CodOrgaUno { get; set; }
        public string CodOrgaDos { get; set; }
        public int CodDocumento { get; set; }
        public string Nombre { get; set; }
    }

    public class DOFNotasTopico
    {
        public int MessageCode { get; set; }
        public string Response { get; set; }
        public IEnumerable<DOFNotasTopicoData> NotasTopicos { get; set; }
        public int TotalRegistros { get; set; }
    }
}
