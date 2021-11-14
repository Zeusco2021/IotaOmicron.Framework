using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using IotaOmicron.Framework.Utilities.Common.Classes.External.Banxico;
using IotaOmicron.Framework.Utilities.Common.Enums.External.DiarioOficialFederacion;
using IotaOmicron.Framework.Data.Models.Sepomex;

namespace IotaOmicron.Framework.Tests.Integration
{
    class Program
    {
        static void Main(string[] args)
        {
            string serieBancoDeMexico = BanxicoSeriesCatalog.BuildBancoDeMexicoSeriesSection(11);
            string fileLocation       = $"C:\\Users\\Julio\\Downloads\\mx gob datos\\Sepomex\\CPDescarga.txt";


            // Integration test for using the Banxico API Controller and its tools for extracting data
            Console.WriteLine(serieBancoDeMexico);
            Console.ReadLine();

            DOFPeriodosTiempo periodosTiempo = DOFPeriodosTiempo.Semanal | DOFPeriodosTiempo.Mensual | DOFPeriodosTiempo.Anual;
            Console.WriteLine(periodosTiempo);
            Console.ReadLine();

            // Integration test for using SEPOMEX text file and turn it into data for use in a Postal Code object model
            List<CodigoPostalBaseData> codigosPostales = new List<CodigoPostalBaseData>();
            StreamReader fileReader = new StreamReader(fileLocation);
            while (!fileReader.EndOfStream)
            {
                string fileRow = fileReader.ReadLine();
                if (fileRow.StartsWith('#') || fileRow.StartsWith("d_"))
                {
                    continue;
                }
                string[] rawData               = fileRow.Split('|');
                var codigoPostalData           = new CodigoPostalBaseData { 
                    CodigoPostalAsentamiento   = rawData[0],
                    NombreAsentamiento         = rawData[1],
                    TipoAsentamiento           = rawData[2],
                    Municipio                  = rawData[3],
                    EntidadFederativa          = rawData[4],
                    Ciudad                     = rawData[5],
                    CodigoPostalAdminPostal    = rawData[6],
                    ClaveEntidadFederativa     = rawData[7],
                    CodigoPostalOficinaPostal  = rawData[8],
                    CampoVacio                 = rawData[9],
                    ClaveTipoAsentamiento      = rawData[10],
                    ClaveMunicipio             = rawData[11],
                    ClaveTipoUnicoAsentamiento = rawData[12],
                    TipoZona                   = rawData[13],
                    ClaveCiudad                = rawData[14]
                };
                codigosPostales.Add(codigoPostalData);
            }
            fileReader.Close();

            // Using the codigosPostales data with LINQ to get full data listing from text file
            var query = from codigoPostal in codigosPostales
                        select codigoPostal;

            foreach (var item in query)
            {
                Console.WriteLine(String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", item.CodigoPostalAsentamiento, item.NombreAsentamiento, item.TipoAsentamiento, item.Municipio, item.EntidadFederativa, item.Ciudad, item.CodigoPostalAdminPostal, item.ClaveEntidadFederativa, item.CodigoPostalOficinaPostal, item.CampoVacio, item.ClaveTipoAsentamiento, item.ClaveMunicipio, item.ClaveTipoUnicoAsentamiento, item.TipoZona, item.ClaveCiudad));
            }
            Console.ReadLine();

            // Using the LINQ Distinct method in order to get diferent "Tipos de Asentamientos" (types of settlements)
            /*var queryTiposAsentamiento = codigosPostales.GroupBy(x => x.ClaveTipoAsentamiento).Select(x => x.First()).ToList();

            foreach (var item in queryTiposAsentamiento)
            {
                Console.WriteLine(String.Format("{0} - {1}", item.ClaveTipoAsentamiento, item.TipoAsentamiento));
            }
            Console.ReadLine();*/

            // Using the LINQ Distinct method in order to get diferent "Asentamientos" (settlements)
            var queryAsentamiento = codigosPostales.GroupBy(x => x.ClaveTipoUnicoAsentamiento).Select(x => x.First()).ToList();

            foreach (var item in queryAsentamiento)
            {
                Console.WriteLine(String.Format("{0} - {1} - {2}", item.ClaveTipoUnicoAsentamiento, item.NombreAsentamiento, item.TipoZona));
            }
            Console.ReadLine();


            // Using the LINQ Distinct method in order to get diferent "Entidades Federativas" (states)
            /*var queryEntidadesFederativas = codigosPostales.GroupBy(x => x.ClaveEntidadFederativa).Select(x => x.First()).ToList();
            
            foreach (var item in queryEntidadesFederativas)
            {
                Console.WriteLine(String.Format("{0} - {1}", item.ClaveEntidadFederativa, item.EntidadFederativa));
            }
            Console.ReadLine();

            // Using the LINQ Distinct method in order to get diferent municipalities ("Municipios")
            foreach (var entidadFederativa in queryEntidadesFederativas)
            {
                var queryMunicipios = (from municipios in codigosPostales where municipios.ClaveEntidadFederativa == entidadFederativa.ClaveEntidadFederativa select municipios).GroupBy(x => x.ClaveMunicipio).Select(x => x.First()).ToList();
                foreach (var item in queryMunicipios)
                {
                    Console.WriteLine(String.Format("{0} - {1} - {2}", item.ClaveEntidadFederativa, item.ClaveMunicipio, item.Municipio));
                }
            }
            Console.ReadLine();*/
        }
    }
}