using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IotaOmicron.Framework.Utilities.Common.Enums.External.Banxico;


namespace IotaOmicron.Framework.Utilities.Common.Classes.External.Banxico
{
    public static class BanxicoSeriesCatalog
    {
        #region Identifier_Catalog_Codes
        // Section : Banco de México
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
		//  Section: Tipos de cambio y resultados históricos de las subastas
		private static List<string> _tipoCambioResultadoHistoricoSubastas01 = new List<string> {"SF60653", "SF43718", "SF43787", "SF43784", "SF43788", "SF43786", "SF43785", "SF43717", "SF63528", "SF63529", 
																								"SF63530", "SF63531", "SF63532", "SF63533", "SF63534", "SF64841", "SF64842", "SF64843", "SF63187", "SF63188"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas02 = new List<string> {"SF63190", "SF63192", "SF63193", "SF63191", "SD63194", "SF63195", "SF63196", "SF63197", "SF63199", "SF63200",
																								"SF63201", "SF63202", "SF63203", "SF63204", "SF63205", "SF63206", "SF63208", "SF63209", "SF63210", "SF63211"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas03 = new List<string> {"SF63212", "SF63213", "SF63236", "SF63237", "SF272295", "SF272296", "SF2722967", "SF272298", "SF272299", "SF272300",
																								"SF272301", "SF272302", "SF272303", "SF272304", "SF272305", "SF272306", "SF272307", "SF272308", "SF272309", "SF272310"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas04 = new List<string> {"SF272311", "SF272312", "SF272313", "SF272314", "SF272315", "SF272316", "SF272317", "SF272318", "SF272319", "SF272320",
																								"SF64978", "SF64979", "SF64980", "SF64981", "SF64982", "SF64983", "SF649814", "SF64985", "SF64986", "SF64991"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas05 = new List<string> {"SF64992", "SF64993", "SF64995", "SF64996", "SF64997", "SF64998", "SF64999", "SF65000", "SF63222", "SF63223",
																								"SF63224", "SF63225", "SF63226", "SF63227", "SF63228", "SF63229", "SF63230", "SF63231", "SF63232", "SF63233"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas06 = new List<string> {"SF63234", "SF63235", "SF63246", "SF63247", "SF45337", "SF45338", "SF45339", "SF45340", "SF45341", "SF45342",
																								"SF45343", "SF45344", "SF45349", "SF295324", "SF295325", "SF295327", "SF295328", "SF295329", "SF295330", "SF295331"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas07 = new List<string> {"SF295332", "SF295333", "SF295334", "SF295335", "SF295336", "SF295337", "SF295338", "SF295339", "SF295340", "SF295341",
																								"SF295352", "SF295343", "SF295344", "SF295345", "SF295346", "SF295347", "SF295348", "SF295349", "SF295350", "SF295351"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas08 = new List<string> {"SF295352", "SF295353", "SF295354", "SF295355", "SF295356", "SF295357", "SF295358", "SF295359", "SF295360", "SF295361",
																								"SF295362", "SF295363", "SF295364", "SF295365", "SF295366", "SF295367", "SF295368", "SF295369", "SF295370", "SF295371"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas09 = new List<string> {"SF295372", "SF295373", "SF295374", "SF295375", "SF295376", "SF295377", "SF295378", "SF295379", "SF295380", "SF296149",
																								"SF296150", "SF295151", "SF296152", "SF296153", "SF296154", "SF296155", "SF296156", "SF296157", "SF296158", "SF296159"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas10 = new List<string> {"SF296160", "SF296161", "SF296162", "SF296163", "SF296164", "SF296165", "SF296166", "SF296167", "SF296168", "SF296169",
																								"SF296170", "SF296171", "SF296172", "SF2961173", "SF296174", "SF296175", "SF296176", "SF296177", "SF296178", "SF296179"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas11 = new List<string> {"SF296180", "SF296181", "SF195182", "SF296183", "SF296184", "SF296185", "SF296186", "SF296187", "SF296188", "SF296189",
																								"SF296190", "SF296191", "SF296192", "SF296193", "SF296194", "SF296195", "SF296196", "SF296197", "SF296198", "SF296199"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas12 = new List<string> {"SF296200", "SF296201", "SF296202", "SF296203", "SF296204", "SF296205", "SF108616", "SF108617", "SF108619", "SF108620",
																								"SF108621", "SF108622", "SF108623", "SF109624", "SF108626", "SF108627", "SF46405", "SF46410", "SF46406", "SF46407"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas13 = new List<string> {"SF280383", "SF46411", "SF17908", "SF18651", "SF329", "SF17886", "SF17887", "SF17888", "SF17889", "SF17890",
																								"SF17891", "SF17892", "SF17893", "SF17894", "SF17895", "SF17896", "SF17897", "SF17898", "SF17899", "SF17900"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas14 = new List<string> {"SF17901", "SF17902", "SF17903", "SF17906", "SF18560", "SF328", "SF17866", "SF17867", "SF17868", "SF17869",
																								"SF17870", "SF17871", "SF17872", "SF17873", "SF17874", "SF17875", "SF17876", "SF17877", "SF17878", "SF17879"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas15 = new List<string> {"SF17880", "SF17881", "SF17882", "SF17883", "SF17909", "SF19412", "SF57746", "SF57747", "SF57748", "SF57749",
																								"SF57750", "SF57751", "SF57752", "SF57753", "SF57754", "SF57755", "SF57758", "SF57759", "SF57760", "SF57761"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas16 = new List<string> {"SF57762", "SF57763", "SF57764", "SF57765", "SF57766", "SF57767", "SF57770", "SF57771", "SF5772", "SF5773",
																								"SF57774", "SF57775", "SF229266", "SF229267", "SF5776", "SF5777", "SF57780", "SF57781", "SF57782", "SF57783"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas17 = new List<string> {"SF57784", "SF57785", "SF57786", "SF57787", "SF57788", "SF57789", "SF57790", "SF57791", "SF57792", "SF57793",
																								"SF57794", "SF57795", "SF57796", "SF57797", "SF57804", "SF57805", "SF57806", "SF57807", "SF57808", "SF57809"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas18 = new List<string> {"SF57810", "SF57811", "SF57814", "SF57815", "SF57816", "SF57817", "SF57818", "SF57819", "SF57822", "SF57823",
																								"SF57824", "SF57825", "SF57826", "SF57827", "SF57828", "SF57829", "SF57830", "SF57831", "SF57832", "SF57833"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas19 = new List<string> {"SF57836", "SF57837", "SF57838", "SF57839", "SF57840", "SF57841", "SF57844", "SF57845", "SF57846", "SF57847",
																								"SF57854", "SF57855", "SF57858", "SF57859", "SF57860", "SF57861", "SF57862", "SF57863", "SF57864", "SF57865"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas20 = new List<string> {"SF57866", "SF57867", "SF57870", "SF57871", "SF57872", "SF57873", "SF57874", "SF57875", "SF57876", "SF57877",
																								"SF57878", "SF57879", "SF57880", "SF57881", "SF57882", "SF57883", "SF57888", "SF57889", "SF57892", "SF57893"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas21 = new List<string> {"SF57896", "SF57897", "SF57902", "SF57903", "SF57904", "SF57905", "SF57908", "SF57909", "SF57910", "SF57911",
																								"SF57914", "SF57915", "SF57916", "SF57917", "SF57918", "SF57919", "SF57922", "SF57923", "SF57920", "SF57921"};
		private static List<string> _tipoCambioResultadoHistoricoSubastas22 = new List<string> {"SF57924", "SF57925", "SF57926", "SF57927", "SF57928", "SF57929", "SF57930", "SF57931", "SF57932", "SF60428",
																								"SF28", "SF464", "SF465", "SF1501", "SF1503"};
		// Section: Información histórica del mercado cambiario y de valores
		private static List<string> _informacionHistoricaMercadoCambiarioValores01 = new List<string> {"SF63316", "SF63317", "SF63318", "SF63319", "SF63320", "SF63321", "SF63528", "SF63529", "SF63530", "SF63531",
																									   "SF63534", "SF64841", "SF64842", "SF64483", "SF65065", "SF65072", "SF65073", "SF65074", "SF65075", "SF65066"};
		private static List<string> _informacionHistoricaMercadoCambiarioValores02 = new List<string> {"SF65067", "SF65068", "SF65069", "SF65070", "SF65071", "SF63180", "SF63178", "SF63179", "SF63181", "SF63183",
																									   "SF63182", "SF63184", "SF63347", "SF63348", "SF63349", "SF63356", "SF63357", "SF63350", "SF63351", "SF63358"};
		private static List<string> _informacionHistoricaMercadoCambiarioValores03 = new List<string> {"SF63352", "SF63359", "SF63354", "SF63360", "SF63355", "SF63361", "SF63362", "SF63364", "SF633363", "SF63365",
																									   "SF335857", "SF335858", "SF335861", "SF335855", "SF335859", "SF335860", "SF335862", "SF335856", "SF338461", "SF338462"};
		private static List<string> _informacionHistoricaMercadoCambiarioValores04 = new List<string> {"SF338460", "SF65300"};
		// Section: Tasas y precios de referencia
		private static List<string> _tasasPreciosDeReferencia01 = new List<string> {"SF43774", "SF45390", "SF331407", "SF331408", "SF45422", "SF45438", "SF45439", "SF45470", "SF45423", "SF45440",
																		            "SF45441", "SF45471", "SF45424", "SF45442", "SF45443", "SF45472", "SF45425", "SF45444", "SF45445", "SF45473"};
		private static List<string> _tasasPreciosDeReferencia02 = new List<string> {"SF45426", "SF45446", "SF45447", "SF45474", "SF59767", "SF59773", "SF59774", "SF59770", "SF339752", "SF339753",
															     					"SF339754", "SF339755", "SF59768", "SF59775", "SF59776", "SF59771", "SF59769", "SF59777", "SF59778", "SF59772"};
		private static List<string> _tasasPreciosDeReferencia03 = new List<string> {"SF45427", "SF45448", "SF45449", "SF45475", "SF45428", "SF45450", "SF45451", "SF45476", "SF45429", "SF45452",
																					"SF45453", "SF45477", "SF45430", "SF45454", "SF45455", "SF45478", "SF45431", "SF45456", "SF45457", "SF45479"};
		private static List<string> _tasasPreciosDeReferencia04 = new List<string> {"SF60720", "SF60721", "SF60722", "SF60723", "SF61784", "SF61785", "SF61786", "SF61787", "SF45432", "SF45458",
																					"SF45459", "SF45480", "SF50761", "SF50765", "SF60766", "SF50763", "SF50762", "SF50767", "SF50768", "SF50764"};
		private static List<string> _tasasPreciosDeReferencia05 = new List<string> {"SF64486", "SF64487", "SF64488", "SF64489", "SF108413", "SF108414", "SF108415", "SF108416", "SF45433", "SF45460",
																					"SF45461", "SF45481", "SF66800", "SF66801", "SF66802", "SF66803", "SF161926", "SF161928", "SF161930", "SF191932"};
		private static List<string> _tasasPreciosDeReferencia06 = new List<string> {"SF45435", "SF45464", "SF45465", "SF45483", "SF66804", "SF66805", "SF66806", "SF66807", "SF161927", "SF161929",
																					"SF161931", "SF191933", "SF45434", "SF45462", "SF45463", "SF45482", "SF165596", "SF165598", "SF165600", "SF165602"};
		private static List<string> _tasasPreciosDeReferencia07 = new List<string> {"SF165597", "SF165599", "SF165601", "SF165603", "SF45436", "SF45466", "SF45467", "SF45484", "SF45437", "SF45468",
																					"SF45469", "SF45485", "SF46617", "SF46618", "SF46619", "SF46620", "SF282", "SF3338", "SF3270", "SF3367"};
		private static List<string> _tasasPreciosDeReferencia08 = new List<string> {"SF17858", "SF17859", "SF18607", "SF17806", "SF17807", "SF17808", "SF46997", "SF46998", "SF17990", "SF18608",
																					"SF33229", "SF30057", "SF41841", "SF60719", "SF64840", "SF18605", "SF26717", "SF98792", "SF33230", "SF98793"};
		private static List<string> _tasasPreciosDeReferencia09 = new List<string> {"SF42852", "SF221660", "SF221661", "SF4830", "SF4831", "SF4832", "SF4842", "SF17861", "SF17862", "SF18609",
																					"SF18606", "SF26718", "SF33231", "SF221662", "SF221663", "SF17802", "SF17803", "SF17804", "SF45371", "SF44057"};
		private static List<string> _tasasPreciosDeReferencia10 = new List<string> {"SF45376", "SF48023", "SF48028", "SF48030", "SF28592", "SF40819", "SF43443", "SF43444", "SF43445", "SF43446",
																					"SF43447", "SF43448", "SF43449", "SF43450", "SF43451", "SF43452", "SF43453", "SF43454", "SF43456", "SF43457"};
		private static List<string> _tasasPreciosDeReferencia11 = new List<string> {"SF53458", "SF43455", "SF112133", "SF112134", "SF113135", "SF43439", "SF43440", "SF43441", "SF43442", "SF112136",
																					"SF112137", "SF112138", "SF61745", "SF331451", "SF43783", "SF43878", "SF111916", "SF43773", "SF331405", "SF331406"};
		private static List<string> _tasasPreciosDeReferencia12 = new List<string> {"SF44073", "SF63475", "SF63476", "SF331409", "SF43773", "SF43774", "SF43947", "SF331450", "SF283", "SF17801",
																					"SF221962", "SF284", "SF41840", "SF29423", "SF35884", "SF35885", "SF35886", "SF17863", "SF17864", "SF4849"};
		private static List<string> _tasasPreciosDeReferencia13 = new List<string> {"SF286", "SF330232", "SF3368", "SF3366", "SF285", "SF339723", "SF31980", "SF3295", "SF3297", "SF3299",
																					"SF3345", "SF3353", "SF3360", "SF3296", "SF3298", "SF3330", "SF3350", "SF3354", "SF3355", "SF3237"};
		private static List<string> _tasasPreciosDeReferencia14 = new List<string> {"SF3238", "SF3239", "SF3240", "SF3241", "SF3242", "SF3335", "SF3336", "SF3337", "SF3363", "SF3364",
																					"SF43313", "SF43421", "SF43422", "SF43423", "SF53424", "SF53425", "SF43426", "SF320890", "SF320891", "SF320892"};
		private static List<string> _tasasPreciosDeReferencia15 = new List<string> {"SF316115", "SF316118", "SF316116", "SF316119", "SF316117", "SF316120", "SF324163", "SF324159", "SF324175", "SF324183",
																					"SF324196", "SF324235", "SF324246", "SF324298", "SF324349", "SF324355", "SF324164", "SF324166", "SF324153", "SF324154"};
		private static List<string> _tasasPreciosDeReferencia16 = new List<string> {"SF324156", "SF324158", "SF324161", "SF324165", "SF324171", "SF324172", "SF325429", "SF335849", "SF324180", "SF324181",
																					"SF324182", "SF324189", "SF324193", "SF324197", "SF324199", "SF330996", "SF338592", "SF324201", "SF324203", "SF324204"};
		private static List<string> _tasasPreciosDeReferencia17 = new List<string> {"SF324207", "SF324209", "SF324210", "SF324211", "SF324217", "SF324568", "SF324313", "SF328142", "SF330994", "SF330997",
																					"SF336336", "SF338856", "SF324221", "SF324222", "SF324225", "SF328143", "SF338584", "SF338585", "SF324226", "SF324229"};
		private static List<string> _tasasPreciosDeReferencia18 = new List<string> {"SF324236", "SF324242", "SF330065", "SF324245", "SF324250", "SF324569", "SF324255", "SF330998", "SF324256", "SF324258",
																					"SF324259", "SF335850", "SF324260", "SF324261", "SF324262", "SF324263", "SF324264", "SF234265", "SF324266", "SF324268"};
		private static List<string> _tasasPreciosDeReferencia19 = new List<string> {"SF324270", "SF324272", "SF324391", "SF324276", "SF324277", "SF324278", "SF324279", "SF324280", "SF324287", "SF324288",
																					"SF324289", "SF324290", "SF324292", "SF324295", "SF324299", "SF324300", "SF324301", "SF324302", "SF330066", "SF338588"};
		private static List<string> _tasasPreciosDeReferencia20 = new List<string> {"SF324320", "SF324325", "SF324326", "SF324327", "SF324333", "SF324338", "SF324339", "SF324343", "SF338593", "SF324345",
																					"SF324347", "SF324356", "SF324360", "SF324361", "SF324362", "SF324363", "SF324364", "SF324365", "SF324366", "SF324367"};
		private static List<string> _tasasPreciosDeReferencia21 = new List<string> {"SF324368", "SF324370", "SF324372", "SF330999", "SF338589", "SF331963", "SF324168", "SF324170", "SF324160", "SF324162",
																					"SF324173", "SF324177", "SF324376", "SF324184", "SF324187", "SF324194", "SF324198", "SF324200", "SF325205", "SF335854"};
		private static List<string> _tasasPreciosDeReferencia22 = new List<string> {"SF339756", "SF324208", "SF324212", "SF324215", "SF324312", "SF324314", "SF324218", "SF324570", "SF324223", "SF324571",
																					"SF338581", "SF338582", "SF324227", "SF324228", "SF324232", "SF324233", "SF324237", "SF324240", "SF330067", "SF338590"};
		private static List<string> _tasasPreciosDeReferencia23 = new List<string> {"SF324244", "SF324247", "SF324251", "SF324254", "SF324572", "SF324573", "SF324257", "SF330995", "SF335847", "SF324269",
																					"SF324271", "SF324274", "SF324282", "SF324284", "SF324286", "SF324293", "SF324321", "SF324323", "SF324328", "SF324329"};
		private static List<string> _tasasPreciosDeReferencia24 = new List<string> {"SF324330", "SF324331", "SF324334", "SF324344", "SF324346", "SF324352", "SF324353", "SF324358", "SF324392", "SF324369",
																					"SF324371", "SF324374", "SF331965", "SF324167", "SF324169", "SF324155", "SF324157", "SF324174", "SF324176", "SF324178"};
		private static List<string> _tasasPreciosDeReferencia25 = new List<string> {"SF324179", "SF324185", "SF324186", "SF324188", "SF324190", "SF324195", "SF324192", "SF335851", "SF335852", "SF324202",
																					"SF324206", "SF324213", "SF324214", "SF324216", "SF324219", "SF324574", "SF335587", "SF324220", "SF324224", "SF338437"};
		private static List<string> _tasasPreciosDeReferencia26 = new List<string> {"SF338583", "SF324234", "SF324238", "SF324239", "SF324241", "SF324243", "SF338591", "SF324248", "SF324249", "SF324252",
																					"SF324253", "SF335848", "SF324273", "SF324275", "SF324283", "SF324285", "SF324291", "SF324294", "SF324296", "SF324297"};
		private static List<string> _tasasPreciosDeReferencia27 = new List<string> {"SF324319", "SF324322", "SF324324", "SF324332", "SF324335", "SF324336", "SF324337", "SF324340", "SF324341", "SF324342",
																					"SF328144", "SF330233", "SF335853", "SF324348", "SF324350", "SF324351", "SF324354", "SF324357", "SF324359", "SF324373"};
		private static List<string> _tasasPreciosDeReferencia28 = new List<string> {"SF324375", "SF338594", "SF331968", "SF331969", "SI561", "SI562", "SI265", "SI266", "SI267", "SI563",
																					"SI564", "SI264", "SI222", "SI223", "SI260", "SI224", "SI261", "SI220", "SI263", "SI209"};
		private static List<string> _tasasPreciosDeReferencia29 = new List<string> {"SI209", "SI262", "SI225", "SI237", "SI277", "SI268", "SI269", "SI270"};
		// Section: Subastas y colocación de valores
		private static List<string> _subastasColocacionDeValores01 = new List<string> {"SF60404", "SF60407", "SF60408", "SF60409", "SF60410", "SF60411", "SF60412", "SF60413", "SF60405", "SF60414",
																					   "SF60415", "SF60416", "SF06417", "SF60418", "SF60419", "SF60420", "SF60406", "SF60421", "SF60422", "SF60423"};
		private static List<string> _subastasColocacionDeValores02 = new List<string> {"SF60424", "SF60425", "SF60426", "SF60427", "SF118304", "SF118305", "SF118306", "SF118307", "SF118308", "SF118309",
																					   "SF118310", "SF118311", "SF331004", "SF331014", "SF331015", "SF331016", "SF331060", "SF331061", "SF331062", "SF331063"};
		private static List<string> _subastasColocacionDeValores03 = new List<string> {"SF331005", "SF331017", "SF331018", "SF331019", "SF331064", "SF331065", "SF331066", "SF331067", "SF331006", "SF331020",
																					   "SF331021", "SF331022", "SF331068", "SF331069", "SF331070", "SF331071", "SF331008", "SF331026", "SF331027", "SF331028"};
		private static List<string> _subastasColocacionDeValores04 = new List<string> {"SF331076", "SF331077", "SF331078", "SF331083", "SF331009", "SF331029", "SF331030", "SF331031", "SF331079", "SF331080",
																					   "SF331081", "SF331082", "SF331010", "SF331035", "SF331036", "SF331037", "SF331048", "SF331049", "SF331050", "SF331051"};
		private static List<string> _subastasColocacionDeValores05 = new List<string> {"SF331012", "SF331038", "SF331039", "SF331040", "SF331052", "SF331053", "SF331054", "SF331055", "SF331013", "SF331041",
																					   "SF331042", "SF331043", "SF331056", "SF331057", "SF331058", "SF331059", "SF44033", "SF44034", "SF44035", "SF44036"};
		private static List<string> _subastasColocacionDeValores06 = new List<string> {"SF44037", "SF44038", "SF44040", "SF44049", "SF43960", "SF43961", "SF43962", "SF43963", "SF43964", "SF43965",
																					   "SF43966", "SF44029", "SF46621", "SF279109", "SF279110", "SF279111", "SF43935", "SF43937", "SF43936", "SF43938"};
		private static List<string> _subastasColocacionDeValores07 = new List<string> {"SF43940", "SF43939", "SF43941", "SF43943", "SF43942", "SF43944", "SF43946", "SF43945", "SF60714", "SF60715",
																					   "SF60650", "SF339743", "SF339744", "SF339745", "SF60668", "SF60669", "SF60651", "SF60673", "SF60674", "SF60652"};
		private static List<string> _subastasColocacionDeValores08 = new List<string> {"SF43932", "SF43934", "SF43933", "SF43929", "SF43931", "SF43930", "SF43882", "SF43884", "SF43883", "SF43885",
																					   "SF43887", "SF43886", "SF44945", "SF44947", "SF44946", "SF44070", "SF44072", "SF44071", "SF45383", "SF45385"};
		private static List<string> _subastasColocacionDeValores09 = new List<string> {"SF45384", "SF60689", "SF60690", "SF60696", "SF61593", "SF61594", "SF61592", "SF43926", "SF43928", "SF43927",
																					   "SF43923", "SF43925", "SF53924", "SF46957", "SF46959", "SF46958", "SF46960", "SF46962", "SF46961", "SF43935"};
		private static List<string> _subastasColocacionDeValores10 = new List<string> {"SF98794", "SF98795", "SF98796", "SF43936", "SF43938", "SF98797", "SF98798", "SF98799", "SF43939", "SF43941",
																					   "SF98800", "SF98801", "SF98802", "SF43942", "SF43944", "SF98803", "SF98804", "SF98805", "SF43945", "SF43882"};
		private static List<string> _subastasColocacionDeValores11 = new List<string> {"SF98806", "SF98807", "SF98808", "SF99698", "SF43885", "SF98809", "SF98810", "SF98811", "SF99701", "SF44945",
																					   "SF98812", "SF98813", "SF98814", "SF99704", "SF44070", "SF98815", "SF98816", "SF98817", "SF99707", "SF45383"};
		private static List<string> _subastasColocacionDeValores12 = new List<string> {"SF98818", "SF98819", "SF98820", "SF99710", "SF60689", "SF98821", "SF98822", "SF98823", "SF99713", "SF61593",
																					   "SF98824", "SF98825", "SF98826", "SF99683", "SF43926", "SF98827", "SF98828", "SF98829", "SF99686", "SF43923"};
		private static List<string> _subastasColocacionDeValores13 = new List<string> {"SF98830", "SF98831", "SF98832", "SF99689", "SF46957", "SF98833", "SF98834", "SF98835", "SF99692", "SF46960",
																					   "SF98836", "SF98837", "SF98838", "SF99965", "SF98923", "SF103010", "SF103146", "SF99682", "SF103011", "SF103147"};
		private static List<string> _subastasColocacionDeValores14 = new List<string> {"SF99688", "SF103012", "SF103148", "SF99685", "SF103013", "SF103149", "SF99691", "SF103014", "SF103150", "SF99694",
																					   "SF103015", "SF103151", "SF99697", "SF103016", "SF103152", "SF99700", "SF103017", "SF103153", "SF108392", "SF108393"};
		private static List<string> _subastasColocacionDeValores15 = new List<string> {"SF109394", "SF99703", "SF103018", "SF103154", "SF99706", "SF103019", "SF103155", "SF99709", "SF103020", "SF103156",
																					   "SF99712", "SF103021", "SF103157", "SF99715", "SF103022", "SF103158", "SF99718", "SF103023", "SF103159", "SF43935"};
		private static List<string> _subastasColocacionDeValores16 = new List<string> {"SF116764", "SF116765", "SF116766", "SF116767", "SF116768", "SF116769", "SF116770", "SF116771", "SF116772", "SF116773",
																					   "SF116774", "SF116776", "SF116816", "SF116817", "SF116818", "SF339746", "SF339747", "SF339748", "SF116819", "SF116820"};
		private static List<string> _subastasColocacionDeValores17 = new List<string> {"SF116821", "SF1168222", "SF116823", "SF226824", "SF166777", "SF116778", "SF116779", "SF116780", "SF116781", "SF116782",
																					   "SF116786", "SF116787", "SF116788", "SF116789", "SF116790", "SF116791", "SF163358", "SF163359", "SF163360", "SF116792"};
		private static List<string> _subastasColocacionDeValores18 = new List<string> {"SF116793", "SF116794", "SF116798", "SF116799", "SF116800", "SF116801", "SF116802", "SF116803", "SF116804", "SF116805",
																					   "SF116806", "SF165631", "SF165632", "SF165633", "SF165640", "SF165641", "SF165642", "SF65258", "SF65259", "SF65267"};
		private static List<string> _subastasColocacionDeValores19 = new List<string> {"SF45392", "SF45393", "SF45391", "SF63629", "SF63630", "SF63631", "SF43880", "SF43881", "SF43879", "SF43971",
																					   "SF43972", "SF43970", "SF65271", "SF65272", "SF65270", "SF44942", "SF44943", "SF44944", "SF63477", "SF63478"};
		private static List<string> _subastasColocacionDeValores20 = new List<string> {"SF63498", "SF63479", "SF63480", "SF63499", "SF112691", "SF112692", "SF112693", "SF63481", "SF63482", "SF63500",
																					   "SF45371", "SF45372", "SF44060", "SF45373", "SF45374", "SF45375", "SF44057", "SF44058", "SF44059", "SF44061"};
		private static List<string> _subastasColocacionDeValores21 = new List<string> {"SF44062", "SF44063", "SF45376", "SF45377", "SF45378", "SF45379", "SF45380", "SF45381", "SF43463", "SF43464",
																					   "SF40832", "SF43465", "SF43466", "SF43467", "SF43468", "SF43469", "SF43470", "SF43471", "SF43472", "SF43473"};
		private static List<string> _subastasColocacionDeValores22 = new List<string> {"SF40820", "SF43474", "SF43475", "SF43476", "SF43477", "SF43478", "SF43479", "SF43480", "SF43481", "SF43482",
																					   "SF43483", "SF43484", "SF43485", "SF43486", "SF43487", "SF43488", "SF43489", "SF43490", "SF43491", "SF43492"};
		private static List<string> _subastasColocacionDeValores23 = new List<string> {"SF43493", "SF43494", "SF43495", "SF43496", "SF43497", "SF43498", "SF43499", "SF43500", "SF43501", "SF43502",
																					   "SF43503", "SF43504", "SF43505", "SF43506", "SF43507", "SF43508", "SF43509", "SF43510", "SF43511", "SF43512"};
		private static List<string> _subastasColocacionDeValores24 = new List<string> {"SF43513", "SF43514", "SF43515", "SF43516", "SF118825", "SF43517", "SF112124", "SF112125", "SF112126", "SF118826",
																					   "SF453518", "SF43519", "SF43520", "SF43521", "SF118827", "SF43522", "SF118525", "SF118526", "SF118527", "SF118828"};
		private static List<string> _subastasColocacionDeValores25 = new List<string> {"SF43463", "SF43523", "SF43524", "SF43525", "SF118829", "SF43526", "SF112130", "SF112131", "SF112132", "SF118830",
																					   "SF43529", "SF43530", "SF43531", "SF43532", "SF43533", "SF43534", "SF43535", "SF43536", "SF43537", "SF43538"};
		private static List<string> _subastasColocacionDeValores26 = new List<string> {"SF43539", "SF43540", "SF43541", "SF43542", "SF43543", "SF43544", "SF43545", "SF43546", "SF43547", "SF43548",
																					   "SF43549", "SF43552", "SF43553", "SF43554", "SF43555", "SF43556", "SF43557", "SF43558", "SF43559", "SF43560"};
		private static List<string> _subastasColocacionDeValores27 = new List<string> {"SF43561", "SF43562", "SF43563", "SF43564", "SF43565", "SF43566", "SF43567", "SF43568", "SF43569", "SF43570",
																					   "SF43571", "SF43572", "SF43573", "SF43574", "SF43575", "SF43576", "SF43577", "SF43578", "SF43579", "SF43580"};
		private static List<string> _subastasColocacionDeValores28 = new List<string> {"SF43581", "SF43582", "SF43583", "SF43584", "SF43585", "SF43586", "SF43587", "SF43549", "SF43588", "SF43589",
																					   "SF43590", "SF43591", "SF43592", "SF43593", "SF435594", "SF43595", "SF43596", "SF43597", "SF43598", "SF43599"};
		private static List<string> _subastasColocacionDeValores29 = new List<string> {"SF43600", "SF43601", "SF43602", "SF43603", "SF43604", "SF43605", "SF222892", "SF222893", "SF222894", "SF222895",
																					   "SF222896", "SF222897", "SF222898", "SF222899", "SF222890", "SF222891"};
		// Section: Valores en circulación
		private static List<string> _valoresEnCirculacion01 = new List<string> {"SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF",
																				"SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF"};
		// Section: Agregados monetarios y activos financieros internos
		private static List<string> _agregadosMonetariosActivosFinancierosInternos01 = new List<string> {"SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF",
																					     			     "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF"};
		// Section: Financiamiento e información financiera de intermediarios financieros
		private static List<string> _financiamientoInformacionFinancieraIntermediariosFinancieros01 = new List<string> {"SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF",
																									                    "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF"};
		// Section: Billetes y monedas
		private static List<string> _billetesMonedas01 = new List<string> {"SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF",
																		   "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF"};
		// Section: Finanzas públicas
		private static List<string> _finanzasPublicas01 = new List<string> {"SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF",
																			"SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF"};
		// Section: Producción
		private static List<string> _produccion01 = new List<string> {"SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF",
																	  "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF"};
		// Section: Indices de precios al consumidor y UDIS
		private static List<string> _indicesPreciosConsumidorUDIS01 = new List<string> {"SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF",
																					    "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF"};

		// Section: Indices de precios productor y de comercio exterior
		private static List<string> _indicesPreciosProductorComercioExterior01 = new List<string> {"SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF",
																								   "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF"};
		// Section: Laboral
		private static List<string> _laboral01 = new List<string> {"SL138", "SL136", "SL137", "SL11136", "SL11137", "SL11138", "SL11139", "SL2829", "SL2830", "SL5113",
																   "SL5114", "SL2827", "SL2828", "SL2538", "SL2539", "SL2540", "SL2541", "SL2542", "SL2543", "SL2544"};
		private static List<string> _laboral02 = new List<string> {"SL2545", "SL11126", "SL11122", "SL11123", "SL11127", "SL11124", "SL11125", "SL11298", "SL11295", "SL11297",
																   "SL11296", "SL11110", "SL11258", "SL11102", "SL11264", "SL11118", "SL11267", "SL11120", "SL11270", "SL11341"};
		private static List<string> _laboral03 = new List<string> {"SL11342", "SL11345", "SL11346", "SL11349", "SL11350", "SL11353", "SL11354", "SL1", "SL5", "SL6",
																   "SL7", "SL8", "SL9", "SL185", "SL2", "SL13", "SL14", "SL15", "SL16", "SL3"};
		private static List<string> _laboral04 = new List<string> {"SL17", "SL187", "SL18", "SL21", "SL4", "SL22", "SL24", "SL188", "SL26", "SL191",
																   "SL27", "SL28", "SL29", "SL30", "SL31", "SL193", "SL32", "SL34", "SL35", "SL36"};
		private static List<string> _laboral05 = new List<string> {"SL37"};
		// Section: Balanzas de pago
		private static List<string> _balanzasDePago01 = new List<string> {"SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF",
													                      "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF"};
		// Section: Sistemas de pago
		private static List<string> _sistemasDePago01 = new List<string> {"SF41080", "SF41083", "SF41077", "SF41084", "SF41078", "SF61953", "SF61952", "SF46188", "SF46189", "SF309374",
																		  "SF309375", "SF324452", "SF324507", "SF324453", "SF324508", "SF324454", "SF324509", "SF324455", "SF324510", "SF324456"};
		private static List<string> _sistemasDePago02 = new List<string> {"SF324511", "SF324457", "SF324512", "SF324458", "SF324513", "SF324459", "SF324514", "SF324460", "SF324515", "SF324461",
																		  "SF324516", "SF324462", "SF324517", "SF324463", "SF324518", "SF324464", "SF324519", "SF324465", "SF324520", "SF324466"};
		private static List<string> _sistemasDePago03 = new List<string> {"SF324521", "SF324467", "SF324522", "SF324468", "SF324523", "SF324469", "SF324524", "SF324470", "SF324525", "SF324471",
																		  "SF324526", "SF324472", "SF324527", "SF324473", "SF324528", "SF324474", "SF324529", "SF324475", "SF324530", "SF324476"};
		private static List<string> _sistemasDePago04 = new List<string> {"SF324531", "SF324477", "SF324532", "SF324478", "SF324533", "SF324479", "SF324534", "SF324480", "SF324535", "SF324562",
																		  "SF324563", "SF338456", "SF338458", "SF324481", "SF324536", "SF324482", "SF324537", "SF324483", "SF324538", "SF324484"};
		private static List<string> _sistemasDePago05 = new List<string> {"SF324539", "SF324485", "SF324540", "SF324486", "SF324541", "SF324487", "SF324542", "SF324488", "SF324453", "SF324489",
																		  "SF324544", "SF324490", "SF324545", "SF324491", "SF324546", "SF324492", "SF324547", "SF324493", "SF324548", "SF324494"};
		private static List<string> _sistemasDePago06 = new List<string> {"SF324549", "SF324495", "SF324550", "SF324496", "SF324551", "SF324497", "SF324552", "SF324498", "SF324553", "SF324499",
																		  "SF324554", "SF324500", "SF324555", "SF324501", "SF324556", "SF324502", "SF324557", "SF324503", "SF324558", "SF324504"};
		private static List<string> _sistemasDePago07 = new List<string> {"SF324559", "SF324505", "SF324560", "SF324506", "SF324561", "SF324564", "SF324566", "SF324565", "SF324567", "SF326212",
																		  "SF326213", "SF338457", "SF338459", "SF324731", "SF324863", "SF324732", "SF324964", "SF324733", "SF324865", "SF324734"};
		private static List<string> _sistemasDePago08 = new List<string> {"SF324866", "SF324735", "SF324867", "SF324736", "SF324868", "SF324737", "SF324869", "SF324738", "SF324870", "SF324739",
																		  "SF324871", "SF324740", "SF324872", "SF324741", "SF324873", "SF324742", "SF324874", "SF324743", "SF324875", "SF324744"};
		private static List<string> _sistemasDePago09 = new List<string> {"SF324876", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF",
																		  "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF"};
		private static List<string> _sistemasDePago10 = new List<string> {"SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF",
																		  "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF"};
		// Section: Sistemas de pago de bajo valor
		private static List<string> _sistemasDePagoDeBajoValor01 = new List<string> {"SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF",
																					 "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF"};
		// Section: Encuestas
		private static List<string> _encuestas01 = new List<string> {"SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF",
																	 "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF"};
		// Section: Fondo mexicano del petróleo (Banxico como fiduciario)
		private static List<string> _fondoMexicanoDelPetroleoBanxicoFiduciario01 = new List<string> {"SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF",
																								     "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF", "SF"};
		// Claves ID de instituciones bancarias
		private static List<string> _codigoBancoId = new List<string> {"037019", "040012", "040021", "040030", "040072", "040103", "068011", "068019", "040058", "040059",
																	   "040044", "040062", "040103", "040127", "040131", "040137", "040140", "068009", "068018", "068022",
																	   "040002", "040042", "068009", "068028", "068072"};
		#endregion

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
