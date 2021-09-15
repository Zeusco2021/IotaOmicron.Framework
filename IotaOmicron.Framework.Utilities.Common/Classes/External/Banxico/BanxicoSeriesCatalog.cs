using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IotaOmicron.Framework.Utilities.Common.Interfaces;

namespace IotaOmicron.Framework.Utilities.Common.Classes.External.Banxico
{
    public static class BanxicoSeriesCatalog
    {
        private static List<string> _bancoDeMexicoSeriesSection01 = new List<string> {"SF43770", "SF43771", "SF43769", "SF44042", "SF44043", "SF44044", "SF43695", "SF43702", "SF43696", "SF43671",  
																					 "SF43672", "SF43673", "SF43658", "SF43686", "SF43687", "SF63315", "SF43688", "SF43689", "SF43968", "SF43690"};
		private static List<string> _bancoDeMexicoSeriesSection02 = new List<string> {"SF43691", "SF43692", "SF43693", "SF267992", "SF44081", "SF65183", "SF44032", "SF43703", "SF43704", "SF43705", 
																					 "SF43706", "SF43707", "SF43708", "SF43709", "SF43710", "SF43711", "SF6", "SF1", "SF4", "SF5"};
		private static List<string> _bancoDeMexicoSeriesSection03 = new List<string> {"SF1574", "SF7", "SF8", "SF9", "SF63327", "SF1575", "SF1576", "SF1577", "SF22619", "SF236017", 
																					 "SF1580", "SF1578", "SF1579", "SF1583", "SF1581", "SF42853", "SF1582", "SF10740", "SF1587", "SF269134"};
		private static List<string> _bancoDeMexicoSeriesSection04 = new List<string> {"SF1584", "SF65208", "SF1585", "SF43658", "SF43659", "SF43360", "SF43361", "SF43363", "SF63312", "SF43662", 
		                                                                             "SF63313", "SF43664", "SF43665", "SF43666", "SF43667", "SF43668", "SF43669", "SF43670", "SF43657", "SF43684"};
		private static List<string> _bancoDeMexicoSeriesSection05 = new List<string> {"SF65182", "SF43967", "SF43682", "SF43681", "SF267838", "SF43685", "SF59829", "SF235986", "SF59827", "SF5928", 
																					 "SF235987", "SF43674", "SF43675", "SF43676", "SF43677", "SF43678", "SF43679", "SF43680", "SF336106", "SF336107"};
		private static List<string> _bancoDeMexicoSeriesSection06 = new List<string> {"SF336108", "SF336109", "SF336110", "SF336111", "SF336112", "SF336113", "SF336114", "SF336338", "SF332", "SF31991", 
																					 "SF42820", "SF42821",  "SF63330", "SF9", "SF337", "SF340", "SF343", "SF345", "SF347", "SF350"};
		private static List<string> _bancoDeMexicoSeriesSection07 = new List<string> {"SF42818", "SF356", "SF10740", "SF399", "SF389", "SF359", "SF362", "SF26163", "SF60331", "SF30323", 
																					 "SF60322", "SF236016", "SF10", "SF11", "SF394", "SF60334", "SF367", "SF369", "SF60336", "SF372"};
		private static List<string> _bancoDeMexicoSeriesSection08 = new List<string> {"SF375", "SF376", "SF42819", "SF378", "SF400", "SF269133", "SF379", "SF65207", "SF398", "SF382", 
																					 "SF336097", "SF336098", "SF336099", "SF336100", "SF336101", "SF336102", "SF336103", "SF336104", "SF336105", "SF336337"};
		private static List<string> _bancoDeMexicoSeriesSection09 = new List<string> {"SF38460", "SF38461", "SF38462", "SF38463", "SF38464", "SF38465", "SF38466", "SF110168", "SF110169", "SF110170", 
																					  "SF110171", "SF110172", "SF110173", "SF110174", "SF110175", "SF110176",  "SF110177", "SF110178", "SF112915", "SF112916"};
		private static List<string> _bancoDeMexicoSeriesSection10 = new List<string> {"SF110179", "SF110180", "SF110181", "SF110182", "SF110183", "SF110184", "SF110185", "SF110186", "SF110187", "SF110188", 
																					  "SF110189", "SF110190", "SF110191", "SF110192", "SF110193", "SF110194", "SF110195", "SF110196", "SF110197", "SF110198"};
		private static List<string> _bancoDeMexicoSeriesSection11 = new List<string> {"SF110199", "SF110200", "SF110201", "SF110202", "SF110203", "SF110204", "SF110205", "SF110206",  "SF110207", "SF110208", 	
																					  "SF110209", "SF110210", "SF110211", "SF110212", "SF110213", "SF296217", "SF296218", "SF296219", "SF296220", "SF110215"};
		private static List<string> _bancoDeMexicoSeriesSection12 = new List<string> {"SF110216", "SF112917", "SF110217", "SF280648",  "SF280649", "SF280650", "SF280651", "SF110219", "SF110220", "SF336679", 
																					  "SF336676", "SF336680", "SF336677", "SF336678", "SF110221", "SF308843", "SF308844", "SF308845", "SF308846", "SF308847"};
		private static List<string> _bancoDeMexicoSeriesSection13 = new List<string> {"SF308848", "SF308849", "SF308850", "SF308851", "SF308852", "SF308853", "SF308854", "SF30886", "SF308857", "SF308858"};

	private static string BuildSection(List<string> section)
        {
			StringBuilder listSeriesSection = new StringBuilder();
			foreach (string serie in section)
            {
				listSeriesSection.Append(serie).Append(',');
            }
			listSeriesSection.Remove(listSeriesSection.Length - 1, 1);
			return listSeriesSection.ToString();
        }

		public static string BuildBancoDeMexicoSeriesSection(int sectionNumber)
        {
			string seriesIdSection = string.Empty;
			switch (sectionNumber)
            {
				case 1: 
					seriesIdSection = BuildSection(_bancoDeMexicoSeriesSection01);
					break;
				case 2: 
					seriesIdSection = BuildSection(_bancoDeMexicoSeriesSection02);
					break; 
				case 3:
					seriesIdSection = BuildSection(_bancoDeMexicoSeriesSection03);
					break;
				case 4:
					seriesIdSection = BuildSection(_bancoDeMexicoSeriesSection04); 
					break;
				case 5:
					seriesIdSection = BuildSection(_bancoDeMexicoSeriesSection05);
					break;
				case 6:
					seriesIdSection = BuildSection(_bancoDeMexicoSeriesSection06);
					break;
				case 7:
					seriesIdSection = BuildSection(_bancoDeMexicoSeriesSection07);
					break;
				case 8:
					seriesIdSection = BuildSection(_bancoDeMexicoSeriesSection08);
					break;
				case 9:
					seriesIdSection = BuildSection(_bancoDeMexicoSeriesSection09);
					break;
				case 10:
					seriesIdSection = BuildSection(_bancoDeMexicoSeriesSection10);
					break;
				case 11:
					seriesIdSection = BuildSection(_bancoDeMexicoSeriesSection11);
					break;
				case 12:
					seriesIdSection = BuildSection(_bancoDeMexicoSeriesSection12);
					break;
				case 13:
					seriesIdSection = BuildSection(_bancoDeMexicoSeriesSection13);
					break;
			}
			return seriesIdSection;
		}
    }
}
