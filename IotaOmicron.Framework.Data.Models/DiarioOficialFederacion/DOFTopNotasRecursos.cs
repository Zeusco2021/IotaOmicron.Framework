using System.Collections.Generic;

namespace IotaOmicron.Framework.Data.Models.DiarioOficialFederacion
{
    public class DOFTopNotasRecursosData
    {
        public string IdNotasVisTop { get; set; }
        public string CodNota { get; set; }
        public object NombOrganismo { get; set; }
        public string Titulo { get; set; }
        public int Posicion { get; set; }
        public string Tab { get; set; }
        public string FechaNota { get; set; }
        public string Destacado { get; set; }
    }

    public class DOFTopNotasRecursos
    {
        public int MessageCode { get; set; }
        public string Response { get; set; }
        public IEnumerable<DOFTopNotasRecursosData> TopNotas { get; set; }
    }
}
