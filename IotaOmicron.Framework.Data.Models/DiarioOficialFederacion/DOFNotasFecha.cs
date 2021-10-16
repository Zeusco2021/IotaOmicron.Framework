using System.Collections.Generic;

namespace IotaOmicron.Framework.Data.Models.DiarioOficialFederacion
{
    public class ImagenesDiario
    {
        public bool MAT { get; set; }
        public bool VES { get; set; }
        public bool EXT { get; set; }
    }

    public class NotasEdicion
    {
        public int CodNota { get; set; }
        public string Titulo { get; set; }
        public string CodSeccion { get; set; }
        public string Fecha { get; set; }
        public int CodDiario { get; set; }
        public string ExisteHtml { get; set; }
        public string ExisteDoc { get; set; }
        public string ExisteImagen { get; set; }
        public int Estado { get; set; }
        public int Pagina { get; set; }
        public int PaginaHasta { get; set; }
        public string NombreCodOrgaUno { get; set; }
        public string CodOrgaUno { get; set; }
        public string CodOrgaDos { get; set; }
        public double Orden { get; set; }
        public string ExistePdf { get; set; }
        public string TipoNota { get; set; }
    }

    public class EdicionPublicacion
    {
    }

    public class AudioSumario
    {
        public EdicionPublicacion MAT { get; set; }
        public EdicionPublicacion VES { get; set; }
        public EdicionPublicacion EXT { get; set; }
    }

    public class DOFNotasFecha
    {
        public int MessageCode { get; set; }
        public string Response { get; set; }
        public IEnumerable<NotasEdicion> NotasExtraordinarias { get; set; }
        public IEnumerable<ImagenesDiario> ImagenesDiario { get; set; }
        public IEnumerable<NotasEdicion> NotasVespertinas { get; set; }
        public IEnumerable<NotasEdicion> NotasMatutinas { get; set; }
        public IEnumerable<AudioSumario> AudioSumario { get; set; }
    }
}
