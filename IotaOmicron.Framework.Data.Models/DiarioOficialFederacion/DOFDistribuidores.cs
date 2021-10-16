using Newtonsoft.Json;
using System.Collections.Generic;

namespace IotaOmicron.Framework.Data.Models.DiarioOficialFederacion
{
    public class DatosDistribuidorDOF
    {
        public int IdDistribuidor { get; set; }
        public string Nombre { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string CodEstado { get; set; }
        public int CodEstatus { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Empresa { get; set; }
        public string FechaReg { get; set; }
    }

    public class Distribuidores
    {
        [JsonProperty("Yucatán")]
        public IEnumerable<DatosDistribuidorDOF> Yucatan { get; set; }
        public IEnumerable<DatosDistribuidorDOF> Campeche { get; set; }
        public IEnumerable<DatosDistribuidorDOF> Sonora { get; set; }
        [JsonProperty("Nuevo León")]
        public IEnumerable<DatosDistribuidorDOF> NuevoLeon { get; set; }
        public IEnumerable<DatosDistribuidorDOF> Aguascalientes { get; set; }
        [JsonProperty("Electrónico")]
        public IEnumerable<DatosDistribuidorDOF> Electronico { get; set; }
        [JsonProperty("Querétaro de Arteaga")]
        public IEnumerable<DatosDistribuidorDOF> QueretaroDeArteaga { get; set; }
        public IEnumerable<DatosDistribuidorDOF> Tamaulipas { get; set; }
        [JsonProperty("Baja California")]
        public IEnumerable<DatosDistribuidorDOF> BajaCalifornia { get; set; }
        [JsonProperty("Baja California Sur")]
        public IEnumerable<DatosDistribuidorDOF> BajaCaliforniaSur { get; set; }
        [JsonProperty("San Luis Potosí")]
        public IEnumerable<DatosDistribuidorDOF> SanLuisPotosi { get; set; }
        public IEnumerable<DatosDistribuidorDOF> Nayarit { get; set; }
        [JsonProperty("Quintana Roo")]
        public IEnumerable<DatosDistribuidorDOF> QuintanaRoo { get; set; }
        public IEnumerable<DatosDistribuidorDOF> Hidalgo { get; set; }
        public IEnumerable<DatosDistribuidorDOF> Chiapas { get; set; }
        public IEnumerable<DatosDistribuidorDOF> Durango { get; set; }
        public IEnumerable<DatosDistribuidorDOF> Chihuahua { get; set; }
        public IEnumerable<DatosDistribuidorDOF> Zacatecas { get; set; }
        public IEnumerable<DatosDistribuidorDOF> Jalisco { get; set; }
        [JsonProperty("Estado de México")]
        public IEnumerable<DatosDistribuidorDOF> EstadoDeMexico { get; set; }
        [JsonProperty("Ciudad de México")]
        public IEnumerable<DatosDistribuidorDOF> CiudadDeMexico { get; set; }
        public IEnumerable<DatosDistribuidorDOF> Sinaloa { get; set; }
        public IEnumerable<DatosDistribuidorDOF> Guerrero { get; set; }
        [JsonProperty("Coahuila de Zaragoza")]
        public IEnumerable<DatosDistribuidorDOF> CoahuilaDeZaragoza { get; set; }
        public IEnumerable<DatosDistribuidorDOF> Tlaxcala { get; set; }
        public IEnumerable<DatosDistribuidorDOF> Tabasco { get; set; }
        public IEnumerable<DatosDistribuidorDOF> Puebla { get; set; }
        public IEnumerable<DatosDistribuidorDOF> Morelos { get; set; }
        public IEnumerable<DatosDistribuidorDOF> Guanajuato { get; set; }
        public IEnumerable<DatosDistribuidorDOF> Colima { get; set; }
        [JsonProperty("Michoacán de Ocampo")]
        public IEnumerable<DatosDistribuidorDOF> MichoacanDeOcampo { get; set; }
        [JsonProperty("Veracruz de Ignacio de la Llave")]
        public IEnumerable<DatosDistribuidorDOF> VeracruzDeIgnacioDeLaLlave { get; set; }
        public IEnumerable<DatosDistribuidorDOF> Oaxaca { get; set; }
    }

    public class DOFDistribuidores
    {
            public int MessageCode { get; set; }
            public string Response { get; set; }
            public Distribuidores Distribuidores { get; set; }
    }
}
