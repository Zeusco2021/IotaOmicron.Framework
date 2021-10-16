using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IotaOmicron.Framework.Data.Models.Sepomex
{
    public class CodigoPostalBaseData
    {
        public string CodigoPostalAsentamiento { get; set; }
        public string NombreAsentamiento { get; set; }
        public string TipoAsentamiento { get; set; }
        public string Municipio { get; set; }
        public string EntidadFederativa { get; set; }
        public string Ciudad { get; set; }
        public string CodigoPostalAdminPostal { get; set; }
        public string ClaveEntidadFederativa { get; set; }
        public string CodigoPostalOficinaPostal { get; set; }
        public string CampoVacio { get; set; }
        public string ClaveTipoAsentamiento { get; set; }
        public string ClaveMunicipio { get; set; }
        public string ClaveTipoUnicoAsentamiento { get; set; }
        public string TipoZona { get; set; }
        public string ClaveCiudad { get; set; }
    }
}
