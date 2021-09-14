using System;
using System.Collections.Generic;

namespace IotaOmicron.Framework.Data.Models
{
    public class BanxicoSeriesBmx
    {
        public BanxicoSeriesTitle Bmx { get; set; }
    }
    
    public class BanxicoSeriesTitle
    {
        public IEnumerable<BanxicoSerie> Series { get; set; }
    }

    public class BanxicoSerie
    {
        public string IdSerie { get; set; }
        public string Titulo { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string Periodicidad { get; set; }
        public string Saldos { get; set; }
        public string Unidad { get; set; }
        public bool? Versionada { get; set; }
    }
}
