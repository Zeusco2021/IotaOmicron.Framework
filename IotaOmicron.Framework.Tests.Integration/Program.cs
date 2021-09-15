using System;
using IotaOmicron.Framework.Utilities.Common.Classes.External.Banxico;


namespace IotaOmicron.Framework.Tests.Integration
{
    class Program
    {
        static void Main(string[] args)
        {
            string serieBancoDeMexico = BanxicoSeriesCatalog.BuildBancoDeMexicoSeriesSection(1);

            Console.WriteLine(serieBancoDeMexico);
            Console.ReadLine();
        }
    }
}
