using System.Collections.Generic;

namespace IotaOmicron.Framework.Data.Models.DiarioOficialFederacion
{
    public class DOFNotaDiarioData
    {
        public int CodNota { get; set; }
        public string Titulo { get; set; }
        public string CodSeccion { get; set; }
        public string Fecha { get; set; }
        public int CodDiario { get; set; }
        public object Contenido { get; set; }
        public object ContenidoTxt { get; set; }
        public object CadenaContenido { get; set; }
        public object ExisteHtml { get; set; }
        public object ExisteDoc { get; set; }
        public object ExisteImagen { get; set; }
        public string TipoNota { get; set; }
        public int Estado { get; set; }
        public int Pagina { get; set; }
        public int PaginaHasta { get; set; }
        public object TiempoLectura { get; set; }
        public object NombreCodOrgaUno { get; set; }
        public string CodOrgaUno { get; set; }
        public string CodOrgaDos { get; set; }
        public object CodOrgaTres { get; set; }
        public object CodOrgaCuatro { get; set; }
        public object NombOrganismo { get; set; }
        public double Orden { get; set; }
        public object NroRef { get; set; }
        public object CodEdicion { get; set; }
        public object TamanioContenido { get; set; }
        public object OrdenSeccion { get; set; }
        public object ExistePdf { get; set; }
    }

    public class DOFNotasDiario
    {
        public int MessageCode { get; set; }
        public string Response { get; set; }
        public object Audio { get; set; }
        public IEnumerable<DOFNotaDiarioData> Notas { get; set; }
    }

}
