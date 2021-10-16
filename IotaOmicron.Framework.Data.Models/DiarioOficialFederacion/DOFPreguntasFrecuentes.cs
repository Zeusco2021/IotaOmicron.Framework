using System.Collections.Generic;

namespace IotaOmicron.Framework.Data.Models.DiarioOficialFederacion
{
    public class DOFPreguntasFrecuentesData
    {
        public int CodPreguntaFrecuente { get; set; }
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }
        public int Orden { get; set; }
        public string FechaAlta { get; set; }
        public int CodUsuario { get; set; }
        public string CodEstado { get; set; }
        public string EstaFecha { get; set; }
        public int CodPreguntaFrecuenteCategor { get; set; }
        public string Descripcion { get; set; }
    }

    public class DOFPreguntasFrecuentes
    {
        public int MessageCode { get; set; }
        public string Response { get; set; }
        public IEnumerable<DOFPreguntasFrecuentesData> ListaPreguntasFrecuentes { get; set; }
    }
}
