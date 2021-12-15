using System.Collections.Generic;

namespace KonSchool.App.Data;

public partial class LocationDataService
{
	Dictionary<string, List<string>> GetAllUnionsWards() => new()
	{
		{
			"",
			new List<string> { "Please select a Thana" }
		},
		{
			"BARGUNATALTALI",
			new List<string>
			{
				"BARABAGI",
				"KARAIBARIA",
				"CHHOTA BAGI",
				"SONAKATA",
				"PONCHA KORALIA",
			}
		},
		{
			"BARGUNAAMTALI",
			new List<string>
			{
				"HALDIA",
				"AMTALI",
				"CHOWRA",
				"ATHARAGASHIA",
				"GULISAKHALI",
				"ARPANGASHIA",
				"KUKUA",
				"CHANDRAGHONA KADAMTALI",
				"SHYAMPUR",
				"DHANIA (PART)",
				"WARD NO-53 (89)",
				"WARD NO-52 (88)",
			}
		},
		{
			"BARGUNABAMNA",
			new List<string>
			{
				"BUKABUNIA",
				"BAMNA",
				"DAUATALA",
				"RAMNA",
			}
		},
		{
			"BARGUNABARGUNA SADAR",
			new List<string>
			{
				"BADARKHALI",
				"AYLA PATAKATA",
				"M.BALIATALI",
				"NALTONA",
				"PHULJHURY",
				"WARD NO-08",
				"BARGUNA",
				"WARD NO-09",
				"GAURICHANNA",
				"WARD NO-03",
				"DHALUA",
				"KEORABUNIA",
				"BURIR CHAR",
				"WARD NO-02",
			}
		},
		{
			"BARGUNABETAGI",
			new List<string>
			{
				"BETAGI",
				"KAZIRABAD",
				"BIBICHINI",
				"BURA MAZUMDAR",
				"MOKAMIA",
				"HOSNABAD",
				"SARISHAMURI",
				"BETAGI SANKIPURA",
			}
		},
		{
			"BARGUNAPATHARGHATA",
			new List<string>
			{
				"KALMEGHA",
				"NACHNA PARA",
				"PATHARGHATA",
				"KAKCHIRA",
				"WARD NO-03",
				"CHAR DUANI",
				"RAIHANPUR",
				"KANTHALTALI",
			}
		},
		{
			"BARISALAGAILJHARA",
			new List<string>
			{
				"BAKAL",
				"GAILA",
				"RAJIHER",
				"RATNAPUR",
				"BAGDHA",
			}
		},
		{
			"BARISALBABUGANJ",
			new List<string>
			{
				"KEDARPUR",
				"RAHMATPUR",
				"DEHERGATI",
				"JAHANGIR NAGAR(AGARPUR)",
				"CHANDPASHA",
				"MADHAB PASHA",
			}
		},
		{
			"BARISALBAKERGANJ",
			new List<string>
			{
				"RANGASREE",
				"PADRI SHIBPUR",
				"DARIAL",
				"KABAI",
				"WARD NO-04",
				"WARD NO-05",
				"KALASKATI",
				"FARIDPUR",
				"CHAR AMADDI",
				"DURGA PASHA",
				"GARURIA",
				"NIAMATI",
				"BHAR PASHA",
				"DUDHAL",
				"NALUA",
				"CHARADI",
				"WARD NO-06",
				"WARD NO-02",
			}
		},
		{
			"BARISALBANARI PARA",
			new List<string>
			{
				"CHAKHAR",
				"SALIA BAKPUR",
				"WARD NO-05",
				"BANARIPARA",
				"ILUHAR",
				"BAISARI",
				"BISARKANDI",
				"UDAYKATI",
				"SAIDKATI",
				"WARD NO-02",
			}
		},
		{
			"BARISALGAURNADI",
			new List<string>
			{
				"NALCHIRA",
				"WARD NO-06",
				"BARTHI",
				"CHANDSHI",
				"WARD NO-01",
				"BATAJORE",
				"MAHILARA",
				"SARIKAL",
				"KHANJAPUR",
				"WARD NO-08",
			}
		},
		{
			"BARISALHIZLA",
			new List<string>
			{
				"BARA JALIA",
				"HARINATHPUR",
				"DHULKHOLA",
				"GUABARIA",
				"MEMANIA",
				"HIZLA",
			}
		},
		{
			"BARISALBARISAL SADAR (KOTWALI)",
			new List<string>
			{
				"WARD NO-05",
				"CHAR KOWA",
				"WARD NO-14",
				"WARD NO-08",
				"WARD NO-18",
				"WARD NO-09",
				"WARD NO-16",
				"WARD NO-13",
				"WARD NO-20",
				"WARD NO-01",
				"WARD NO-19",
				"WARD NO-11",
				"WARD NO-02",
				"WARD NO-23",
				"WARD NO-25",
				"SHAYESTABAD",
				"JAGUA",
				"CHAR BARIA",
				"TUNGIBARIA",
				"CHANDPURA",
				"WARD NO-04",
				"ROY PASHA KARAPUR",
				"CHAR MONAI",
				"CHANDRA MOHAN",
				"WARD NO-03",
				"KASHIPUR",
				"WARD NO-28",
				"WARD NO-27",
				"WARD NO-15",
				"WARD NO-22",
				"WARD NO-12",
			}
		},
		{
			"BARISALMEHENDIGANJ",
			new List<string>
			{
				"CHAR EKKARIA",
				"CHAR GOPALPUR",
				"ALIMABAD",
				"ULANIA",
				"BHASAN CHAR",
				"WARD NO-02",
				"WARD NO-05",
				"LATA",
				"ANDHAR MANIK",
				"CHANDPUR",
				"DARI CHAR KHAJURIA",
				"JANGALIA",
				"BIDYANANDAPUR",
				"WARD NO-04",
				"WARD NO-03",
				"MEHENDIGANJ",
				"WARD NO-09",
			}
		},
		{
			"BARISALMULADI",
			new List<string>
			{
				"WARD NO-03",
				"KAZIR CHAR",
				"NAZIRPUR",
				"GACHHUA",
				"SAFIPUR",
				"BATAMARA",
				"CHAR KALEKHAN",
				"MULADI",
				"WARD NO-01",
			}
		},
		{
			"BARISALWAZIRPUR",
			new List<string>
			{
				"GUTHIA",
				"SATLA",
				"SHOLAK",
				"HARTA",
				"OTRA",
				"JALLA",
				"SHIKARPUR",
				"BAMRAIL",
				"BARA KOTHA",
			}
		},
		{
			"BHOLABHOLA SADAR",
			new List<string>
			{
				"VEDURIA",
				"WARD NO-07",
				"BAPTA",
				"WARD NO-05",
				"KACHIA",
				"ILLISHA",
				"WARD NO-08",
				"RAJAPUR",
				"UTTAR DIGHALDI",
				"BHELU MIAH",
				"WARD NO-09",
				"CHAR SHIBPUR",
				"DAKSHIN DIGHALDI",
				"WARD NO-03",
				"DHANIA",
				"PASCHIM ILISHA",
				"CHAR SAMAIA",
				"ALINAGAR",
			}
		},
		{
			"BHOLABURHANUDDIN",
			new List<string>
			{
				"WARD NO-02",
				"WARD NO-08",
				"SACHRA",
				"HASSAN NAGAR",
				"TABGI",
				"BARA MANIKA",
				"PAKSHIA",
				"DEULA",
				"GANGAPUR",
				"KACHIA",
			}
		},
		{
			"BHOLACHAR FASSON",
			new List<string>
			{
				"NURABAD",
				"CHAR MADRAS",
				"WARD NO-04",
				"AMINABAD",
				"JINNAGHAR",
				"CHAR MANIKA",
				"DHAL CHAR",
				"ASLAMPUR",
				"HAZARIGANJ",
				"NILKAMAL",
				"OSMANGANJ",
				"CHAR KUKRI MUKRI",
				"EWAJPUR",
				"ADHAKHA NAZRUL NAGAR",
				"JAHANPUR",
				"ABDULLAPUR",
			}
		},
		{
			"BHOLALALMOHAN",
			new List<string>
			{
				"BADARPUR",
				"WARD NO-04",
				"PASCHIM CHAR UMED",
				"RAMAGANJ",
				"LORD HARDINJE",
				"DHALI GAURNAGAR",
				"KALMA",
				"FARAZGANJ",
				"CHAR BHUTA",
				"LALMOHAN",
				"WARD NO-08",
			}
		},
		{
			"BHOLADAULAT KHAN",
			new List<string>
			{
				"CHAR KHALIFA",
				"UTTAR JOYNAGAR",
				"CHAR PATA",
				"DAKSHIN JOYNAGAR",
				"SAIDPUR",
				"CHAR DAULAT KHAN",
			}
		},
		{
			"BHOLAMANPURA",
			new List<string>
			{
				"MANPURA",
				"UTTAR SAKUCHIA",
				"HAJIRHAT",
			}
		},
		{
			"BHOLATAZUMUDDIN",
			new List<string>
			{
				"SHAMBHUPUR",
				"SONAPUR",
				"CHANCHRA",
			}
		},
		{
			"JHALOKATIJHALOKATI SADAR",
			new List<string>
			{
				"KIRTIPASHA",
				"BASANDA",
				"NABAGRAM",
				"PONABALIA",
				"SEKHERHAT",
				"GABHA RAMCHANDRAPUR",
				"KEORA",
				"WARD NO-05",
				"WARD NO-03",
				"WARD NO-08",
				"NATHULLABAD",
				"GABKHAN DHANSIRI",
				"BINOYKATI",
				"WARD NO-06",
			}
		},
		{
			"JHALOKATIKANTHALIA",
			new List<string>
			{
				"SAULAJALIA",
				"KANTHALIA",
				"AWRABUNIA",
				"AMUA",
				"CHENCHRI RAMPUR",
				"PATKHALGHATA",
			}
		},
		{
			"JHALOKATINALCHITY",
			new List<string>
			{
				"NACHAN MOHAL",
				"BHARABPASHA",
				"SIDDHAKATI",
				"DAPDAPIA",
				"MAGAR",
				"RANAPASHA",
				"WARD NO-03",
				"WARD NO-04",
				"MOLLAHAT",
				"SUBIDPUR",
				"KULKATI",
				"KUSANGHAL",
				"WARD NO-09",
			}
		},
		{
			"JHALOKATIRAJAPUR",
			new List<string>
			{
				"RAJAPUR",
				"GALUA",
				"BARAMAIA",
				"SATURIA",
				"SUKTAGARH",
				"MATHBARI",
				"UTTAR SUKHAIR RAJAPUR",
			}
		},
		{
			"PATUAKHALIBAUPHAL",
			new List<string>
			{
				"NOAMALA",
				"KESHABPUR",
				"KALISURI",
				"DASPARA",
				"BAUPHAL",
				"WARD NO-04",
				"KANAKDIA",
				"NAZIRPUR",
				"KANCHI PARA",
				"BAGA",
				"KALAIYA",
				"SURJYAMANI",
				"ADABARIA",
				"MADANPURA",
				"DHULIA",
			}
		},
		{
			"PATUAKHALIDASHMINA",
			new List<string>
			{
				"BAHRAMPUR",
				"DASHMINA",
				"BANSHBARIA",
				"BETAGI SANKIPURA",
				"ALIPUR",
				"RANGOPALDI",
			}
		},
		{
			"PATUAKHALIDUMKI UPAZILA",
			new List<string>
			{
				"LEBUKHALI",
				"SREERAMPUR",
				"MURADIA",
				"PANGASHIA",
				"ANGARIA",
			}
		},
		{
			"PATUAKHALIGALACHIPA",
			new List<string>
			{
				"PANPATTY",
				"WARD NO-04",
				"CHAR BISWAS",
				"GALACHIPA",
				"CHIKNIKANDI",
				"GOLKHALI",
				"CHAR KAJAL",
				"AMKHOLA",
				"KALAGACHHIA",
				"BAKULBARIA",
				"DAKUA",
				"GAZALIA",
				"WARD NO-09",
			}
		},
		{
			"PATUAKHALIRANGABALI",
			new List<string>
			{
				"RANGABALI",
				"BARA BAISDIA",
				"CHALITABUNIA",
				"CHAR MONTAZ",
			}
		},
		{
			"PATUAKHALIKALA PARA",
			new List<string>
			{
				"WARD NO-01",
				"WARD NO-04",
				"CHAMPAPUR",
				"DHULASAR",
				"NILGANJ",
				"MITHAGANJ",
				"MOHIPUR",
				"LALUA",
				"DHANKHALI",
				"LATA CHAPLI",
				"DALBUGANJ",
				"CHAKAMAIYA",
				"TIAKHALI",
				"BALIATALI",
			}
		},
		{
			"PATUAKHALIMIRZAGANJ UPAZILA",
			new List<string>
			{
				"MADHABKHALI",
				"AMRAGACHHIA",
				"DEULI SUBIDKHALI",
				"MIRZAGANJ",
				"KAKRABUNIA",
				"MAJIDBARI",
			}
		},
		{
			"PATUAKHALIPATUAKHALI SADAR",
			new List<string>
			{
				"BARA BIGHAI",
				"CHHOTA BIGHAI",
				"LAUKATI",
				"WARD NO-04",
				"JAINKATI",
				"LOHALIA",
				"KAMALAPUR",
				"AULIAPUR",
				"WARD NO-05",
				"WARD NO-03",
				"WARD NO-01",
				"ITABARIA",
				"WARD NO-07",
				"BADARPUR",
				"KALIKAPUR",
				"MADARBUNIA",
				"MARICHBUNIA",
				"WARD NO-09",
			}
		},
		{
			"PIROJPURBHANDARIA",
			new List<string>
			{
				"BHANDARIA",
				"DHAOA",
				"NUDMULLA",
				"GAURIPUR",
				"BHITABARIA",
				"IKRI",
				"TELIKHALI",
			}
		},
		{
			"PIROJPURKAWKHALI",
			new List<string>
			{
				"AMRAJURI",
				"KAWKHALI",
				"SAYNA RAGHUNATHPUR",
				"SHIALKATI",
				"CHIRA PARA PARSATURIA",
				"FATIK CHHARI",
				"KALAMPATI",
				"GHAGRA",
				"BETBUNIA",
			}
		},
		{
			"PIROJPURMATHBARIA",
			new List<string>
			{
				"BETMORE RAJPARA",
				"WARD NO-08",
				"SAPLEZA",
				"MIRUKHALI",
				"DHANISAFA",
				"GULISHAKHALI",
				"BARA MACHHUA",
				"AMRAGACHHIA",
				"TUSHKHALI",
				"MATHBARIA",
				"WARD NO-06",
				"TIKIKATA",
				"DAUDKHALI",
				"WARD NO-07",
			}
		},
		{
			"PIROJPURNAZIRPUR UPAZILA",
			new List<string>
			{
				"NAZIRPUR",
				"SHANKHARIKATI",
				"MALIKHALI",
				"SEKHMATIA",
				"SREERAMKATI UNION",
				"DIRGHA UNION",
				"KOLARDOANIA",
				"MATIBHANGA",
				"DEULBARI DOBRA",
			}
		},
		{
			"PIROJPURPIROJPUR SADAR",
			new List<string>
			{
				"SIKDAR MALLIK",
				"SHANKARPASHA",
				"WARD NO-09",
				"WARD NO-08",
				"WARD NO-05",
				"DURGAPUR",
				"KADAMTALA UNION",
				"KALAKHALI",
				"WARD NO-02",
				"SARIKTALA DUMRITALA",
				"TONA",
				"WARD NO-01",
				"WARD NO-07",
			}
		},
		{
			"PIROJPURINDURKANI",
			new List<string>
			{
				"PARERHAT",
				"PATTASHI",
				"BALI PARA",
			}
		},
		{
			"PIROJPURNESARABAD (SWARUPKATI)",
			new List<string>
			{
				"WARD NO-01",
				"SOHAGDAL",
				"SUTIAKATI",
				"SAMUDAYKATI",
				"JALABARI",
				"ATGHAR KURIANA UNION",
				"GUAREKHA UNION",
				"NESARABAD (SWARUPKATI)",
				"WARD NO-05",
				"DAIHARI",
				"BALDIA",
				"SARENGKATI",
			}
		},
		{
			"BANDARBANALIKADAM",
			new List<string>
			{
				"ALIKADAM",
				"CHOKHYONG",
			}
		},
		{
			"BANDARBANBANDARBAN SADAR",
			new List<string>
			{
				"WARD NO-05",
				"RAJBILA",
				"SUWALAK",
				"BANDARBAN",
				"KUHALONG",
				"WARD NO-08",
			}
		},
		{
			"BANDARBANLAMA",
			new List<string>
			{
				"AZIZNAGAR",
				"FASYAKHALI",
				"GAJALIA",
				"RUPSHIPARA",
				"FAITANG",
				"WARD NO-05",
				"ISLAMABAD",
				"SALAMABAD",
				"LAMATASHI",
				"LAMA KAZI",
			}
		},
		{
			"BANDARBANNAIKHONGCHHARI",
			new List<string>
			{
				"NAIKHONGCHHARI",
				"GHUMDUM",
				"BAISHARI",
			}
		},
		{
			"BANDARBANTHANCHI",
			new List<string>
			{
				"BALIPARA",
				"THANCHI",
			}
		},
		{
			"BRAHAMANBARIAAKHAURA",
			new List<string>
			{
				"DHARKHAR",
				"WARD NO-02",
				"WARD NO-07",
				"MOGRA",
				"MANIAND",
				"DAKSHIN AKHAURA",
				"UTTAR AKHAURA",
			}
		},
		{
			"BRAHAMANBARIABANCHHARAMPUR",
			new List<string>
			{
				"DARIKANDI",
				"BANCHHARAMPUR",
				"UJAN CHAR",
				"RUPASDI",
				"DARIADAULAT",
				"TEZKHALI",
				"PAHARIAKANDI",
				"SAIFULLAKANDI",
				"FARDABAD",
				"MANIKPUR",
				"SALIMABAD",
				"AYUBPUR",
			}
		},
		{
			"BRAHAMANBARIABRAHMANBARIA SADAR",
			new List<string>
			{
				"BUDHAL",
				"RAMRAIL",
				"WARD NO-02",
				"WARD NO-08",
				"WARD NO-09",
				"WARD NO-04",
				"WARD NO-12",
				"MAJLISHPUR",
				"MACHHIHATA",
				"SULTANPUR",
				"PURBA TALSAHAR",
				"BASUDEB",
				"SHUHILPUR",
				"SADEKPUR",
				"DAKSHIN NATAI",
				"UTTAR NATAI",
			}
		},
		{
			"BRAHAMANBARIABIJOYNAGAR",
			new List<string>
			{
				"HARASHPUR",
				"BUDHANTI",
				"CHANDURA",
				"DAKSHIN SINGERBIL",
				"BISHNUPUR",
				"PAHARPUR",
				"CHAR ISLMAPUR",
				"PATTAN",
				"UTTAR ICHHAPUR",
				"CHAMPAKNAGAR",
			}
		},
		{
			"BRAHAMANBARIAASHUGANJ",
			new List<string>
			{
				"ASHUGANG",
				"TARUA",
				"SHARIFPUR",
				"ARAISIDHA",
				"PASCHIM TALSAHAR",
				"LALPUR",
				"DURGAPUR",
			}
		},
		{
			"BRAHAMANBARIANABINAGAR",
			new List<string>
			{
				"BARAIL",
				"PASCHIM NABINAGAR",
				"WARD NO-09",
				"LAUR FATEHPUR",
				"BITGHAR (TIARA)",
				"SATMURA",
				"SALIMGANJ",
				"WARD NO-04",
				"IBRAHIMPUR",
				"SHYAMGRAM",
				"BIDDYAKUT",
				"RASULLABAD",
				"KAITALA DAKSHIN",
				"KAITALA UTTAR",
				"SHIBPUR",
				"RATANPUR",
				"SREERAMPUR",
				"KRISHNANAGAR",
				"NATGHAR",
				"JUNEDPUR",
			}
		},
		{
			"BRAHAMANBARIAKASBA",
			new List<string>
			{
				"BAYEK",
				"WARD NO-03",
				"BADAIR",
				"MULGRAM",
				"KAIMPUR",
				"WARD NO-07",
				"WARD NO-04",
				"MEHARI",
				"GOPINATHPUR",
				"KHERERA",
				"BINAUTI",
				"WARD NO-02",
				"KUTI",
				"KASBA MAJHAIL",
				"KASBA UNION",
			}
		},
		{
			"BRAHAMANBARIANASIRNAGAR",
			new List<string>
			{
				"CHAPARTALA",
				"NASIRNAGAR",
				"GUNIAK",
				"CHATALPAR",
				"GOKARNA",
				"FANDAUK",
				"BOLAKOT",
				"KUNDA",
				"GOALNAGAR",
				"DHAR MANDAL",
			}
		},
		{
			"BRAHAMANBARIASARAIL",
			new List<string>
			{
				"KALIKACHCHHA",
				"SARAIL",
				"UTTAR PANISAR",
				"SHAHBAZPUR",
				"CHUNTA",
				"AORAIL",
				"SHAHJADAPUR",
				"PAK SHIMUL",
				"NOAGAON",
			}
		},
		{
			"CHANDPURCHANDPUR SADAR",
			new List<string>
			{
				"WARD NO-02",
				"WARD NO-15",
				"WARD NO-06",
				"WARD NO-10",
				"WARD NO-12",
				"WARD NO-03",
				"HANAR CHAR",
				"WARD NO-01",
				"SHAH MAHMUDPUR",
				"BALIA",
				"KALYANPUR",
				"CHANDRA",
				"MAISHADI",
				"BISHNUPUR",
				"WARD NO-07",
				"RAMPUR",
				"BAGHADI",
				"ASHIKATI",
				"TARPUR CHANDI",
			}
		},
		{
			"CHANDPURSHAHRASTI",
			new List<string>
			{
				"TAMTA DAKSHIN",
				"UTTAR ROYSREE",
				"WEST CHITASI",
				"EAST CHITASI",
				"UTTAR MEHER",
				"TAMTA UTTAR",
				"DAKSHIN ROYSREE",
				"WARD NO-06",
				"WARD NO-02",
				"WARD NO-07",
				"WARD NO-05",
				"WARD NO-04",
				"UTTAR SUCHI PARA",
				"WARD NO-09",
				"DAKSHIN MEHER",
				"DAKSHIN SUCHI PARA",
			}
		},
		{
			"CHANDPURFARIDGANJ",
			new List<string>
			{
				"DAKSHIN RUPSA",
				"DAKSHIN PAIK PARA",
				"WARD NO-08",
				"PURBA SUBIDPUR",
				"UTTAR PAIKPARA",
				"UTTAR RUPSA",
				"PURBA GUPTI",
				"DAKSHIN GOBINDAPUR",
				"PASCHIM SUBIDPUR",
				"PASCHIM GUPTI",
				"PURBA BALUTHUPA",
				"UTTAR GOBINDAPUR",
				"PASCHIM CHAR DUKHIA",
				"PURBA CHAR DUKHIA",
				"WARD NO-03",
				"WARD NO-02",
			}
		},
		{
			"CHANDPURHAIM CHAR",
			new List<string>
			{
				"DAKSHIN ALGI DURGAPUR",
				"UTTAR ALGI DURGAPUR",
				"CHAR BHAIRABI",
				"NILKAMAL",
			}
		},
		{
			"CHANDPURHAJIGANJ",
			new List<string>
			{
				"PURBA BARKUL",
				"DAKSHIN KALOCHO",
				"WARD NO-04",
				"WARD NO-06",
				"BAKILA",
				"HATILA PURBA",
				"HAJIGANJ",
				"UTTAR GANDHARABPUR",
				"PACHIM HATILA",
				"UTTAR RAJARGAON",
				"UTTAR KALOCHO",
				"WARD NO-05",
				"DAKSHIN GANDHARBAPUR",
				"PASCHIM BARKUL",
			}
		},
		{
			"CHANDPURKACHUA",
			new List<string>
			{
				"BITARA",
				"SACHAR",
				"ASHRAFPUR",
				"WARD NO-06",
				"WARD NO-07",
				"DAKSHIN GOHAT",
				"UTTAR GOHAT",
				"KADLA",
				"UTTAR KACHUA",
				"PASCHIM SAHADEBPUR",
				"KARAIA",
				"PURBA SAHADEBPUR",
				"PATHAIR",
				"KACHUAI",
				"KACHUA",
				"BADHAL",
				"RARI PARA",
				"MAGHIA",
				"GOPALPUR",
				"GAZALIA",
				"DHOPAKHALI",
			}
		},
		{
			"CHANDPURMATLAB DAKSHIN",
			new List<string>
			{
				"WARD NO-06",
				"WARD NO-02",
				"NARAYANPUR",
				"UTTAR NAYERGAON",
				"WARD NO-03",
				"WARD NO-08",
				"WARD NO-07",
				"UTTAR UPADI",
				"WARD NO-09",
				"DAKHSIN NAYERGAON",
				"KHADERGAON",
				"DAKSHIN UPADI",
			}
		},
		{
			"CHANDPURMATLAB UTTAR",
			new List<string>
			{
				"PASCHIM FATEHPUR",
				"MOHANPUR",
				"BAGANBARI",
				"PURBA FATEHPUR",
				"EKLASPUR",
				"SULTANABAD",
				"ISLAMABAD",
				"SADULLAPUR",
				"FARAJIKANDI",
				"WARD NO-01",
				"SATNAL",
				"DURGAPUR",
				"JAHIRABAD",
				"WARD NO-06",
				"KALAKANDA",
				"WARD NO-08",
			}
		},
		{
			"CHITTAGONGANOWARA",
			new List<string>
			{
				"ROYPUR",
				"ANOWARA",
				"PARAIKORA",
				"BATTALI",
				"HAILDHAR",
				"CHATARI",
				"BARAKHAIN",
				"BURUMCHHARA",
				"BAIRAG (PART)",
				"BARASAT",
				"JUIDANDI",
			}
		},
		{
			"CHITTAGONGHATHAZARI",
			new List<string>
			{
				"CHIKANDANDI",
				"CHITTAGANG CNT.",
				"UTTAR MADARSA",
				"HATHAZARI",
				"FATEHPUR",
				"SHIKARPUR",
				"NANGALMORA",
				"DHALAI",
				"MIRZAPUR",
				"FORHADABAD",
				"GARDUARA",
				"GUMAN MARDAN",
				"MEKHAL",
				"BURISH CHAR",
			}
		},
		{
			"CHITTAGONGBAYEJID BOSTAMI",
			new List<string>
			{
				"CHITTAGANG CNT.",
				"WARD NO-02",
				"WARD NO-03",
			}
		},
		{
			"CHITTAGONGBANSHKHALI",
			new List<string>
			{
				"PUKURIA",
				"WARD NO-03",
				"CHHANUA",
				"BAILCHHARI",
				"SADHANPUR",
				"KALIPUR",
				"PUICHHARI",
				"CHAMBAL",
				"BAHARCHHARA",
				"SARAL",
				"KATHARIA",
				"SILKUP",
				"GANDAMARA",
				"KHANKHANABAD",
			}
		},
		{
			"CHITTAGONGCHANDGAON",
			new List<string>
			{
				"WARD NO-06",
				"WARD NO-05",
				"WARD NO-04",
				"CHANDGAON",
			}
		},
		{
			"CHITTAGONGBAKALIA",
			new List<string>
			{
				"WARD NO-19",
				"WARD NO-17",
				"WARD NO-18",
			}
		},
		{
			"CHITTAGONGBOALKHALI",
			new List<string>
			{
				"SAKPURA",
				"KANDHURKHIL",
				"POPADIA",
				"AMUCHIA",
				"SAROATALI",
				"CHARANDWIP",
				"AHLA KARALDANGA",
				"SREEPUR KHARANDWIP",
				"PURBA GOMDANDI",
				"PASCHIM GOMDANDI",
				"BOALKHALI",
			}
		},
		{
			"CHITTAGONGCHANDANAISH",
			new List<string>
			{
				"BARAMA",
				"DOHAZARI",
				"SATBARIA",
				"BAILTALI",
				"JOARA",
				"HASHIMPUR",
				"WARD NO-04",
				"KANCHANABAD",
				"BARKAL",
				"DHOPACHHARI",
			}
		},
		{
			"CHITTAGONGPATENGA",
			new List<string>
			{
				"WARD NO-40",
			}
		},
		{
			"CHITTAGONGCHITTAGONG PORT",
			new List<string>
			{
				"WARD NO-38",
				"WARD NO-37",
				"WARD NO-39",
			}
		},
		{
			"CHITTAGONGDOUBLE MOORING",
			new List<string>
			{
				"WARD NO-24 (PART)",
				"WARD NO-27",
				"WARD NO-23",
				"WARD NO-28",
				"WARD NO-30",
				"WARD NO-29",
				"WARD NO-36",
			}
		},
		{
			"CHITTAGONGKHULSHI",
			new List<string>
			{
				"WARD NO-14",
				"WARD NO-13",
			}
		},
		{
			"CHITTAGONGFATIKCHHARI",
			new List<string>
			{
				"BAGAN BAZAR",
				"JAFARNAGAR",
				"BHUJPUR",
				"DANTMARA",
				"NANUPUR",
				"DHARMAPUR",
				"DAULATPUR",
				"WARD NO-07",
				"LELANG",
				"WARD NO-03",
				"WARD NO-01",
				"ROUSHANGIRI",
				"PAINDANGA",
				"SUABIL",
				"NARAYANHAT",
				"BAKTAPUR",
				"KANCHAN NAGAR",
				"SAMITIRHAT",
				"HARWALCHHARI",
				"KHIRAM",
				"SUNDARPUR",
				"WARD NO-04",
			}
		},
		{
			"CHITTAGONGPATIYA",
			new List<string>
			{
				"BARA UTHAN",
				"SIKALBAHA",
				"KOLAGAON",
				"CHAR LAKSHYA",
				"BARALIA",
				"SOBHANDANDI",
				"ASIA",
				"WARD NO-04",
				"WARD NO-02",
				"WARD NO-09",
				"WARD NO-05",
				"KHARANA",
				"DHALGHAT",
				"KACHUAI",
				"BHATIKHAIN",
				"JANGLUKHAIN",
				"KELISHAHAR",
				"HABILAS DWIP",
				"KASIAIS",
				"DAKHIN D.BHURSHI",
				"CHANHARA",
				"HAIDGAON",
				"JIRI",
				"KUSUMPURA",
			}
		},
		{
			"CHITTAGONGKOTWALI",
			new List<string>
			{
				"WARD NO-05",
				"CHAR KOWA",
				"WARD NO-14",
				"WARD NO-08",
				"WARD NO-18",
				"WARD NO-09",
				"WARD NO-16",
				"WARD NO-13",
				"WARD NO-20",
				"WARD NO-01",
				"WARD NO-19",
				"WARD NO-11",
				"WARD NO-02",
				"WARD NO-23",
				"WARD NO-25",
				"SHAYESTABAD",
				"JAGUA",
				"CHAR BARIA",
				"TUNGIBARIA",
				"CHANDPURA",
				"WARD NO-04",
				"ROY PASHA KARAPUR",
				"CHAR MONAI",
				"CHANDRA MOHAN",
				"WARD NO-03",
				"KASHIPUR",
				"WARD NO-28",
				"WARD NO-27",
				"WARD NO-15",
				"WARD NO-22",
				"WARD NO-12",
				"WARD NO-21",
				"WARD NO-32",
				"WARD NO-33",
				"WARD NO-31",
				"WARD NO-16 (PART)",
				"WARD NO-35 (71)(PART)",
				"WARD NO-32 (68)(PART)",
				"WARD NO-37 (73)",
				"WARD NO-36 (72)",
				"LEBUTALA",
				"WARD NO-07",
				"NARENDRAPUR",
				"ICHHALI",
				"HAIBATPUR",
				"ARABPUR",
				"FATHEHPUR",
				"UPASAHAR",
				"WARD NO-06",
				"CHURAMANKATI",
				"BASUNDIA",
				"DIARA",
				"KASHIMPUR",
				"CHANCHRA",
				"RAMNAGAR",
				"NOAPARA",
				"KACHUA",
			}
		},
		{
			"CHITTAGONGPANCHLAISH",
			new List<string>
			{
				"WARD NO-07",
				"WARD NO-08(PART)",
			}
		},
		{
			"CHITTAGONGLOHAGARA",
			new List<string>
			{
				"KALAUZAN",
				"PADUA",
				"AMIRABAD",
				"CHUNATI",
				"ADHUNAGAR",
				"PUTIBILA",
				"CHARAMBA",
				"LOHAGARA",
				"BARAHATIA",
				"JOYPUR",
				"DIGHALIA",
				"NALDI",
				"ITNA",
				"NOAGRAM",
				"LAHURIA",
				"LAKSHMIPASHA",
				"KASHIPUR",
				"KOTAKUL",
				"WARD NO-07",
				"SHALNAGAR",
				"MALLIKPUR",
				"WARD NO-03",
				"WARD NO-02",
				"WARD NO-01",
			}
		},
		{
			"CHITTAGONGMIRSHARAI",
			new List<string>
			{
				"DURGAPUR",
				"MIRSHARAI",
				"ZORWARGANJ",
				"MAYANI",
				"HINGULI",
				"KHAIYACHHARA",
				"WAHEDPUR",
				"KARERHAT",
				"ICHHAKHALI",
				"MITHANALA",
				"HAITKANDI",
				"KATACHHARA",
				"DHUM",
				"OSMANPUR",
				"MAGHADIA",
				"SAHERKHALI",
				"WARD NO-08",
			}
		},
		{
			"CHITTAGONGPAHARTALI",
			new List<string>
			{
				"WARD NO-10",
				"WARD NO-11 (PART)",
				"PAHARTALI",
			}
		},
		{
			"CHITTAGONGHALISHAHAR",
			new List<string>
			{
				"WARD NO-11 (PART)",
				"WARD NO-26",
			}
		},
		{
			"CHITTAGONGRANGUNIA",
			new List<string>
			{
				"SARAPBHATA",
				"WARD NO-09",
				"RANGUNIA",
				"POMARA",
				"LALANAGAR",
				"SILOK",
				"RAJANAGAR",
				"MARIAMNAGAR",
				"KODALA",
				"PADUA",
				"CHANDRAGHONA KADAMTALI",
				"BETAGI",
				"DAKSHIN RAJANAGAR",
				"WARD NO-05",
				"WARD NO-04",
				"PARUA",
				"ISLAMPUR",
			}
		},
		{
			"CHITTAGONGRAOZAN",
			new List<string>
			{
				"NOA PARA",
				"URKIRCHAR",
				"WARD NO-04",
				"PURBA GUZARA",
				"PAHARTALI",
				"WARD NO-03",
				"BAGOAN",
				"WARD NO-05",
				"RAOZAN",
				"DABUA",
				"GAHIRA",
				"HALADIA",
				"PASCHIM GUZARA",
				"WARD NO-01",
				"NOAJISPUR",
				"WARD NO-07",
				"WARD NO-08",
				"CHIKDAIR",
				"KADALPUR",
				"BINAJURI",
			}
		},
		{
			"CHITTAGONGSANDWIP",
			new List<string>
			{
				"BAURIA",
				"HARISPUR",
				"KALAPANIA",
				"WARD NO-09",
				"WARD NO-08",
				"MAITBHANGA",
				"SANTOSHPUR",
				"MAGDHARA",
				"MUSAPUR",
				"HARAMIA",
				"AZIMPUR",
				"GACHHUA",
				"WARD NO-01",
				"SARIKAIT",
				"WARD NO-04",
			}
		},
		{
			"CHITTAGONGSATKANIA",
			new List<string>
			{
				"SONAKANIA",
				"EOCHIA",
				"NALUA",
				"BAZALIA",
				"DHEMSA",
				"SATKANIA",
				"PASCHIM DHEMSA",
				"KANCHANA",
				"DHARMAPUR",
				"PURANAGAR",
				"CHARATI",
				"KHAGARIA",
				"WARD NO-04",
				"KALIAIS",
				"AMILAIS",
				"KEOCHIA",
				"WARD NO-05",
				"SADAHA",
			}
		},
		{
			"CHITTAGONGSITAKUNDA",
			new List<string>
			{
				"KUMIRA",
				"BHATIARI",
				"SONAICHHARI",
				"BARIADYALA",
				"BARABKUNDA",
				"SALIMPUR",
				"SAIDPUR",
				"MURADPUR",
				"BANSHBARIA",
				"WARD NO-02",
				"WARD NO-06",
				"WARD NO-03",
			}
		},
		{
			"COMILLABARURA",
			new List<string>
			{
				"ADRA",
				"ADDA",
				"SHAKPUR",
				"UTTAR PAYALGACHHA",
				"UTTAR KHOSBAS",
				"DAKSHIN KHOSBAS",
				"AGANAGAR",
				"WARD NO-02",
				"WARD NO-03",
				"GALIMPUR",
				"BHABANIPUR",
				"DAKSHIN SHILMURI",
				"JALAM",
				"WARD NO-09",
				"LAKSHMIPUR",
				"CHITADDA",
				"UTTAR SHILMURI",
			}
		},
		{
			"COMILLABRAHMAN PARA",
			new List<string>
			{
				"SAHEBABAD",
				"SIDLAI",
				"SHASHIDAL",
				"BRAHMAN PARA",
				"MADHABPUR",
				"DULALPUR",
				"CHANDLA",
				"MALAPARA",
			}
		},
		{
			"COMILLABURICHANG",
			new List<string>
			{
				"SHOLANAL",
				"RAJAPUR",
				"BHARELLA DAKSHIN",
				"BURICHANG",
				"BAKSIMAIL",
				"MOKAM",
				"MAINAMATI",
				"PIR JATRAPUR",
				"BHARELLA UTTAR",
			}
		},
		{
			"COMILLACHANDINA",
			new List<string>
			{
				"KERAN KHAL",
				"JOYAG",
				"GALLAI",
				"MAHICHAL",
				"MADHYA",
				"ATBAR PUR",
				"WARD NO-05",
				"DOLLAI NOWABAB PUR",
				"BARERA",
				"BARA KARAI",
				"BATAKASH",
				"BARKAIT",
				"MAIJKHAR",
				"WARD NO-06",
				"WARD NO-02",
				"SUHILPUR",
			}
		},
		{
			"COMILLADAUDKANDI",
			new List<string>
			{
				"MARUKA",
				"WARD NO-05",
				"DAULATPUR (PURBA PANCHGACHHIA)",
				"SUNDALPUR",
				"MOHAMMADPUR PURBA",
				"PANCHGACHHIA PASCHIM",
				"WARD NO-04",
				"ELLIOTGANJ DAKSHIN",
				"BARAPARA",
				"GOALMARI",
				"GAURIPUR",
				"ELLIOTGANJ UTTAR",
				"DAUDKANDI UTTAR",
			}
		},
		{
			"COMILLACHAUDDAGRAM",
			new List<string>
			{
				"BATISHA",
				"SREEPUR",
				"MUNSHIRHAT",
				"GHOLPASHA",
				"ALKARA",
				"KALIKAPUR",
				"UJIRPUR",
				"JAGANNATH DIGHI",
				"KANKAPAIT",
				"CHEORA",
				"GUNABATI",
				"WARD NO-04",
				"WARD NO-08",
				"KASHINAGAR",
				"SHUBHAPUR",
			}
		},
		{
			"COMILLATITAS",
			new List<string>
			{
				"SATANI",
				"NARAYANDIA",
				"JAGATPUR",
				"BITIKANDI",
				"MAJIDPUR",
				"KALAKANDI",
				"JIARKANDI",
			}
		},
		{
			"COMILLADEBIDWAR",
			new List<string>
			{
				"FATEHABAD",
				"MOHAN PUR",
				"ISAB PUR",
				"BARA SHALGHAR",
				"SUBIL",
				"WARD NO-01",
				"RAJAMEHAR",
				"UTTAR GUNAIGHAR",
				"WARD NO-05",
				"JAFARGANJ",
				"RASULPUR",
				"ELAHABAD",
				"DHAMTI",
				"DAKSHIN GUNAIGHAR",
				"BARKAMTA",
				"SULTANPUR",
				"BHANI",
			}
		},
		{
			"COMILLAHOMNA",
			new List<string>
			{
				"CHANDER CHAR",
				"GARMORA",
				"DULAL PUR",
				"WARD NO-02",
				"WARD NO-04",
				"WARD NO-03",
				"ASADPUR",
				"BHASANIA",
				"NILAKHI",
			}
		},
		{
			"COMILLACOMILLA SADAR DAKSHIN",
			new List<string>
			{
				"GALIARA",
				"BIJOYPUR",
				"BARA PARA",
				"PURBA JOREKARAN",
				"WARD NO-21",
				"WARD NO-22",
				"WARD NO-19",
				"CHOUARA",
				"WARD NO-24",
				"WARD NO-26",
				"BHOLAIN (DAKSHIN)",
				"PERUL (DAKSHIN)",
				"BHOLAIN (UTTAR)",
				"BAGHMARA UTTAR",
				"PERUL (UTTAR)",
				"BELGHAR DAKSHIN",
				"BELGHAR UTTAR",
			}
		},
		{
			"COMILLACOMILLA ADARSHA SADAR",
			new List<string>
			{
				"KALIR BAZAR",
				"AMRATALI",
				"WARD NO-15",
				"WARD NO-10",
				"UTTAR DURGAPUR",
				"WARD NO-18",
				"WARD NO-04",
				"WARD NO-13",
				"WARD NO-03",
				"WARD NO-08",
				"DAKSHIN DURGAPUR",
				"WARD NO-14",
				"WARD NO-11",
				"WARD NO-05",
				"WARD NO-12",
				"JAGANNATHPUR",
				"PANCHTHUBI",
				"WARD NO-06",
				"WARD NO-16",
				"WARD NO-01",
				"WARD NO-02",
			}
		},
		{
			"COMILLAMANOHARGANJ",
			new List<string>
			{
				"MAISATUA",
				"SARASHPUR",
				"BAISHGAON",
				"LAKSHMANPUR",
				"JHALAM (UTTAR)",
				"HASNABAD",
				"BIPULASAR",
				"JHALAM (DAKSHIN)",
				"NATHER PETUA",
				"KHILA",
				"UTTAR HAWLA",
			}
		},
		{
			"COMILLALAKSAM",
			new List<string>
			{
				"GOBINDAPUR",
				"MUDAFARGANJ",
				"WARD NO-06",
				"WARD NO-04",
				"WARD NO-02",
				"LAKSAM",
				"UTTARDAH",
				"BAKAI",
				"KANDIRPAR",
				"WARD NO-05",
			}
		},
		{
			"COMILLAMEGHNA",
			new List<string>
			{
				"MANIKER CHAR",
				"RADHANAGAR",
				"GOBINDAPUR",
				"CHANDANPUR",
				"LUTER CHAR",
			}
		},
		{
			"COMILLAMURADNAGAR",
			new List<string>
			{
				"SREEKAIL",
				"DAKSHIN RAMCHANDRAPUR",
				"JATRAPUR",
				"BABUTI PARA",
				"PURBA BANGARA",
				"AKUBPUR",
				"CHAPITALA",
				"ANDIKOT",
				"DHAMGHAR",
				"UTTAR RAMCHANDRAPUR",
				"MURADNAGAR",
				"PASCHIM NABIPUR",
				"PAHARPUR",
				"KAMALLA",
				"PURBA PURBADHAIR",
				"DARORA",
				"CHHALIAKANDI",
				"PURBA NABIPUR",
				"TANKI",
			}
		},
		{
			"COMILLANANGALKOT",
			new List<string>
			{
				"DAULKHAR",
				"WARD NO-04",
				"ADRA",
				"MOKARA",
				"WARD NO-09",
				"JODDA",
				"WARD NO-06",
				"PERIA",
				"BAKSHAGANJ",
				"DHALUA",
				"HESAKHAL",
				"ROYKOT",
				"MOKRABPUR",
			}
		},
		{
			"COXS BAZARCHAKARIA",
			new List<string>
			{
				"KHUNTAKHALI",
				"DEMUSIA",
				"BADARKHALI",
				"HARBANG",
				"DULAHAZARA",
				"PASCHIM BARA BHEOLA",
				"KAIARBIL",
				"KAKHARA",
				"SURAJPUR MANIKPUR",
				"BARAITALI",
				"BHEOLA MANIK CHAR",
				"CHIRINGA",
				"WARD NO-06",
				"KONAKHALI",
				"FASIAKHALI",
				"SAHARBIL",
				"PURBA BARABHEOLA",
				"WARD NO-04",
			}
		},
		{
			"COXS BAZARPEKUA",
			new List<string>
			{
				"PEKUA",
				"RAJAKHALI",
				"SHILKHALI",
				"TAITONG",
				"BARA BAKIA",
			}
		},
		{
			"COXS BAZARCOX'S BAZAR SADAR",
			new List<string>
			{
				"JHILWANJA",
				"BHARUAKHALI",
				"JALALABAD",
				"ISLAMABAD",
				"WARD NO-06",
				"WARD NO-08",
				"WARD NO-11",
				"WARD NO-02",
				"KHURUSHKUL",
				"WARD NO-10",
				"WARD NO-04",
				"CHAUFALDANDI",
				"POKKHALI",
				"IDGAON",
				"ISLAMPUR",
				"PATALI MACHHUAKHALI",
				"WARD NO-05",
			}
		},
		{
			"COXS BAZARKUTUBDIA",
			new List<string>
			{
				"BARAGHOP",
				"DAKSHIN DHURUNG",
				"ALI AKBAR DEIL",
				"LEMSIKHALI",
				"UTTAR DHURUNG",
				"KAIYARBIL",
			}
		},
		{
			"COXS BAZARMAHESHKHALI",
			new List<string>
			{
				"BARA MAHESKHALI",
				"HOANAK",
				"KALARMARCHHARA",
				"WARD NO-02",
				"MATARBARI",
				"SAFLAPUR",
				"DHALGHATA",
				"KUTUBJOM",
			}
		},
		{
			"COXS BAZARRAMU",
			new List<string>
			{
				"FATEKHARKUL",
				"GARJANIA",
				"JOARIANALA",
				"CHAKMARKUL",
				"RAJARKUL",
				"RASHID NAGAR",
				"KAUARKHOP",
			}
		},
		{
			"COXS BAZARTEKNAF",
			new List<string>
			{
				"NHILLA",
				"WHYKONG",
				"TEKNAF",
				"SABRANG",
				"BAHARCHHARA",
			}
		},
		{
			"COXS BAZARUKHIA UPAZILA",
			new List<string>
			{
				"RAJA PALONG",
				"PALONG KHALI",
				"HALDIA PALONG",
				"RATNA PALONG",
				"JALIA PALONG",
			}
		},
		{
			"FENICHHAGALNAIYA",
			new List<string>
			{
				"PATHANNAGAR",
				"RADHANAGAR",
				"WARD NO-03",
				"GOPAL",
				"WARD NO-06",
				"WARD NO-08",
				"WARD NO-05",
				"SUBHAPUR",
				"WARD NO-02",
				"MOHAMAYA",
			}
		},
		{
			"FENIDAGANBHUIYAN",
			new List<string>
			{
				"RAMNAGAR",
				"JAILASHKARA",
				"SINDURPUR",
				"DAGANBHUIYAN",
				"WARD NO-09",
				"PURBA CHANDRAPUR",
				"YAKUBPUR",
				"MATHU BHUIYAN",
				"RAJAPUR",
			}
		},
		{
			"FENIFENI SADAR",
			new List<string>
			{
				"BALIGAON",
				"PANCHGACHHIYA",
				"KAZIRBAG",
				"WARD NO-15",
				"MATABI",
				"FAZILPUR",
				"WARD NO-09",
				"LEMUA",
				"SHARSHADI",
				"FARHADNAGAR",
				"WARD NO-06",
				"WARD NO-16",
				"WARD NO-13",
				"WARD NO-01",
				"WARD NO-04",
				"WARD NO-08",
				"WARD NO-07",
				"KALIDAH",
				"DHALIA",
				"SANUA",
				"DHARMAPUR",
			}
		},
		{
			"FENIFULGAZI",
			new List<string>
			{
				"ANANDAPUR",
				"G.M.HAT",
				"DARBARPUR",
				"AMJADHAT",
				"FULGAZI",
				"MUNSHIRHAT",
			}
		},
		{
			"FENIPARSHURAM",
			new List<string>
			{
				"CHITHALIA",
				"BAKSH MOHAMMAD",
				"MIRZANAGAR",
				"WARD NO-06",
				"WARD NO-09",
			}
		},
		{
			"FENISONAGAZI",
			new List<string>
			{
				"CHAR DARBESH",
				"NAWABPUR",
				"MANGALKANDI",
				"AMIRABAD",
				"CHAR CHANDIA",
				"CHAR MAJLISHPUR",
				"BAGADANA",
				"WARD NO-08",
			}
		},
		{
			"KHAGRACHHARIDIGHINALA",
			new List<string>
			{
				"BABUCHHARA",
				"DIGHINALA",
				"MERUNG",
				"KABAKHALI",
				"BOALKHALI",
			}
		},
		{
			"KHAGRACHHARIKHAGRACHHARI SADAR",
			new List<string>
			{
				"WARD NO-09",
				"BHAIBONCHHARA",
				"KAMALCHHARI",
				"GOLABARI",
				"WARD NO-03",
				"KHAGRACHHARI",
				"WARD NO-01",
			}
		},
		{
			"KHAGRACHHARILAKSHMICHHARI",
			new List<string>
			{
				"LAKSHMICHHARI",
				"BARMACHHARI",
			}
		},
		{
			"KHAGRACHHARIMAHALCHHARI",
			new List<string>
			{
				"MAHALCHHARI",
				"MASCHHARI",
				"KAYANGGHAT",
				"MUBACHHARI",
				"SINDUKCHARI",
			}
		},
		{
			"KHAGRACHHARIMANIKCHHARI",
			new List<string>
			{
				"MANIKCHHARI",
				"TINTAHARI",
				"BATNATALI",
			}
		},
		{
			"KHAGRACHHARIMATIRANGA",
			new List<string>
			{
				"TUBALCHHARI",
				"GUIMARA",
				"AMTALI",
				"GUMTI",
				"TAINDANG",
				"MATIRANGA",
				"BELCHHARI",
				"WARD NO-05",
				"WARD NO-06",
			}
		},
		{
			"KHAGRACHHARIPANCHHARI",
			new List<string>
			{
				"PANCHHARI",
				"CHENGI",
				"LOGANG",
				"ULTACHHARI",
			}
		},
		{
			"KHAGRACHHARIRAMGARH",
			new List<string>
			{
				"WARD NO-02",
				"WARD NO-05",
			}
		},
		{
			"LAKSHMIPURLAKSHMIPUR SADAR",
			new List<string>
			{
				"KUSHAKHALI",
				"UTTAR JOYPUR",
				"UTTAR HAMCHADI",
				"CHAR RUHITA",
				"WARD NO-03",
				"PARBATINAGAR",
				"CHARSAI",
				"DALAL BAZAR",
				"CHANDRAGANJ",
				"BASIKPUR",
				"DIGHALI",
				"BANGAKHA",
				"LAHARKANDI",
				"TIARIGANJ",
				"DATTA PARA",
				"HAJIR PARA",
				"BHABANIGANJ",
				"MANDARI",
				"WARD NO-01",
				"WARD NO-07",
				"WARD NO-05",
				"DAKSHIN HAMCHADI",
				"WARD NO-12",
				"SHAK CHAR",
			}
		},
		{
			"LAKSHMIPURROYPUR",
			new List<string>
			{
				"ROYPUR",
				"KEROA",
				"SOUTH CHAR BANGSHI",
				"CHAR PATA",
				"NORTH CHAR BANGSHI",
				"NORTH CHAR ABABIL",
				"WARD NO-09",
				"WARD NO-04",
				"WARD NO-07",
				"SONAPUR",
				"BAMNI",
				"CHAR MOHANA",
				"WARD NO-01",
				"SOUTH CHAR ABABIL",
				"MARJAL",
				"CHANDPUR",
				"CHANDERKANDI",
				"CHAR SUBUDDI",
				"WARD NO-03",
				"AMIRGANJ",
				"MIRZAPUR",
				"HAIRMARA",
				"BANSHGARI",
				"MUSAPUR",
				"ROYPURA",
				"PARATALI",
				"SREENAGAR",
				"ADIABAD",
				"RADHANAGAR",
				"NILAKHYA",
				"MIRZANAGAR",
				"PALASHTALI",
				"MAHESHPUR",
				"UTTAR BAKHARNAGAR",
				"CHAR MADHUA",
				"MIRZAR CHAR",
			}
		},
		{
			"LAKSHMIPURRAMGANJ",
			new List<string>
			{
				"BHATRA",
				"ICHHAPUR",
				"WARD NO-07",
				"LAMCHAR",
				"CHANDIPUR",
				"KANCHANPUR",
				"BHADUR",
				"NOAGAON",
				"DARBESHPUR",
				"BHOLAKOT",
				"WARD NO-09",
				"KARPARA",
			}
		},
		{
			"LAKSHMIPURRAMGATI",
			new List<string>
			{
				"CHAR RAMIZ",
				"CHAR ALGI",
				"WARD NO-06",
				"CHAR GAZI",
				"CHAR BADAM",
				"WARD NO-08",
				"BARA KHERI",
				"WARD NO-03",
				"CHAR ALEXANDAR",
			}
		},
		{
			"LAKSHMIPURKAMALNAGAR",
			new List<string>
			{
				"CHAR FALCON",
				"CHAR LAWRENCE",
				"TORABGANG",
				"CHAR KALKINI",
				"HAJIRHAT",
			}
		},
		{
			"NOAKHALIBEGUMGANJ",
			new List<string>
			{
				"KUTUBPUR",
				"RAJGANJ",
				"AMANULLAPUR",
				"SHARIFPUR",
				"ALYERAPUR",
				"KADIRPUR",
				"DURGAPUR",
				"WARD NO-07",
				"BEGUMGANJ",
				"HAJIPUR",
				"JIRTALI",
				"RASULPUR",
				"GOPALPUR",
				"EKLASHPUR",
				"CHHAYANI",
				"MIR WARISHPUR",
				"WARD NO-05",
			}
		},
		{
			"NOAKHALISONAIMURI",
			new List<string>
			{
				"BAZRA",
				"SONAPUR",
				"DEOTI",
				"NADANA",
				"CHASHIRHAT",
				"BARAGAON",
				"NATESHWAR",
				"WARD NO-05",
				"AMISHA PARA",
				"JAYAG",
				"AMBARNAGAR",
				"WARD NO-07",
			}
		},
		{
			"NOAKHALICHATKHIL",
			new List<string>
			{
				"BADALKUT",
				"KHIL PARA",
				"PARKOTE",
				"PANCHGAON",
				"MOHAMMADPUR",
				"HATPUKURIA GHATLABAG",
				"NAYAKHOLA",
				"SAHAPUR",
				"WARD NO-03",
				"RAMNARAYANPUR",
				"WARD NO-09",
			}
		},
		{
			"NOAKHALICOMPANIGANJ",
			new List<string>
			{
				"SIRAJPUR",
				"CHAR PARBATI",
				"MUSAPUR",
				"CHAR FAKIRA",
				"CHAR ELAHI",
				"WARD NO-08",
				"RAMPUR",
				"CHAR KAKRA",
				"CHAR HAZARI",
				"WARD NO-06",
				"ISLAMPUR PASCHIM",
				"RANIKHAI UTTAR",
				"ISLAMPUR PURBA",
				"TELIKHAL",
				"ISHAKALAS",
				"RANIKHAI DAKSHIN",
			}
		},
		{
			"NOAKHALIHATIYA",
			new List<string>
			{
				"SONADIA",
				"CHAR ISHWAR",
				"CHAR KING",
				"BURIR CHAR",
				"WARD NO-03",
				"WARD NO-07",
				"WARD NO-08",
				"TAMARUDDIN",
				"JAHAJMARA",
				"WARD NO-09",
			}
		},
		{
			"NOAKHALISENBAGH",
			new List<string>
			{
				"DUMURIA",
				"CHHATARPAIA",
				"KABILPUR",
				"KADRA",
				"MOHAMADPUR",
				"BEJOYBAGH",
				"KESHARPAR",
				"ARJUNTALA",
				"NABIPUR",
				"WARD NO-03",
			}
		},
		{
			"NOAKHALINOAKHALI SADAR",
			new List<string>
			{
				"BINODPUR",
				"DHARMAPUR",
				"EWAZBALIA",
				"NOANNAI",
				"WARD NO-08",
				"WARD NO-04",
				"WARD NO-09",
				"WARD NO-05",
				"NOAKHALI",
				"WARD NO-01",
				"WARD NO-03",
				"CHAR MATUA",
				"ASHWADIA",
				"DADPUR",
				"KALADARAF",
				"NIAZPUR",
				"KADIR HANIF",
				"WARD NO-02",
			}
		},
		{
			"NOAKHALISUBARNACHAR",
			new List<string>
			{
				"CHAR JABBAR",
				"CHAR AMANULLAH",
				"CHAR BATA",
				"CHAR JUBILLE",
				"MOHAMMADPUR",
				"CHAR CLERK",
				"PURBA CHAR BATA",
				"CHAR WAPDA",
			}
		},
		{
			"NOAKHALIKABIRHAT",
			new List<string>
			{
				"NAROTTAMPUR",
				"BATAIYA",
				"CHAP RASHIR HAT",
				"WARD NO-01",
				"SUNDALPUR",
				"WARD NO-07",
				"GHOSHBAGH",
				"DHAN SHALIK",
				"DHAN SIRI",
			}
		},
		{
			"RANGAMATIBAGHAICHHARI",
			new List<string>
			{
				"WARD NO-05",
				"SARBOATALI",
				"RUPAKARI",
				"BAGHAI CHHARI",
				"KEDARMARA",
				"BANGALTALI",
				"AMTALI",
				"MARISHYA",
				"SAJEK",
			}
		},
		{
			"RANGAMATIBARKAL UPAZILA",
			new List<string>
			{
				"BARKAL",
				"SHUBLONG",
				"BARA HARINA",
				"BHUSHAN CHHARA",
			}
		},
		{
			"RANGAMATIKAWKHALI (BETBUNIA)",
			new List<string>
			{
				"FATIK CHHARI",
				"KALAMPATI",
				"GHAGRA",
				"BETBUNIA",
			}
		},
		{
			"RANGAMATIBELAI CHHARI  UPAZI",
			new List<string>
			{
				"BELAI CHHARI",
			}
		},
		{
			"RANGAMATIKAPTAI  UPAZILA",
			new List<string>
			{
				"CHANDRAGHONA",
				"CHITMARAM",
				"KAPTAI",
				"RAIKHALI",
				"WAGGA",
			}
		},
		{
			"RANGAMATIJURAI CHHARI UPAZIL",
			new List<string>
			{
				"BANJUGI CHHARA",
				"JURAI CHHARI",
			}
		},
		{
			"RANGAMATILANGADU  UPAZILA",
			new List<string>
			{
				"BHASANYA ADAM",
				"BAGACHATAR",
				"LANGADU",
				"ATARAK CHARA",
				"GULSHAKHALI",
				"MAYANIMUKH",
			}
		},
		{
			"RANGAMATINANIARCHAR  UPAZILA",
			new List<string>
			{
				"NANIARCHAR",
				"BURIGHAT",
				"SABEKHYONG",
			}
		},
		{
			"RANGAMATIRAJASTHALI  UPAZILA",
			new List<string>
			{
				"BANGALHALIA",
				"GAINDA",
			}
		},
		{
			"RANGAMATIRANGAMATI SADAR  UP",
			new List<string>
			{
				"SAPCHHARI",
				"WARD NO-06",
				"WARD NO-03",
				"WARD NO-08",
				"WARD NO-02",
				"BANDUK BHANGA",
				"KUTUK CHHARI",
				"MAGBAN",
				"WARD NO-07",
				"BALUKHALI",
			}
		},
		{
			"DHAKAKHILKHET",
			new List<string>
			{
				"DUMNI",
				"WARD NO-17 (PART)",
				"DAKSHINKHAN (PART)",
			}
		},
		{
			"DHAKABADDA",
			new List<string>
			{
				"BERAID",
				"BADDA",
				"SATARKUL",
			}
		},
		{
			"DHAKACANTONMENT",
			new List<string>
			{
				"WARD NO-98 (REST. AREA)",
				"WARD NO-15 (PART)",
				"SYLHET CANTONMENT",
			}
		},
		{
			"DHAKAUTTAR KHAN",
			new List<string>
			{
				"UTTAR KHAN",
			}
		},
		{
			"DHAKAKAFRUL",
			new List<string>
			{
				"WARD NO-16 (PART)",
				"WARD NO-04",
				"WARD NO-14 (PART)",
			}
		},
		{
			"DHAKADEMRA",
			new List<string>
			{
				"DEMRA",
				"SARALIA",
				"NAGDEMRA",
			}
		},
		{
			"DHAKAJATRABARI",
			new List<string>
			{
				"MATUAIL (PART)",
				"WARD NO-50 (86)",
				"WARD NO-49 (85)",
				"DHANIA (PART)",
			}
		},
		{
			"DHAKAKADAMTALI",
			new List<string>
			{
				"CHANDRAGHONA KADAMTALI",
				"SHYAMPUR",
				"DHANIA (PART)",
				"WARD NO-53 (89)",
				"WARD NO-52 (88)",
			}
		},
		{
			"DHAKANAWABGANJ",
			new List<string>
			{
				"CHURAIN",
				"SHIKARI PARA",
				"KAILAIL",
				"KALAKOPA",
				"NAYANSREE",
				"AGLA",
				"BARUAKHALI",
				"SHOLLA",
				"GALIMPUR",
				"BARRAH",
				"JANTRAIL",
				"BAKSHANAGAR",
				"JOYKRISHNAPUR",
				"BANDURA",
				"DAUDPUR",
				"BINODNAGAR",
				"BHADURIA",
				"MAHMUDPUR",
				"KUSHDAHA",
				"PUTIMARA",
				"GOLAPGANJ",
				"SHALKHURIA",
				"JOYPUR",
			}
		},
		{
			"DHAKASABUJBAGH",
			new List<string>
			{
				"DAKSHINGAON (PART)",
				"WARD NO-04 (27)",
			}
		},
		{
			"DHAKAKHILGAON",
			new List<string>
			{
				"NASIRABAD",
				"WARD NO-02 (25)",
				"WARD NO-01 (24)",
			}
		},
		{
			"DHAKADHAMRAI",
			new List<string>
			{
				"WARD NO-03",
				"CHAUHAT",
				"DHAMRAI",
				"ROWAIL",
				"AMTA",
				"BAISAKANDA",
				"SUAPUR",
				"KUSHURA",
				"NANNAR",
				"JADABPUR",
				"BALIA",
				"SUTI PARA",
				"KULLA",
				"GANGUTIA",
				"SANORA",
				"SOMBHAG",
				"BHARARIA",
			}
		},
		{
			"DHAKADHANMONDI",
			new List<string>
			{
				"WARD NO-14 (48)(PART)",
				"WARD NO-15 (49)",
				"WARD NO-34 (PART) (47)",
			}
		},
		{
			"DHAKADOHAR",
			new List<string>
			{
				"SUTAR PARA",
				"MUKSUDPUR",
				"WARD NO-01",
				"NARISHA",
				"KUSHUMHATI",
				"WARD NO-05",
				"NAYABARI",
				"ROYPARA",
			}
		},
		{
			"DHAKABHATARA",
			new List<string>
			{
				"BHATARA",
			}
		},
		{
			"DHAKARAMPURA",
			new List<string>
			{
				"WARD NO-22",
			}
		},
		{
			"DHAKAGULSHAN",
			new List<string>
			{
				"WARD NO-19 (PART)",
			}
		},
		{
			"DHAKAADABOR",
			new List<string>
			{
				"WARD NO-33 (PART) (46)",
				"WARD NO-30 (43)",
			}
		},
		{
			"DHAKAHAZARIBAGH",
			new List<string>
			{
				"WARD NO-14 (48)(PART)",
				"WARD NO-22 (58)",
			}
		},
		{
			"DHAKASHER-E-BANGLA NAGAR",
			new List<string>
			{
				"WARD NO-16 (PART)",
				"WARD NO-17 (51) (PART)",
				"WARD NO-28 (41)",
				"WARD NO-27 (PART) (40)",
			}
		},
		{
			"DHAKABHANSAN TEK",
			new List<string>
			{
				"WARD NO-15 (PART)",
			}
		},
		{
			"DHAKAKAMRANGIR CHAR",
			new List<string>
			{
				"SULTANGANJ",
			}
		},
		{
			"DHAKAKERANIGANJ",
			new List<string>
			{
				"SAKTA",
				"KONDA",
				"KALATIA",
				"TARANAGAR",
				"SUBHADYA",
				"TEGHARIA",
				"BASTA",
				"RUHITPUR",
				"HAZRATPUR",
				"ZINJIRA",
				"KALINDI",
			}
		},
		{
			"DHAKAKOTWALI",
			new List<string>
			{
				"WARD NO-05",
				"CHAR KOWA",
				"WARD NO-14",
				"WARD NO-08",
				"WARD NO-18",
				"WARD NO-09",
				"WARD NO-16",
				"WARD NO-13",
				"WARD NO-20",
				"WARD NO-01",
				"WARD NO-19",
				"WARD NO-11",
				"WARD NO-02",
				"WARD NO-23",
				"WARD NO-25",
				"SHAYESTABAD",
				"JAGUA",
				"CHAR BARIA",
				"TUNGIBARIA",
				"CHANDPURA",
				"WARD NO-04",
				"ROY PASHA KARAPUR",
				"CHAR MONAI",
				"CHANDRA MOHAN",
				"WARD NO-03",
				"KASHIPUR",
				"WARD NO-28",
				"WARD NO-27",
				"WARD NO-15",
				"WARD NO-22",
				"WARD NO-12",
				"WARD NO-21",
				"WARD NO-32",
				"WARD NO-33",
				"WARD NO-31",
				"WARD NO-16 (PART)",
				"WARD NO-35 (71)(PART)",
				"WARD NO-32 (68)(PART)",
				"WARD NO-37 (73)",
				"WARD NO-36 (72)",
				"LEBUTALA",
				"WARD NO-07",
				"NARENDRAPUR",
				"ICHHALI",
				"HAIBATPUR",
				"ARABPUR",
				"FATHEHPUR",
				"UPASAHAR",
				"WARD NO-06",
				"CHURAMANKATI",
				"BASUNDIA",
				"DIARA",
				"KASHIMPUR",
				"CHANCHRA",
				"RAMNAGAR",
				"NOAPARA",
				"KACHUA",
			}
		},
		{
			"DHAKABANGSHAL",
			new List<string>
			{
				"WARD NO-35 (71)(PART)",
				"WARD NO-34 (70)",
			}
		},
		{
			"DHAKACHAK BAZAR",
			new List<string>
			{
				"WARD NO-30 (66)(PART)",
				"WARD NO-29 (65)",
			}
		},
		{
			"DHAKALALBAGH",
			new List<string>
			{
				"WARD NO-23 (59)",
				"WARD NO-25 (61)",
			}
		},
		{
			"DHAKAPALLABI",
			new List<string>
			{
				"WARD NO-03",
				"WARD NO-06 (PART)",
				"WARD NO-02",
				"WARD NO-05",
			}
		},
		{
			"DHAKADARUS SALAM",
			new List<string>
			{
				"WARD NO-10",
				"WARD NO-09",
			}
		},
		{
			"DHAKAMIRPUR",
			new List<string>
			{
				"WARD NO-11",
				"WARD NO-13",
				"WARD NO-07 (PART)",
				"CHAK MIRPUR",
				"AMLA",
				"BAHALBARIA",
				"AMBARIA",
				"CHHATIAN",
				"WARD NO-02",
				"WARD NO-03",
				"FULBARIA",
				"KURSHA",
				"PORADAHA",
				"SARDARPUR",
				"CHITHULIA",
				"TALBARIA",
				"BARUI PARA",
				"MALIHAD",
				"MIRPUR",
			}
		},
		{
			"DHAKASHAH ALI",
			new List<string>
			{
				"WARD NO-08",
			}
		},
		{
			"DHAKATURAG",
			new List<string>
			{
				"HARIRAMPUR",
			}
		},
		{
			"DHAKAMOHAMMADPUR",
			new List<string>
			{
				"MOHAMMADPUR PURBA",
				"MOHAMMADPUR",
				"WARD NO-32 (45)",
				"WARD NO-31 (44)",
				"WARD NO-29 (42)",
				"WARD NO-34 (PART) (47)",
				"BINODEPUR",
				"NAHATA",
				"BABUKHALI",
				"RAJAPUR",
				"BALIDIA",
				"DIGHA",
				"PALASHBARIA",
			}
		},
		{
			"DHAKAMOTIJHEEL",
			new List<string>
			{
				"WARD NO-10 (33)",
				"WARD NO-08 (PART) (31)",
			}
		},
		{
			"DHAKAPALTAN",
			new List<string>
			{
				"WARD NO-13 (36)",
			}
		},
		{
			"DHAKARAMNA",
			new List<string>
			{
				"RAMNA",
				"RAMNAGAR",
				"RAMNARAYANPUR",
				"WARD NO-36 (55)",
				"WARD NO-19 (53)",
				"WARD NO-35 (54)",
				"RAMNATHPUR",
			}
		},
		{
			"DHAKASHAHBAGH",
			new List<string>
			{
				"WARD NO-20 (56)(PART)",
			}
		},
		{
			"DHAKASHAHJAHANPUR",
			new List<string>
			{
				"WARD NO-12 (35)",
				"SHAHJAHANPUR",
			}
		},
		{
			"DHAKAMUGDA PARA",
			new List<string>
			{
				"WARD NO-06 (29)",
			}
		},
		{
			"DHAKASAVAR",
			new List<string>
			{
				"YEARPUR",
				"PATHALIA",
				"SHIMULIA",
				"ASHULIA",
				"TETULJHORA",
				"BANAGRAM",
				"SAVAR",
				"WARD NO-07",
				"BIRALIA",
				"DHAMSANA",
				"BHAKURTA",
				"KAUNDIA",
			}
		},
		{
			"DHAKASHYAMPUR",
			new List<string>
			{
				"SHYAMPUR",
				"WARD NO-54 (90)",
				"WARD NO-47 (83)",
				"WARD NO-51 (87)",
			}
		},
		{
			"DHAKAGENDARIA",
			new List<string>
			{
				"WARD NO-46 (82)",
			}
		},
		{
			"DHAKASUTRAPUR",
			new List<string>
			{
				"WARD NO-42 (78)",
				"WARD NO-43 (79)",
				"SUTRAPUR",
			}
		},
		{
			"DHAKAWARI",
			new List<string>
			{
				"MIR WARISHPUR",
				"WARD NO-41 (77)",
				"WARD NO-38 (74)",
				"MAHESHWARIPUR",
				"ISHWARIPUR",
				"WARD NO-04",
				"BHITARBAND",
				"KEDAR",
				"SANTOSHPUR",
				"RAMKHANA",
				"KALIGANJ",
				"BALLABHER KHAS",
				"BERUBARI",
				"BAMANDANGA",
				"NEWASHI",
				"WARD NO-07",
				"ROYGANJ",
				"KACHAKATA",
				"HASNABAD",
				"NARAYANPUR",
				"WARD NO-05",
				"WARD NO-09",
				"NOONKHAWA",
				"WARD NO-08",
				"WARD NO-06",
				"BANWARINAGAR",
				"MIRZAPUR",
				"ALOWA KHOWA",
				"RADHANAGAR",
				"TARIA",
				"BALARAMPUR",
				"DHAMOR",
			}
		},
		{
			"DHAKATEJGAON",
			new List<string>
			{
				"WARD NO-26 (39)",
				"WARD NO-25 (PART) (38)",
				"WARD NO- 24(37)",
			}
		},
		{
			"DHAKATEJGAON IND AREA",
			new List<string>
			{
				"WARD NO- 24(37)",
				"WARD NO-25 (PART) (38)",
			}
		},
		{
			"DHAKABIMAN BANDAR",
			new List<string>
			{
				"WARD NO-01(PART)",
			}
		},
		{
			"DHAKADAKSHINKHAN",
			new List<string>
			{
				"DAKSHINKHAN (PART)",
				"DAKSHINKHAN(PART)",
			}
		},
		{
			"DHAKAUTTARA",
			new List<string>
			{
				"WARD NO-01(PART)",
			}
		},
		{
			"DHAKARUPNAGAR",
			new List<string>
			{
				"WARD NO-06 (PART)",
			}
		},
		{
			"FARIDPURALFADANGA",
			new List<string>
			{
				"PANCHURIA",
				"GOPALPUR",
				"ALFADANGA",
				"BANA",
				"BURAICH",
				"TAGARBANDA",
			}
		},
		{
			"FARIDPURBHANGA",
			new List<string>
			{
				"MATIBHANGA",
				"MAITBHANGA",
				"BANDUK BHANGA",
				"NASIRABAD",
				"CHANDRA",
				"HAMIRDI",
				"AZIMNAGAR",
				"ALGI",
				"WARD NO-04",
				"CHUMORDI",
				"KALAMRIDHA",
				"KAOLIBERA",
				"GHARUA",
				"TUZARPUR",
				"MANIKDAHA",
				"NURULLAGANJ",
				"HATEBHANGA",
				"PATUABHANGA",
				"BHANGABARIA",
				"KASHTABHANGA",
				"DANTBHANGA",
				"TANGBHANGA",
				"NAYA NAOBHANGA",
				"BHANGABARI",
			}
		},
		{
			"FARIDPURBOALMARI",
			new List<string>
			{
				"PARAMESHWARDI",
				"DADPUR",
				"MOYNA",
				"SATAIR",
				"WARD NO-03",
				"RUPAPAT",
				"CHANDPUR",
				"SHEKHAR",
				"CHATUL",
				"GHOSHPUR",
				"GUNBAHA",
			}
		},
		{
			"FARIDPURCHAR BHADRASAN",
			new List<string>
			{
				"GAZIRTEK",
				"CHAR BHADRASAN",
				"CHAR HARIRAMPUR",
			}
		},
		{
			"FARIDPURFARIDPUR SADAR",
			new List<string>
			{
				"WARD NO-05",
				"KRISHNANAGAR",
				"WARD NO-04",
				"AMBIKAPUR",
				"WARD NO-03",
				"GREDA",
				"WARD NO-01",
				"KANAIPUR",
				"WARD NO-02",
				"WARD NO-09",
				"KAIJURI",
				"MAJCHAR",
				"CHAR MADHABDIA",
				"DECREERCHAR",
				"ISHAN GOPALPUR",
				"ALIABAD",
				"UTTAR CHANNEL",
				"WARD NO-08",
			}
		},
		{
			"FARIDPURMADHUKHALI",
			new List<string>
			{
				"MADHUKHALI",
				"BAGAT",
				"RAIPUR",
				"KORAKDI",
				"NOAPARA",
				"GAJNA",
				"ARPARA",
				"KAMARKHALI",
				"DUMAIN",
				"JAHAPUR",
			}
		},
		{
			"FARIDPURSHALTHA",
			new List<string>
			{
				"ATGHAR",
				"RAMKANTAPUR",
				"BHAWAL",
				"GATTI",
				"JADUNANDI",
				"BALLABHDI",
				"MAJHARDIA",
				"SONAPUR",
			}
		},
		{
			"FARIDPURNAGARKANDA",
			new List<string>
			{
				"WARD NO-01",
				"WARD NO-07",
				"TALMA",
				"CHAR JASORDI",
				"RAMNAGAR",
				"PURA PARA",
				"KAICHAIL",
				"DANGI",
				"LASKARDIA",
				"PHULSUTI",
				"WARD NO-03",
			}
		},
		{
			"FARIDPURSADARPUR",
			new List<string>
			{
				"AKTER CHAR",
				"KRISHNAPUR",
				"SADARPUR",
				"BHASHANCHAR",
				"CHAR NASIRPUR",
				"CHAR MANAIR",
				"CHAR BISHNUPUR",
				"DHEUKHALI",
			}
		},
		{
			"GAZIPURGAZIPUR SADAR",
			new List<string>
			{
				"MIRZAPUR",
				"BHAWALGARH",
				"PIRUJALI",
				"WARD NO-41",
				"WARD NO-11",
				"WARD NO-21",
				"WARD NO-20",
				"WARD NO-52",
				"WARD NO-42",
				"WARD NO-34",
				"WARD NO-27",
				"WARD NO-23",
				"GAZIPUR CANT.",
				"WARD NO-24",
				"WARD NO-36",
				"WARD NO-39",
				"BARIA",
				"WARD NO-06",
				"WARD NO-30",
				"WARD NO-29",
				"WARD NO-37",
				"WARD NO-14",
				"WARD NO-40",
				"WARD NO-28",
				"WARD NO-47",
				"WARD NO-54",
				"WARD NO-46",
				"WARD NO-51",
				"WARD NO-57",
				"WARD NO-55",
				"WARD NO-16",
				"WARD NO-56",
			}
		},
		{
			"GAZIPURKALIAKAIR",
			new List<string>
			{
				"FULBARIA",
				"BOALI",
				"DHALJORA",
				"SREEFALTALI",
				"CHAPAIR",
				"WARD NO-01",
				"MOUCHAK",
				"ATABAHA",
				"MADHYAPARA",
				"WARD NO-09",
				"SUTRAPUR",
			}
		},
		{
			"GAZIPURKALIGANJ",
			new List<string>
			{
				"BAKTARPUR",
				"JAMALPUR",
				"MOKTARPUR",
				"WARD NO-05",
				"BAHADURSADI",
				"TUMULIA",
				"WARD NO-03",
				"JANGALIA",
				"WARD NO-06",
				"SUNDARPUR DURGAPUR",
				"TRILOCHANPUR",
				"NIAMATPUR",
				"RAKHALGACHHI",
				"KASHTABHANGA",
				"ROYGRAM",
				"BARA BAZAR",
				"KOLA",
				"JAMAL",
				"SIMLA ROKONPUR",
				"MALIAT",
				"KUSHLIA",
				"BHARA SIMLA",
				"CHAMPAPHUL",
				"NALTA",
				"DHALBARIA",
				"BISHNUPUR",
				"RATANPUR",
				"DAKSHIN SREEPUR",
				"KRISHNANAGAR",
				"MAUTALA",
				"TARALI",
				"MATHURESHPUR",
				"KALIGANJ",
				"TUSHBHANDAR",
				"KAKINA",
				"BHOTEMARI",
				"DALAGRAM",
				"MADATI",
				"CHANDRAPUR",
				"GORAL",
				"CHALBALA",
				"KAJAL DIGHI KALIGANJ",
				"NAGARI",
			}
		},
		{
			"GAZIPURKAPASIA",
			new List<string>
			{
				"KARIHATA",
				"SANMANIA",
				"RAYED",
				"TARGAON",
				"GHAGOTIA",
				"BARISHABA",
				"CHANDPUR",
				"KAPASIA",
				"DURGAPUR",
				"TOKE",
				"SINGASREE",
			}
		},
		{
			"GAZIPURSREEPUR",
			new List<string>
			{
				"SREEPUR KHARANDWIP",
				"SREEPUR",
				"MAONA",
				"WARD NO-05",
				"PRAHLADPUR",
				"GOSINGA",
				"GAZIPUR",
				"RAJABARI",
				"BARMI",
				"WARD NO-08",
				"WARD NO-02",
				"KAORAID",
				"WARD NO-04",
				"TELIHATI",
				"NAKOL",
				"SREEKOL",
				"GAYESHPUR",
				"SABDALPUR",
				"KADIR PARA",
				"AMALSAR",
				"DARIAPUR",
				"DAKSHIN SREEPUR",
				"UTTAR SREEPUR",
			}
		},
		{
			"GOPALGANJGOPALGANJ SADAR",
			new List<string>
			{
				"GOPINATHPUR",
				"WARD NO-09",
				"RAGHUNATHPUR",
				"ULPUR",
				"PAIKKANDI",
				"GOBRA",
				"KATI",
				"SATPAR",
				"SAHAPUR",
				"MAJHIGATI",
				"JALALABAD",
				"KARPARA",
				"WARD NO-07",
				"BAULTALI",
				"WARD NO-08",
				"HARIDASPUR",
				"KAJULIA",
				"URAFI",
				"BORASI",
				"CHANDRA DIGHALIA",
				"NIZRA",
				"DURGAPUR",
				"WARD NO-02",
			}
		},
		{
			"GOPALGANJKASHIANI",
			new List<string>
			{
				"SAJAIL",
				"KASHIANI",
				"PARULIA",
				"FUKURA",
				"ORAKANDI",
				"BETHURI",
				"SINGA",
				"NIJAMKANDI",
				"MAMUDPUR",
				"RAJPAT",
				"RATAIL",
				"MAHESHPUR",
				"PUISUR",
				"HATIARA",
			}
		},
		{
			"GOPALGANJKOTALIPARA",
			new List<string>
			{
				"GHAGAR",
				"BANDHABARI",
				"PINJURI",
				"WARD NO-01",
				"HIRAN",
				"RAMSHIL",
				"KUSHLA",
				"KALABARI",
				"RADHAGANJ",
				"SUAGRAM",
				"KANDI",
				"SADULLAPUR",
			}
		},
		{
			"GOPALGANJMUKSUDPUR",
			new List<string>
			{
				"MUKSUDPUR",
				"GOHALA",
				"WARD NO-06",
				"BHABRASUR",
				"NANIKSHIR",
				"WARD NO-04",
				"JALIRPAR",
				"KHANDARPAR",
				"BAHUGRAM",
				"DIGNAGAR",
				"UJANI",
				"KASALIA",
				"MAHARAJPUR",
				"GOBINDAPUR",
				"WARD NO-09",
				"PASARGATI",
				"BATIKAMARI",
				"RAGHDI",
				"WARD NO-08",
			}
		},
		{
			"GOPALGANJTUNGIPARA",
			new List<string>
			{
				"PATGATI",
				"KUSHLI",
				"GOPALPUR",
				"BARNI",
				"DUMURIA",
			}
		},
		{
			"KISHOREGANJAUSTAGRAM",
			new List<string>
			{
				"AUSTAGRAM",
				"KHAYERPUR ABDULLAHPUR",
				"ADAMPUR",
				"BANGAL PARA",
				"KALMA",
				"PURBA AUSTAGRAM",
				"DEOGHAR",
			}
		},
		{
			"KISHOREGANJBAJITPUR",
			new List<string>
			{
				"WARD NO-06",
				"SARAR CHAR",
				"WARD NO-04",
				"WARD NO-01",
				"HILACHIA",
				"DILALPUR",
				"HUMAIPUR",
				"HALIMPUR",
				"PIRIJPUR",
				"GAZIR CHAR",
				"DIGHIRPAR",
				"BAJITPUR",
			}
		},
		{
			"KISHOREGANJBHAIRAB",
			new List<string>
			{
				"CHAR BHAIRABI",
				"SADAKPUR",
				"WARD NO-12",
				"WARD NO-08",
				"WARD NO-01",
				"WARD NO-11",
				"SREENAGAR",
				"KALIKA PRASAD",
				"SHIBPUR",
				"WARD NO-04",
				"SHIMULKANDI",
				"GAZARIA",
				"WARD NO-09",
				"AGANAGAR",
			}
		},
		{
			"KISHOREGANJHOSSAINPUR",
			new List<string>
			{
				"SIDHLA",
				"JINARI",
				"WARD NO-08",
				"GOBINDAPUR",
				"PUMDI",
				"ARAIBARIA",
				"SAHEDAL",
				"HOSSAINPUR",
			}
		},
		{
			"KISHOREGANJITNA",
			new List<string>
			{
				"ITNA",
				"BADLA",
				"JOY SIDDHI",
				"RAITUTI",
				"ELONGJURI",
				"CHAUGANGA",
				"BARIBARI",
				"MRIGA",
			}
		},
		{
			"KISHOREGANJKARIMGANJ",
			new List<string>
			{
				"KADIR JANGAL",
				"GUJADIA",
				"NOABAD",
				"JOYKA",
				"DEHUNDA",
				"GUNDHAR",
				"WARD NO-05",
				"BARAGHARIA",
				"NIAMATPUR",
				"JAFARABAD",
			}
		},
		{
			"KISHOREGANJKATIADI",
			new List<string>
			{
				"BANAGRAM",
				"WARD NO-02",
				"WARD NO-03",
				"ACHMITA",
				"KARGAON",
				"MASUA",
				"LOHAJURI",
				"JALALPUR",
				"CHANDPUR",
				"SHAHASRAM DHULDIA",
				"WARD NO-09",
				"MUMURDIA",
			}
		},
		{
			"KISHOREGANJKISHOREGANJ SADAR",
			new List<string>
			{
				"JASODAL",
				"MAIJ KHAPAN",
				"WARD NO-09",
				"WARD NO-08",
				"WARD NO-04",
				"RASHIDABAD",
				"BAULAI",
				"WARD NO-07",
				"LATIBABAD",
				"CHAUDDASATA",
				"DANA PATALI",
				"BINNATI",
				"KORSHA KARIAIL",
				"WARD NO-01",
			}
		},
		{
			"KISHOREGANJKULIAR CHAR",
			new List<string>
			{
				"SALUA",
				"CHHAYSUTI",
				"WARD NO-05",
				"WARD NO-03",
				"RAMDI",
				"GOBARIA ABDULLAHPUR",
				"WARD NO-08",
			}
		},
		{
			"KISHOREGANJMITHAMAIN",
			new List<string>
			{
				"GHAGRA",
				"DHAKI",
				"MITHAMAIN",
				"GOPEDIGHI",
				"KHATKHAL",
				"KEORJORI",
			}
		},
		{
			"KISHOREGANJNIKLI",
			new List<string>
			{
				"JARAITALA",
				"NIKLI",
				"KARPASHA",
				"DAMPARA",
				"SINGPUR",
				"CHHATIR CHAR",
			}
		},
		{
			"KISHOREGANJPAKUNDIA",
			new List<string>
			{
				"BARUDIA",
				"WARD NO-05",
				"CHANDI PASHA",
				"WARD NO-08",
				"HOSENDI",
				"NARANDI",
				"EGARASINDUR",
				"JANGALIA",
				"SUKHIA",
				"CHAR FARADI",
				"PATUABHANGA",
				"WARD NO-01",
			}
		},
		{
			"KISHOREGANJTARAIL",
			new List<string>
			{
				"JAWAR",
				"RAUTI",
				"TARAIL SACHAIL",
				"TALGANGA",
				"DAMIHA",
				"DHALA",
			}
		},
		{
			"MADARIPURKALKINI",
			new List<string>
			{
				"CHAR KALKINI",
				"ALINAGAR",
				"DASAR",
				"KAZIBAKAI",
				"WARD NO-01",
				"SHIKAR MANGAL",
				"KAYARIA",
				"BALIGRAM",
				"WARD NO-04",
				"RAMJANPUR",
				"NABAGRAM",
				"SAHEBRAMPUR",
				"ENAYETNAGAR",
				"LAKSHMIPUR",
				"CHAR DAULAT KHAN",
				"WARD NO-09",
				"BANSHGARI",
			}
		},
		{
			"MADARIPURMADARIPUR SADAR",
			new List<string>
			{
				"WARD NO-02",
				"KUNIA",
				"DHURAIL",
				"WARD NO-05",
				"WARD NO-01",
				"WARD NO-08",
				"WARD NO-04",
				"KALIKAPUR",
				"DUDKHALI",
				"KHOAJPUR",
				"KENDUA",
				"CHILAR CHAR",
				"PEARPUR",
				"WARD NO-07",
				"SIRKHARA",
				"PANCHKHOLA",
				"MUSTAFAPUR",
				"JHAUDI",
				"BAHADURPUR",
				"RASTI",
				"WARD NO-06",
			}
		},
		{
			"MADARIPURRAJOIR",
			new List<string>
			{
				"BADAR PASHA",
				"KHALIA",
				"BAJITPUR",
				"AMGRAM",
				"ISIBPUR",
				"KADAMBARI",
				"HARIDASDI MAHENDRADI",
				"PAIK PARA",
				"RAJOIR",
				"HOSSAINPUR",
				"KABIRAJPUR",
				"WARD NO-06",
			}
		},
		{
			"MADARIPURSHIB CHAR",
			new List<string>
			{
				"SIRUAIL",
				"BAHERATALA UTTAR",
				"UMEDPUR",
				"WARD NO-03",
				"WARD NO-09",
				"WARD NO-05",
				"PANCH CHAR",
				"MATBARER CHAR",
				"DATTA PARA",
				"KADIRPUR",
				"BHANDARIKANDI",
				"KANTHALBARI",
				"BAHERATALA DAKSHIN",
				"NILAKHI",
				"BANSHKANDI",
				"SANNYASIR CHAR",
				"CHAR JANAJAT",
				"BANDARKHOLA",
				"KUTUBPUR",
				"WARD NO-01",
			}
		},
		{
			"MANIKGANJDAULATPUR",
			new List<string>
			{
				"DAULATPUR",
				"DAULATPUR (PURBA PANCHGACHHIA)",
				"CHAK MIRPUR",
				"KALIA",
				"BACHAMARA",
				"BAGHUTIA",
				"CHARKATARI",
				"DHAMSAR",
				"KHALSI",
				"JIYANPUR",
				"WARD NO-06",
				"WARD NO-05",
				"WARD NO-01",
				"WARD NO-03",
				"WARD NO-02 (PART)",
				"WARD NO-04",
				"ARANGHATA",
				"MATHURAPUR",
				"REFAYETPUR",
				"KHALISHAKUNDI",
				"CHILMARI",
				"PRAYAGPUR",
				"PHILIPNAGAR",
				"ARIA",
				"PEARPUR",
				"HOGALBARIA",
				"RAMKRISHNAPUR",
				"MARICHA",
				"BOALIA",
				"ADABARIA",
				"ROY DAULATPUR",
			}
		},
		{
			"MANIKGANJGHIOR",
			new List<string>
			{
				"PAILA",
				"GHIOR",
				"NALI",
				"SINGJURI",
				"BALIAKHORA",
				"BANIAJURI",
				"BARATIA",
			}
		},
		{
			"MANIKGANJHARIRAMPUR",
			new List<string>
			{
				"HARIRAMPUR",
				"CHAR HARIRAMPUR",
				"DHULSUNRA",
				"RAMKRISHNAPUR",
				"GALA",
				"HARUKANDI",
				"BOYRA",
				"BALARA",
				"CHALA",
				"BALLA",
				"AZIMNAGAR",
			}
		},
		{
			"MANIKGANJMANIKGANJ SADAR",
			new List<string>
			{
				"GARPARA",
				"WARD NO-02",
				"DIGHI",
				"WARD NO-05",
				"HATI PARA",
				"WARD NO-06",
				"ATIGRAM",
				"PUTAIL",
				"WARD NO-04",
				"NABAGRAM",
				"WARD NO-07",
				"BETILA MITARA",
				"WARD NO-09",
				"KRISHNAPUR",
				"WARD NO-01",
				"JAIGIR",
			}
		},
		{
			"MANIKGANJSATURIA",
			new List<string>
			{
				"SATURIA",
				"CHIRA PARA PARSATURIA",
				"BALIATI",
				"DHANKORA",
				"DARAGRAM",
				"TILLI",
				"BARAID",
				"HARGAZ",
				"FUKURHATI",
			}
		},
		{
			"MANIKGANJSHIBALAYA",
			new List<string>
			{
				"TEOTA",
				"SHIMULIA",
				"UTHALI",
				"ULAIL",
				"MOHADEBPUR",
				"SHIBALAYA",
			}
		},
		{
			"MANIKGANJSINGAIR",
			new List<string>
			{
				"TALIBPUR",
				"JAMIRTA",
				"JAMSHA",
				"SINGAIR",
				"JOY MANTAP",
				"WARD NO-03",
				"BOYRA",
				"BALDHARA",
				"CHARIGRAM",
				"SAISTA",
				"DHALLA",
				"CHANDHAR",
			}
		},
		{
			"MUNSHIGANJGAZARIA",
			new List<string>
			{
				"GAZARIA",
				"IMAMPUR",
				"TENGER CHAR",
				"BALUAKANDI",
				"GUAGACHHIA",
				"HOSSAINDI",
				"BHABER CHAR",
				"BAUSIA",
			}
		},
		{
			"MUNSHIGANJLOHAJANG",
			new List<string>
			{
				"MEDINI MANDAL",
				"GAODIA",
				"LOHAJANG TEOTIA",
				"BEJGAON",
				"HALDIA",
				"BAULTALI",
				"KHIDIR PARA",
			}
		},
		{
			"MUNSHIGANJMUNSHIGANJ SADAR",
			new List<string>
			{
				"MOLLAHKANDI",
				"CHAR KEWAR",
				"PANCHASAR",
				"WARD NO-01",
				"WARD NO-06",
				"WARD NO-01 (MIRKADIM)",
				"RAMPAL",
				"WARD NO-02",
				"BANGLA BAZAR",
				"ADHARA",
				"SILAI",
				"WARD NO-08",
			}
		},
		{
			"MUNSHIGANJSERAJDIKHAN",
			new List<string>
			{
				"RAJANAGAR",
				"LATABDI",
				"KAYAIN",
				"SEKHARNAGAR",
				"MADHYAPARA",
				"CHITRAKOT",
				"ICHHAPUR",
				"RASUNIA",
				"BALUR CHAR",
				"KOLA",
				"BASAIL",
			}
		},
		{
			"MUNSHIGANJSREENAGAR",
			new List<string>
			{
				"SREENAGAR",
				"TANTAR",
				"HASARA",
				"PATABHOG",
				"KOLA PARA",
				"BARAIKHALI",
				"KUKUTIA",
				"BAGHRA",
				"BIRTARA",
				"BHAGYAKUL",
				"SHYAMSIDDHI",
			}
		},
		{
			"MUNSHIGANJTONGIBARI",
			new List<string>
			{
				"JASHALONG",
				"ARIAL",
				"KAMARKHARA",
				"HASAIL BANARI",
				"SONARANG TONGIBARI",
				"DHIPUR",
				"ABDULLAHPUR",
				"AUTSHAHI",
				"DIGHIR PARA",
				"PANCHGAON",
				"BETKA",
			}
		},
		{
			"NARAYANGANJARAIHAZAR",
			new List<string>
			{
				"DUPTARA",
				"ARAIHAZAR",
				"SADASARDI",
				"BRAHMANDI",
				"KALA PAHARIA",
				"SATGRAM",
				"HAIZADI",
				"BISHNANDI",
				"UCHITPUR",
				"KHAGAKANDA",
			}
		},
		{
			"NARAYANGANJSONARGAON",
			new List<string>
			{
				"WARD NO-08",
				"MUGRA PARA",
				"SADIPUR",
				"KACHPUR",
				"JAMPUR",
				"SHAMBHUPURA",
				"BAIDYER BAZAR",
				"SANMANDI",
				"PIRIJPUR",
				"NOAGAON",
				"BARADI",
			}
		},
		{
			"NARAYANGANJBANDAR",
			new List<string>
			{
				"WARD NO-05",
				"RAJBILA",
				"SUWALAK",
				"BANDARBAN",
				"KUHALONG",
				"WARD NO-08",
				"WARD NO-01(PART)",
				"BANDARKHOLA",
				"BANDAR",
				"WARD NO-23 (CITY CORP.)",
				"MADANPUR",
				"MUSAPUR",
				"KALAGACHHIA UNION",
				"WARD NO-27 (CITY CORP.)",
				"WARD NO-25 (CITY CORP.)",
				"ABDULPUR",
				"SAINTARA",
				"SATNALA",
				"ALOKDIHI",
				"FATEHJANAPUR",
				"ISABPUR",
				"AULIA PUKUR",
				"BHIAIL",
				"NASRATPUR",
				"AMARPUR",
				"PUNATTI",
				"TENTULIA",
			}
		},
		{
			"NARAYANGANJNARAYANGANJ SADAR",
			new List<string>
			{
				"WARD NO-03",
				"KUTUBPUR",
				"FATULLAH",
				"WARD NO-01 (CITY CORP.)",
				"WARD NO-02",
				"WARD NO-10",
				"WARD NO-17",
				"GOGNAGAR",
				"WARD NO-16",
				"WARD NO-11",
				"WARD NO-13",
				"WARD NO-15",
				"KASHIPUR",
				"WARD NO-07",
				"ENAYETNAGAR",
				"WARD NO-06",
				"WARD NO-08",
				"WARD NO-09",
				"ALIR TEK",
				"BAKTABALLI",
			}
		},
		{
			"NARAYANGANJRUPGANJ",
			new List<string>
			{
				"BHOLABA",
				"RUPGANJ",
				"MURA PARA",
				"WARD NO-06",
				"KAYET PARA",
				"WARD NO-01 (TARABO)",
				"BULTA",
				"WARD NO-03",
				"DAUDPUR",
				"WARD NO-09",
				"GOLAKANDAIL",
			}
		},
		{
			"NARSINGDIBELABO",
			new List<string>
			{
				"PATULI",
				"BAJNABA",
				"NARAYANPUR",
				"BINYABAID",
				"BELABO",
				"AMLABA",
				"CHAR UJILABA",
			}
		},
		{
			"NARSINGDIMANOHARDI",
			new List<string>
			{
				"EKDUARIA",
				"KHIDIRPUR",
				"BARA CHAPA",
				"CHALAK CHAR",
				"CHAR MANDALIA",
				"LEBUTALA",
				"WARD NO-04",
				"WARD NO-03",
				"GOTASHIA",
				"CHANDANBARI",
				"SHUKUNDI",
				"KANCHIKATA",
				"DAULATPUR",
				"KRISHNAPUR",
				"MANOHARDIA",
			}
		},
		{
			"NARSINGDINARSINGDI SADAR",
			new List<string>
			{
				"CHAR DIGHALDI",
				"KANTHALIA",
				"HAJIPUR",
				"CHINISHPUR",
				"PANCHDONA",
				"WARD NO-05",
				"WARD NO-01 (NARSINGDI)",
				"WARD NO-04",
				"SILMANDI",
				"WARD NO-02",
				"PAIKAR CHAR",
				"KARIMPUR",
				"AMDIA",
				"NAZARPUR",
				"NURALLA PUR U/C",
				"ALOKBALI",
				"MEHER PARA",
			}
		},
		{
			"NARSINGDIPALASH",
			new List<string>
			{
				"JINARDI",
				"WARD NO-07",
				"DANGA",
				"CHAR SINDUR",
				"GAZARIA",
				"WARD NO-03",
				"WARD NO-01",
				"WARD NO-04",
				"PALASHTALI",
				"PALASHBARIA",
				"PALASHBARI",
				"BETKAPA",
				"PABNAPUR",
				"BARISAL",
				"HOSSAINPUR",
				"MANOHARPUR",
				"MOHADIPUR",
				"HARINATHPUR",
				"KISHOREGARI",
				"PALASHI",
				"BARA PALASHBARI",
				"PALASH",
			}
		},
		{
			"NARSINGDIROYPURA",
			new List<string>
			{
				"MARJAL",
				"CHANDPUR",
				"CHANDERKANDI",
				"CHAR SUBUDDI",
				"WARD NO-03",
				"AMIRGANJ",
				"MIRZAPUR",
				"HAIRMARA",
				"BANSHGARI",
				"MUSAPUR",
				"ROYPURA",
				"PARATALI",
				"SREENAGAR",
				"ADIABAD",
				"RADHANAGAR",
				"NILAKHYA",
				"MIRZANAGAR",
				"PALASHTALI",
				"MAHESHPUR",
				"UTTAR BAKHARNAGAR",
				"CHAR MADHUA",
				"MIRZAR CHAR",
			}
		},
		{
			"NARSINGDISHIBPUR",
			new List<string>
			{
				"PADRI SHIBPUR",
				"CHAR SHIBPUR",
				"SHIBPUR",
				"DULALPUR",
				"JOYNAGAR",
				"CHAK RADHA",
				"WARD NO-06",
				"PUTIA",
				"SADHAR CHAR",
				"AYUBPUR",
				"BAGHABA",
				"MASIMPUR",
				"JOSAR",
			}
		},
		{
			"RAJBARIBALIAKANDI",
			new List<string>
			{
				"ISLAMPUR",
				"NAWABPUR",
				"BALIAKANDI",
				"BAHARPUR",
				"JANGAL",
				"JAMALPUR",
				"NARUA",
			}
		},
		{
			"RAJBARIGOALANDA",
			new List<string>
			{
				"UJAN CHAR",
				"DAULATDIA",
				"CHHOTA BHAKLA",
			}
		},
		{
			"RAJBARIPANGSHA",
			new List<string>
			{
				"JASHAI",
				"WARD NO-07",
				"WARD NO-04",
				"HABASPUR",
				"MACHH PARA",
				"KASBA MAJHAIL",
				"WARD NO-03",
				"BAHADURPUR",
				"KALIMAHAR",
				"MAURAT",
				"SARISHA",
				"PATTA",
				"WARD NO-02",
				"BABUPARA",
			}
		},
		{
			"RAJBARIKALUKHALI",
			new List<string>
			{
				"RATANDIA",
				"MRIGI",
				"SAORAIL",
				"BOALIA",
				"MADAPUR",
				"MAJHBARI",
				"KALIKAPUR",
			}
		},
		{
			"RAJBARIRAJBARI SADAR",
			new List<string>
			{
				"KHANGANJ",
				"BARAT",
				"BANIBAHA",
				"WARD NO-09",
				"KHANKHANAPUR",
				"WARD NO-04",
				"WARD NO-07",
				"WARD NO-01",
				"BASANTAPUR",
				"MIZANPUR",
				"ALIPUR",
				"RAMKANTAPUR",
				"MULGHAR",
				"CHANDANI",
				"SULTANPUR",
				"WARD NO-06",
				"WARD NO-02",
				"SHAHID WAHABPUR",
			}
		},
		{
			"SHARIATPURBHEDARGANJ",
			new List<string>
			{
				"DHAKHIN TARABUNIA",
				"DIGAR MAHISHKHALI",
				"SAKHIPUR",
				"CHAR CENSUS",
				"RAMBHADRAPUR",
				"CHAR BHAGA",
				"MAHISAR",
				"CHHAYGAON",
				"CHAR KUMARIA",
				"KACHIKATA",
				"TARABUNIA",
				"NARAYANPUR",
			}
		},
		{
			"SHARIATPURDAMUDYA",
			new List<string>
			{
				"PURBA DAMUDYA",
				"WARD NO-06",
				"WARD NO-07",
				"WARD NO-03",
				"KANESHWAR",
				"DARUL AMAN",
				"SIDULKURA",
				"DHANKATI",
				"SIDYA",
			}
		},
		{
			"SHARIATPURGOSAIRHAT",
			new List<string>
			{
				"KUCHAIPATTI",
				"ALADLPUR CHAR",
				"KODALPUR",
				"IDILPUR",
				"NALMURI",
				"SAMANTASAR",
				"NAGER PARA",
			}
		},
		{
			"SHARIATPURNARIA",
			new List<string>
			{
				"KEDARPUR",
				"BIJHARI",
				"JAPSA",
				"GHARISAR",
				"WARD NO-01",
				"BHOJESHWAR",
				"WARD NO-02",
				"DINGA MANIK",
				"CHAR ATRA",
				"WARD NO-07",
				"MUKTARER CHAR",
				"CHAMTA",
				"BHUMKHARA",
			}
		},
		{
			"SHARIATPURSHARIATPUR SADAR",
			new List<string>
			{
				"RUDRAKAR",
				"WARD NO-01",
				"CHIKANDI",
				"WARD NO-09",
				"CHANDRAPUR",
				"BINODPUR",
				"SHAUL PARA",
				"ANGARIA",
				"CHITALIA",
				"MOHAMMADPUR",
				"DOMSAR",
				"TULASAR",
			}
		},
		{
			"SHARIATPURZANJIRA",
			new List<string>
			{
				"WARD NO-01",
				"BARA KRISHNAGAR",
				"MULNA",
				"NAODOBA",
				"BILASPUR",
				"JOYNAGAR",
				"PALER CHAR",
				"PURBA NAODOBA",
				"KUNDER CHAR",
				"SENER CHAR",
				"BARAKANDI",
			}
		},
		{
			"TANGAILBASAIL",
			new List<string>
			{
				"BASAIL",
				"FULKI",
				"KANCHANPUR",
				"KAOALJANI",
				"KASHIL",
				"HABLA",
				"WARD-04",
			}
		},
		{
			"TANGAILBHUAPUR",
			new List<string>
			{
				"GABSARA",
				"FALDA",
				"NIKRAIL",
				"GOBINDASI",
				"WARD NO-04",
				"ARJUNA",
				"ALOA",
				"WARD NO-02",
			}
		},
		{
			"TANGAILDELDUAR",
			new List<string>
			{
				"LAUHATI",
				"ELASIN",
				"DUBAIL",
				"DELDUAR",
				"ATIA",
				"FAZILHATI",
				"PATHRAIL",
				"DEOLI",
			}
		},
		{
			"TANGAILGHATAIL",
			new List<string>
			{
				"JAMURIA",
				"RASULPUR",
				"WARD NO-08",
				"WARD NO-07",
				"ANEHOLA",
				"DIGALKANDI",
				"DHALA PARA",
				"DIGAR",
				"DEOPARA",
				"SANDHANPUR",
				"DEULABARI",
				"LAKHER PARA",
				"GHATAIL",
			}
		},
		{
			"TANGAILGOPALPUR",
			new List<string>
			{
				"CHAR GOPALPUR",
				"GOPALPUR",
				"ISHAN GOPALPUR",
				"RAMGOPALPUR",
				"NAGDA SIMLA",
				"HADIRA",
				"ALAMNAGAR",
				"HEMNAGAR",
				"JHAWAIL",
				"DHOPAKANDI",
				"WARD NO-01",
				"WARD NO-02",
				"MIRZAPUR",
			}
		},
		{
			"TANGAILDHANBARI",
			new List<string>
			{
				"MUSUDDI",
				"BIRTARA",
				"JADUNATHPUR",
				"WARD NO-04",
				"PAISKA",
				"BALIBHADRA",
				"DHOPAKHALI",
				"BANIAJAN",
				"WARD NO-02",
			}
		},
		{
			"TANGAILKALIHATI",
			new List<string>
			{
				"MAHELA",
				"SALLA",
				"BALLA",
				"BANGRA",
				"WARD NO-06",
				"WARD NO-04",
				"WARD NO-01",
				"BIR BASUNDA",
				"KOK DAHARA",
				"PARKI",
				"PAIKARA",
				"DASHKIA",
				"GOHALIABARI",
				"NARANDIA",
				"NAGBARI",
				"WARD NO-02",
				"SAHADEBPUR",
				"DURGAPUR",
			}
		},
		{
			"TANGAILMADHUPUR",
			new List<string>
			{
				"AUSNARA",
				"WARD NO-05",
				"SOLAKURI",
				"ARANKHOLA",
				"MIRZABARI",
				"WARD NO-06",
				"GOLABARI",
				"ALOKDIA",
				"WARD NO-01",
				"MADHUPUR",
				"TEPA MADHUPUR",
			}
		},
		{
			"TANGAILMIRZAPUR",
			new List<string>
			{
				"MIRZAPUR",
				"GORAI",
				"TARAFPUR",
				"LATIFPUR",
				"MAHERA",
				"WARD NO-06",
				"BANAIL",
				"JAMURKI",
				"UARSI",
				"BHATGRAM",
				"FATEHPUR",
				"BANSHTAIL",
				"BAHURIA",
				"ANAITARA",
				"AJGANA",
			}
		},
		{
			"TANGAILNAGARPUR",
			new List<string>
			{
				"NAGARPUR",
				"MAMUDNAGAR",
				"BHARA",
				"SAHABATPUR",
				"GAYHATA",
				"BHADRA",
				"PAKUTIA",
				"SALIMABAD",
				"DUPTIAIR",
				"MOKHNA",
			}
		},
		{
			"TANGAILSAKHIPUR",
			new List<string>
			{
				"SAKHIPUR",
				"WARD NO-03",
				"KALIA",
				"HATIBANDHA",
				"KALMEGHA",
				"JADABPUR",
				"BAHERATAIL",
				"GAZARIA",
				"DARIAPUR",
				"KAKRAJAN",
				"WARD NO-08",
				"WARD NO-01",
			}
		},
		{
			"TANGAILTANGAIL SADAR",
			new List<string>
			{
				"WARD NO-07",
				"WARD NO-01",
				"WARD NO-15",
				"WARD NO-13",
				"PORABARI",
				"GHARINDA",
				"HUGRA",
				"KAKUA",
				"SILIMPUR",
				"MAGRA",
				"DANYA",
				"GALA",
				"KATULI",
				"WARD NO-04",
				"WARD NO-18",
				"WARD NO-12",
				"WARD NO-09",
				"MAHAMUDNAGAR",
			}
		},
		{
			"JAMALPURBAKSHIGANJ",
			new List<string>
			{
				"MERUR CHAR",
				"NILAKSHMIA",
				"BAGAR CHAR",
				"BAKSHIGANJ",
				"DHANUA",
				"BATTAJORE",
				"SADHUR PARA",
			}
		},
		{
			"JAMALPURDEWANGANJ",
			new List<string>
			{
				"CHUKAIBARI",
				"CHAR AOMKHAOA",
				"WARD NO-04",
				"BAHADURABAD",
				"CHIKAJANI",
				"DANGDHARA",
				"WARD NO-09",
				"WARD NO-06",
				"HATEBHANGA",
				"WARD NO-07",
				"PAR RAMRAMPUR",
				"DEWANGANJ UNION",
			}
		},
		{
			"JAMALPURISLAMPUR",
			new List<string>
			{
				"ISLAMPUR",
				"CHAR PUTIMARI",
				"GOALER CHAR",
				"CHINADULLI",
				"KULKANDI",
				"BELGACHHA",
				"GAIBANDHA",
				"WARD NO-06",
				"PATHARSI",
				"NOARPARA",
				"PALBANDHA",
				"WARD NO-04",
				"CHAR GOALINI",
				"SAPDHARI",
				"DAKSHIN ISLAMPUR",
				"ISLAMPUR PASCHIM",
				"ISLAMPUR PURBA",
			}
		},
		{
			"JAMALPURJAMALPUR SADAR",
			new List<string>
			{
				"TULSIR CHAR",
				"SAHABAJPUR",
				"WARD NO-03",
				"WARD NO-04",
				"KENDUA",
				"GHORADHAP",
				"SHARIFPUR",
				"DIGPAITH",
				"RASHIDPUR",
				"SREEPUR",
				"WARD NO-08",
				"BANSHCHARA",
				"MESHTA",
				"WARD NO-12",
				"WARD NO-10",
				"LAKSHMIR CHAR",
				"TITPALLA",
				"RANAGACHHA",
				"ITAIL",
				"WARD NO-06",
				"WARD NO-07",
				"WARD NO-11",
			}
		},
		{
			"JAMALPURMADARGANJ",
			new List<string>
			{
				"ADARBHITA",
				"GUNARITALA",
				"WARD NO-04",
				"KARAICHARA",
				"SIDHULI",
				"CHAR PAKERDAHA",
				"WARD NO-03",
				"WARD NO-09",
				"JOREKHALI UNION",
				"BALIJURI",
				"WARD NO-02",
			}
		},
		{
			"JAMALPURMELANDAHA",
			new List<string>
			{
				"CHAR BANIPAKURI UNION",
				"WARD NO-06",
				"GHOSHER PARA",
				"KULIA",
				"WARD NO-09",
				"NAYANAGAR",
				"WARD NO-08",
				"FULKOCHA",
				"DURMUT",
				"JHAUGARA",
				"MAHMUDPUR",
				"NANGLA",
				"ADRA",
			}
		},
		{
			"JAMALPURSARISHABARI UPAZILA",
			new List<string>
			{
				"KAMRABAD",
				"POGALDIGHA",
				"DOAIL",
				"SATPOA",
				"WARD NO-02",
				"WARD NO-04",
				"PINGNA",
				"AONA",
				"BHATARA",
				"WARD NO-07",
				"MAHADAN",
				"WARD NO-01",
			}
		},
		{
			"MYMENSINGHBHALUKA",
			new List<string>
			{
				"MEDUARY",
				"DHITPUR",
				"HABIRBARI",
				"BHARADOBA",
				"RAJAI",
				"DAKATIA",
				"MALLIKBARI",
				"UTHURA",
				"KACHINA",
				"WARD NO-07",
				"BHALUKA",
				"BIRUNIA",
			}
		},
		{
			"MYMENSINGHDHOBAURA",
			new List<string>
			{
				"DOBAURA",
				"GUATALA",
				"BAGHBER",
				"DAKSHIN MAIJ PARA",
				"PORA KANDULIA",
				"GAMARITALA",
				"GHOSHGAON",
			}
		},
		{
			"MYMENSINGHFULBARIA",
			new List<string>
			{
				"FULBARIA",
				"RADHAKANAI",
				"RANGAMATIA",
				"WARD NO-03",
				"ACHIM PATULI",
				"DEOKHOLA",
				"BALIAN",
				"BHABANIPUR",
				"PUTIJANA",
				"KALADAHA",
				"ENAYETPUR",
				"KUSHMAIL",
				"BAKTA",
				"WARD NO-07",
				"NAOGAON",
			}
		},
		{
			"MYMENSINGHGAFFARGAON",
			new List<string>
			{
				"JESSORA",
				"NIGAIR",
				"WARD NO-05",
				"TENGABA",
				"GAFFARGAON",
				"USTHI",
				"PAITHAL",
				"MASHAKHALI",
				"PANCHBHAG",
				"RAONA",
				"RASULPUR",
				"CHAR ALGI",
				"SALTIA",
				"LANGAIR",
				"DATTER BAZAR",
				"BARABARIA",
			}
		},
		{
			"MYMENSINGHGAURIPUR",
			new List<string>
			{
				"GAURIPUR",
				"WARD NO-03",
				"RAMGOPALPUR",
				"DOWHAKHALA",
				"MAILAKANDA",
				"ACHINTAPUR",
				"WARD NO-08",
				"MAOHA",
				"BHANGNAMARI",
				"SAHANATI",
				"SIDHLA",
				"BOKAINAGAR",
				"PURBA GAURIPUR",
				"PASCHIM GAURIPUR",
			}
		},
		{
			"MYMENSINGHHALUAGHAT",
			new List<string>
			{
				"HALUAGHAT",
				"DHARA",
				"SAKUAI",
				"AMTAIL",
				"DHURAIL",
				"SWADESHI",
				"BHUBANKURA",
				"JUGLI",
				"NARAIL",
				"BILDORA",
				"GAZIR BHITA",
				"KAICHAPUR",
			}
		},
		{
			"MYMENSINGHISHWARGANJ",
			new List<string>
			{
				"JATIA",
				"MOGTOLA",
				"BARAHIT",
				"WARD NO-02",
				"WARD NO-05",
				"ATHARABARI",
				"RAJIBPUR",
				"SARISHA",
				"SOHAGI",
				"MAIJBAGH",
				"TARUNDIA",
				"UCHAKHILA",
				"WARD NO-08",
			}
		},
		{
			"MYMENSINGHMYMENSINGH SADAR",
			new List<string>
			{
				"BAIRA (KEWATKHALI) UNION",
				"BHABKHALI UNION",
				"WARD NO-15",
				"WARD NO-07",
				"WARD NO-08",
				"WARD NO-10",
				"WARD NO-05",
				"WARD NO-09",
				"WARD NO-02",
				"WARD NO-11",
				"WARD NO-17",
				"WARD NO-13",
				"WARD NO-21",
				"ASHTADHAR",
				"DAPUNIA UNION",
				"KUSHTIA UNION",
				"CHAR NILAKSHMIA UNION",
				"KHAGDAHAR UNION",
				"GHAGRA UNION",
				"SIRTA UNION",
				"WARD NO-20",
				"BORAR CHAR UNION",
				"PARANGANJ UNION",
				"WARD NO-18",
				"WARD NO-12",
				"CHAR ISHWARDIA UNION",
				"AKUA",
				"WARD NO-04",
				"WARD NO-06",
			}
		},
		{
			"MYMENSINGHMUKTAGACHHA",
			new List<string>
			{
				"DULLA",
				"KHERUAJANI",
				"TARATI UNION",
				"BASATI",
				"MANKON UNION",
				"WARD NO-06",
				"WARD NO-03",
				"WARD NO-02",
				"WARD NO-04",
				"KASHIMPUR",
				"GHOGA",
				"BARAGRAM",
				"KUMARGHATA",
				"DAOGAON",
			}
		},
		{
			"MYMENSINGHNANDAIL",
			new List<string>
			{
				"KHARUA",
				"JAHANGIRPUR",
				"SHERPUR",
				"BETAGAIR",
				"NANDAIL",
				"WARD NO-08",
				"MOAZZEMPUR",
				"SINGRAIL",
				"RAJGATI",
				"GANGAIL",
				"MUSULI",
				"ACHARGAON",
				"CHANDIPASHA",
			}
		},
		{
			"MYMENSINGHPHULPUR",
			new List<string>
			{
				"SANDHARA",
				"RAMBHADRAPUR",
				"WARD NO-07",
				"PAYARI",
				"BAOLA",
				"BHAITKANDI",
				"BALIA",
				"RAHIMGANJ",
				"RUPASI",
				"PHULPUR",
				"SINGHESHWAR",
			}
		},
		{
			"MYMENSINGHTARAKANDA",
			new List<string>
			{
				"KAKNI",
				"KAMARGAON",
				"BALIKHAN",
				"TARAKANDA",
				"BANIHALA",
				"KAMARIA",
				"GALAGAON",
				"RAMPUR",
				"BISHKA",
				"DHAKUA",
			}
		},
		{
			"MYMENSINGHTRISHAL",
			new List<string>
			{
				"KANIHARI",
				"DHANIKHOLA",
				"HARIRAMPUR",
				"MOKSHAPUR",
				"BALI PARA",
				"WARD NO-02",
				"MATHBARI",
				"BAILAR",
				"KANTHAL",
				"SAKHUA",
				"AMIRABARI",
				"TRISHAL",
				"WARD NO-01",
				"RAMPUR",
				"WARD NO-03",
			}
		},
		{
			"NETRAKONAATPARA",
			new List<string>
			{
				"SUKHARI",
				"TELIGATI",
				"BANIAJAN",
				"LONESHWAR",
				"SARMAISA",
				"SONAI",
				"DUAZ",
			}
		},
		{
			"NETRAKONABARHATTA",
			new List<string>
			{
				"BARHATTA",
				"ROYPUR",
				"ASMA",
				"SAHATA",
				"SINGDHA",
				"CHHIRAM",
				"BAUSHI",
			}
		},
		{
			"NETRAKONADURGAPUR",
			new List<string>
			{
				"DURGAPUR",
				"DAKSHIN ALGI DURGAPUR",
				"UTTAR ALGI DURGAPUR",
				"UTTAR DURGAPUR",
				"DAKSHIN DURGAPUR",
				"CHANDIGARH",
				"WARD NO-01",
				"WARD NO-07",
				"BAKALJORA",
				"KULLAGORA",
				"KAKAIRGARA",
				"GAOKANDIA",
				"WARD NO-08",
				"SUNDARPUR DURGAPUR",
				"GOSIND DURGAPUR",
				"JOYNAGAR",
				"DELUABARI",
				"WARD NO-09",
				"WARD NO-06",
				"KISMAT GANKAIR",
				"DHARMAPUR (PANANAGAR)",
				"JHALUKA",
				"NOAPARA",
				"MARIA",
			}
		},
		{
			"NETRAKONAKHALIAJURI",
			new List<string>
			{
				"CHAKUA",
				"KRISHNAPUR",
				"KHALIAJURI",
				"MENDIPUR",
				"NAGAR",
				"GAZIPUR",
			}
		},
		{
			"NETRAKONAKALMAKANDA",
			new List<string>
			{
				"KAILATI",
				"KALMAKANDA",
				"RANGCHHATI",
				"NAZIRPUR",
				"LENGURA",
				"KHARNAI",
				"BARA KHARPAN",
				"POGLA",
			}
		},
		{
			"NETRAKONAKENDUA",
			new List<string>
			{
				"KENDUA",
				"ASUJIA",
				"NOAPARA",
				"DALPA",
				"ROAILBARI",
				"GARADOBA",
				"GANDA",
				"MUZAFFARPUR",
				"SANDIKONA",
				"MASHKA",
				"CHIRANG",
				"WARD NO-02",
				"BALAISHIMUL",
			}
		},
		{
			"NETRAKONAMADAN",
			new List<string>
			{
				"MADANPURA",
				"MADANPUR",
				"FATEHPUR",
				"WARD NO-06",
				"WARD NO-07",
				"MAGHAN",
				"KAITAIL",
				"TIASREE",
				"NAYEKPUR",
				"GOBINDASREE",
				"MADAN",
				"CHANDGAON",
				"MADANKHALI",
			}
		},
		{
			"NETRAKONAMOHANGANJ",
			new List<string>
			{
				"WARD NO-09",
				"SAMAJ SAHILDEO",
				"SUAIR",
				"GAGLAJUR",
				"TENTULIA",
				"MAGHAN SIADHAR",
				"WARD NO-05",
				"WARD NO-06",
				"BARKASHIA BIRAMP",
				"MOHANGANJ",
			}
		},
		{
			"NETRAKONANETROKONA SADAR",
			new List<string>
			{
				"MADANPUR",
				"MAUGATI",
				"WARD NO-02",
				"WARD NO-06",
				"WARD NO-05",
				"MEDNI",
				"KAILATI",
				"LAKSHMIGANJ",
				"CHALLISHA",
				"AMTALA",
				"THAKURAKONA",
				"RAUHA",
				"DAKSHIN BISHIURA",
				"KALIARA GABRAGAT",
				"WARD NO-01",
				"WARD NO-03",
				"WARD NO-09",
			}
		},
		{
			"NETRAKONAPURBADHALA",
			new List<string>
			{
				"BAIRATI",
				"PURBADHALA",
				"GHAGRA",
				"JARIA",
				"NARANDIA",
				"HOGLA",
				"GOHALAKANDA",
				"DHALA MULGAON",
				"BISHKAKUNI",
				"AGIA",
				"KHALISHAUR",
			}
		},
		{
			"SHERPURJHENAIGATI",
			new List<string>
			{
				"MALIJHIKANDA",
				"JHENAIGATI",
				"KANGSHA",
				"HATIBANDHA MALIJHIKANDA",
				"DHANSHAIL",
				"GAURIPUR",
				"NALKURA",
			}
		},
		{
			"SHERPURNAKLA",
			new List<string>
			{
				"NAKLA",
				"CHAR ASHTADHAR",
				"PATHAKATA",
				"WARD NO-05",
				"CHANDRAKONA",
				"GANAPADDI",
				"GOURDWAR",
				"TALKI",
				"URPHA",
				"WARD NO-02",
			}
		},
		{
			"SHERPURNALITABARI",
			new List<string>
			{
				"WARD NO-04",
				"WARD NO-05",
				"WARD NO-07",
				"NUNNI",
				"KAKARKANDI",
				"NAYABIL",
				"RAJNAGAR",
				"BAGHBER",
				"PORAGAON",
				"RUPNARAYANKURA",
				"RAMCHANDRAKURA MANDALIA",
				"WARD NO-08",
				"MARICHPURA",
				"KALASPUR",
				"JOGANIA",
				"NALITABARI",
			}
		},
		{
			"SHERPURSHERPUR SADAR",
			new List<string>
			{
				"BALAIR CHAR",
				"BHATSALA",
				"WARD NO-04",
				"WARD NO-06",
				"WARD NO-07",
				"CHAR SHERPUR",
				"CHAR MUCHARIA",
				"KAMARIA",
				"GHAZIR KHAMAR",
				"KAMARER CHAR",
				"BAJITKHILA",
				"PAKURIA",
				"RAUHA",
				"DHALA",
				"LAKSHMANPUR",
				"BETMARI GHUGHURAKANDI",
				"WARD NO-01",
				"WARD NO-09",
				"CHAR PAKSHIMARI",
			}
		},
		{
			"SHERPURSREEBARDI",
			new List<string>
			{
				"SREEBARDI",
				"GARJARIPA",
				"KURIKAHANIA",
				"RANI SHIMUL",
				"BHELUA",
				"KAKILAKURA",
				"SINGA BARUNA",
				"KHARIA KAZIR CHAR",
				"GOSAIPUR",
				"TANTIHATI",
				"WARD NO-02",
			}
		},
		{
			"BAGERHATBAGERHAT SADAR",
			new List<string>
			{
				"BEMARTA",
				"KARA PARA",
				"GOTA PARA",
				"BARAI PARA",
				"WARD NO-05",
				"SHAT GAMBUJ",
				"WARD NO-03",
				"WARD NO-06",
				"JATRAPUR",
				"BISHNUPUR",
				"RAKHALGACHHI",
				"WARD NO-01",
				"DEMA",
				"KHANPUR",
				"WARD NO-04",
				"WARD NO-08",
			}
		},
		{
			"BAGERHATCHITALMARI",
			new List<string>
			{
				"BARA BARIA",
				"CHITALMARI",
				"HIZLA",
				"CHAR BANIARI",
				"KALATALA",
				"SANTOSHPUR",
				"SHIBPUR",
			}
		},
		{
			"BAGERHATFAKIRHAT",
			new List<string>
			{
				"NALDHA MAUBHOG",
				"BAHIRDIA MANSA",
				"FAKIRHAT",
				"LAKHPUR",
				"MULGHAR",
				"PILJANGA",
				"BETAGA",
				"SUBHADIA",
			}
		},
		{
			"BAGERHATKACHUA",
			new List<string>
			{
				"BITARA",
				"SACHAR",
				"ASHRAFPUR",
				"WARD NO-06",
				"WARD NO-07",
				"DAKSHIN GOHAT",
				"UTTAR GOHAT",
				"KADLA",
				"UTTAR KACHUA",
				"PASCHIM SAHADEBPUR",
				"KARAIA",
				"PURBA SAHADEBPUR",
				"PATHAIR",
				"KACHUAI",
				"KACHUA",
				"BADHAL",
				"RARI PARA",
				"MAGHIA",
				"GOPALPUR",
				"GAZALIA",
				"DHOPAKHALI",
			}
		},
		{
			"BAGERHATMOLLAHAT",
			new List<string>
			{
				"MOLLAHAT",
				"UDAYPUR",
				"CHUNKHOLA",
				"ATJURI",
				"GANGNI",
				"KODALIA",
				"GAOLA",
				"KULIA",
			}
		},
		{
			"BAGERHATMONGLA",
			new List<string>
			{
				"WARD NO-09",
				"MITHAKHALI",
				"WARD NO-07",
				"SUNDARBAN",
				"BURIRDANGA",
				"CHANDPI",
				"CHILA",
				"SUNILTALA",
				"WARD NO-02",
			}
		},
		{
			"BAGERHATMORRELGANJ",
			new List<string>
			{
				"HOGLA PASHA",
				"BAHARBUNIA",
				"JIUDHARA",
				"KHUOLIA",
				"WARD NO-06",
				"WARD NO-07",
				"HOGLABUNIA",
				"WARD NO-01",
				"BANAGRAM",
				"DAIBAGNYAHATI",
				"CHINGRAKHALI",
				"RAMCHANDRAPUR",
				"NISHANBARIA",
				"PANCHAKARAN",
				"BALAIBUNIA",
				"PUTIKHALI",
				"TELIGATI",
				"BARAIKHALI",
			}
		},
		{
			"BAGERHATRAMPAL",
			new List<string>
			{
				"RAMPAL",
				"BAINTALA",
				"PERIKHALI",
				"HURKA",
				"UJALKUR",
				"BANSHTALI",
				"GAURAMBHA",
				"RAJNAGAR",
				"BHOJPATIA",
				"MALLIKER BER",
			}
		},
		{
			"BAGERHATSARANKHOLA",
			new List<string>
			{
				"KHONTAKATA",
				"ROYENDA",
				"DHANSAGAR",
				"DAKHIN KHALI",
			}
		},
		{
			"CHUADANGAALAMDANGA",
			new List<string>
			{
				"KHADIMPUR",
				"JEHALA",
				"WARD NO-02",
				"BARADI",
				"WARD NO-03",
				"HARDI",
				"JAMJAMI",
				"AILHAS",
				"KALIDASHPUR",
				"KHASKARA",
				"GANGNI",
				"WARD NO-05",
				"NAGDAHA",
				"BHANGABARIA",
				"DAUKI",
				"BELGACHHI",
				"CHITLA",
				"KUMARI",
				"WARD NO-08",
			}
		},
		{
			"CHUADANGACHUADANGA SADAR",
			new List<string>
			{
				"TITUDAHA",
				"BEGAMPUR",
				"KUTUBPUR",
				"SHANKAR CHANDRA",
				"WARD NO-07",
				"WARD NO-03",
				"WARD NO-01",
				"MOMINPUR",
				"WARD NO-04",
			}
		},
		{
			"CHUADANGADAMURHUDA",
			new List<string>
			{
				"KAPASADANGA",
				"NATIPOTA",
				"WARD NO-03",
				"DAMURHUDA",
				"WARD NO-07",
				"KURALGACHHI",
				"JURANPUR",
				"HOWLI",
				"PERKRISHNAPUR MADNA",
				"WARD NO-01",
			}
		},
		{
			"CHUADANGAJIBAN NAGAR",
			new List<string>
			{
				"BANKA",
				"SIMANTA",
				"WARD NO-06",
				"WARD NO-07",
				"HASADAH",
				"ANDULBARIA",
				"UTHALI",
				"ROYPUR",
			}
		},
		{
			"JESSOREABHAYNAGAR",
			new List<string>
			{
				"WARD NO-06",
				"WARD NO-08",
				"SIDDHIPASHA",
				"SUNDOLI",
				"PAYRA",
				"CHALISHIA",
				"SREEDHARPUR",
				"SUBHA PARA",
				"WARD NO-09",
				"WARD NO-03",
				"PRAMBAG",
				"WARD NO-01",
				"WARD NO-07",
				"BAGHUTIA",
				"WARD NO-02",
				"WARD NO-05",
			}
		},
		{
			"JESSOREBAGHER PARA",
			new List<string>
			{
				"JAMDIA",
				"DARAJHAT",
				"NARIKELBARIA",
				"DHALGRAM",
				"BANDABILLA",
				"BASUARI",
				"DOHAKULA",
				"ROYPUR",
				"WARD NO-06",
				"JAHARPUR",
			}
		},
		{
			"JESSORECHAUGACHHA",
			new List<string>
			{
				"DHULIANI",
				"SWARUPDAHA",
				"NARAYANPUR",
				"WARD NO-09",
				"HAKIMPUR",
				"PHULSARA",
				"WARD NO-07",
				"SUKPUKHURIA",
				"SINGHAJHULI",
				"PASHAPOLE",
				"JAGADISHPUR",
				"PATIBILA",
				"WARD NO-05",
			}
		},
		{
			"JESSOREJHIKARGACHHA",
			new List<string>
			{
				"NIBASKHOLA",
				"JHIKARGACHHA",
				"MAGURA",
				"WARD NO-06",
				"GANGANANDAPUR",
				"BANKRA UNION",
				"GADKHALI",
				"SHIMULIA",
				"NABHARAN",
				"SHANKARPUR",
				"PANISARA",
				"HAJIRBAGH",
				"WARD NO-08",
			}
		},
		{
			"JESSOREKESHABPUR",
			new List<string>
			{
				"KESHABPUR",
				"MANGALKOT",
				"PANJIA",
				"MAJIDPUR",
				"SUFALAKATI",
				"SAGARDARI",
				"WARD NO-01",
				"TRIMOHINI",
				"GAURIGHONA",
				"BIDYANANDAKATI",
			}
		},
		{
			"JESSOREKOTWALI",
			new List<string>
			{
				"WARD NO-05",
				"CHAR KOWA",
				"WARD NO-14",
				"WARD NO-08",
				"WARD NO-18",
				"WARD NO-09",
				"WARD NO-16",
				"WARD NO-13",
				"WARD NO-20",
				"WARD NO-01",
				"WARD NO-19",
				"WARD NO-11",
				"WARD NO-02",
				"WARD NO-23",
				"WARD NO-25",
				"SHAYESTABAD",
				"JAGUA",
				"CHAR BARIA",
				"TUNGIBARIA",
				"CHANDPURA",
				"WARD NO-04",
				"ROY PASHA KARAPUR",
				"CHAR MONAI",
				"CHANDRA MOHAN",
				"WARD NO-03",
				"KASHIPUR",
				"WARD NO-28",
				"WARD NO-27",
				"WARD NO-15",
				"WARD NO-22",
				"WARD NO-12",
				"WARD NO-21",
				"WARD NO-32",
				"WARD NO-33",
				"WARD NO-31",
				"WARD NO-16 (PART)",
				"WARD NO-35 (71)(PART)",
				"WARD NO-32 (68)(PART)",
				"WARD NO-37 (73)",
				"WARD NO-36 (72)",
				"LEBUTALA",
				"WARD NO-07",
				"NARENDRAPUR",
				"ICHHALI",
				"HAIBATPUR",
				"ARABPUR",
				"FATHEHPUR",
				"UPASAHAR",
				"WARD NO-06",
				"CHURAMANKATI",
				"BASUNDIA",
				"DIARA",
				"KASHIMPUR",
				"CHANCHRA",
				"RAMNAGAR",
				"NOAPARA",
				"KACHUA",
			}
		},
		{
			"JESSOREMANIRAMPUR",
			new List<string>
			{
				"KULTIA",
				"MASWIMNAGAR",
				"MANOHARPUR",
				"DHAKURIA",
				"HARIDASKATI",
				"DURBADANGA",
				"CHALUAHATI",
				"NEHALPUR",
				"KHEDA PARA",
				"JHANPA",
				"SHYAMKUR",
				"HARIHARNAGAR",
				"BHOJGATI",
				"KHANPUR",
				"KASHIMNAGAR",
				"ROHITA",
				"WARD NO-06",
				"MANIRAMPUR",
				"WARD NO-05",
				"WARD NO-02",
				"WARD NO-04",
			}
		},
		{
			"JESSORESHARSHA",
			new List<string>
			{
				"SHARSHADI",
				"BAGACHRA",
				"PUTKHALI",
				"SHARSHA",
				"DIHI",
				"BAHADURPUR",
				"BENAPOLE",
				"ULASHI",
				"NIZAMPUR",
				"KAYBA",
				"GOGA",
			}
		},
		{
			"JHENAIDAHHORINAKUNDA",
			new List<string>
			{
				"JORADAHA",
				"TAHERHUDA",
				"KAPASHATI",
				"RAGHUNATHPUR",
				"CHANDPUR",
				"DAULATPUR",
				"BHAYNA",
				"WARD NO-06",
			}
		},
		{
			"JHENAIDAHJHENAIDAH SADAR",
			new List<string>
			{
				"WARD NO-05",
				"HALIDHANI",
				"PORAHATI",
				"MADHUHATI",
				"WARD NO-07",
				"PADMAKAR",
				"GANNA",
				"SAGANNA",
				"WARD NO-04",
				"WARD NO-08",
				"HARISHANKARPUR",
				"MOHARAJPUR",
				"GHORSHAL",
				"NALDANGA",
				"KUMRABARIA",
				"PAGLAKANAI",
				"FURSANDI",
				"SADHUHATI",
				"WARD NO-03",
				"WARD NO-09",
				"DOGACHHI",
				"KALICHARANPUR",
				"SURAT",
				"WARD NO-06",
			}
		},
		{
			"JHENAIDAHKALIGANJ",
			new List<string>
			{
				"BAKTARPUR",
				"JAMALPUR",
				"MOKTARPUR",
				"WARD NO-05",
				"BAHADURSADI",
				"TUMULIA",
				"WARD NO-03",
				"JANGALIA",
				"WARD NO-06",
				"SUNDARPUR DURGAPUR",
				"TRILOCHANPUR",
				"NIAMATPUR",
				"RAKHALGACHHI",
				"KASHTABHANGA",
				"ROYGRAM",
				"BARA BAZAR",
				"KOLA",
				"JAMAL",
				"SIMLA ROKONPUR",
				"MALIAT",
				"KUSHLIA",
				"BHARA SIMLA",
				"CHAMPAPHUL",
				"NALTA",
				"DHALBARIA",
				"BISHNUPUR",
				"RATANPUR",
				"DAKSHIN SREEPUR",
				"KRISHNANAGAR",
				"MAUTALA",
				"TARALI",
				"MATHURESHPUR",
				"KALIGANJ",
				"TUSHBHANDAR",
				"KAKINA",
				"BHOTEMARI",
				"DALAGRAM",
				"MADATI",
				"CHANDRAPUR",
				"GORAL",
				"CHALBALA",
				"KAJAL DIGHI KALIGANJ",
				"NAGARI",
			}
		},
		{
			"JHENAIDAHKOTCHANDPUR",
			new List<string>
			{
				"KUSHNA",
				"BALUHAR",
				"SABDALPUR",
				"WARD NO-09",
				"WARD NO-02",
				"WARD NO-04",
				"DORA",
				"ELANGI",
			}
		},
		{
			"JHENAIDAHMAHESHPUR",
			new List<string>
			{
				"MAHESHPUR",
				"S.K.B.",
				"KAZIRBER",
				"SWARUPPUR",
				"FATEHPUR",
				"NEPA",
				"WARD NO-06",
				"JADABPUR",
				"MANDERBARI",
				"SHYAMKUR",
				"PANTHA PARA",
				"BANSHBARIA",
				"WARD NO-02",
				"NATIMA",
				"AZAMPUR",
			}
		},
		{
			"JHENAIDAHSHAILKUPA",
			new List<string>
			{
				"ABAIPUR",
				"SARUTIA",
				"DIGNAGAR",
				"HAKIMPUR",
				"FULHARI",
				"UMEDPUR",
				"WARD NO-02",
				"KANCHERKOL",
				"DUDHSAR",
				"TRIBENI",
				"BAGURA",
				"DHALHARA CHANDRA",
				"NITYANANDAPUR",
				"MANOHARPUR",
				"MIRZAPUR",
				"WARD NO-08",
			}
		},
		{
			"KHULNABATIAGHATA",
			new List<string>
			{
				"BATIAGHATA",
				"GANGARAMPUR",
				"JALMA",
				"BHANDERKOTE",
				"SURKHALI",
				"BALIADANGA",
			}
		},
		{
			"KHULNADACOPE",
			new List<string>
			{
				"SUTARKHALI",
				"BAJUA",
				"BANISHANTA",
				"DACOPE",
				"KAMARKHOLA",
				"TILDANGA",
				"KAILASGANJ",
				"PANKHALI",
				"WARD NO-02",
				"LAUDUBI",
				"WARD NO-09",
				"WARD NO-03",
			}
		},
		{
			"KHULNADAULATPUR",
			new List<string>
			{
				"DAULATPUR",
				"DAULATPUR (PURBA PANCHGACHHIA)",
				"CHAK MIRPUR",
				"KALIA",
				"BACHAMARA",
				"BAGHUTIA",
				"CHARKATARI",
				"DHAMSAR",
				"KHALSI",
				"JIYANPUR",
				"WARD NO-06",
				"WARD NO-05",
				"WARD NO-01",
				"WARD NO-03",
				"WARD NO-02 (PART)",
				"WARD NO-04",
				"ARANGHATA",
				"MATHURAPUR",
				"REFAYETPUR",
				"KHALISHAKUNDI",
				"CHILMARI",
				"PRAYAGPUR",
				"PHILIPNAGAR",
				"ARIA",
				"PEARPUR",
				"HOGALBARIA",
				"RAMKRISHNAPUR",
				"MARICHA",
				"BOALIA",
				"ADABARIA",
				"ROY DAULATPUR",
			}
		},
		{
			"KHULNAKHAN JAHAN ALI",
			new List<string>
			{
				"WARD NO-02 (PART)",
				"JUGIPOLE",
				"ATRA GILATALA",
			}
		},
		{
			"KHULNADUMURIA",
			new List<string>
			{
				"DUMURIA",
				"MAGURAGHONA",
				"RANGPUR",
				"SOBHANA",
				"ATLIA UNION",
				"GUTUDIA",
				"RUDAGHARA",
				"RAGHUNATHPUR",
				"MAGURKHALI",
				"SAHAS",
				"DHAMALIA",
				"KHARNIA",
				"SARAPPUR",
				"BHANDAR PARA",
			}
		},
		{
			"KHULNADIGHALIA",
			new List<string>
			{
				"CHANDRA DIGHALIA",
				"DIGHALIA",
				"SENHATI",
				"GAZIR HAT",
				"BARAKPUR",
			}
		},
		{
			"KHULNAKHALISHPUR",
			new List<string>
			{
				"WARD NO-13",
				"WARD NO-10",
				"WARD NO-15(PART)",
				"WARD NO-12",
				"WARD NO-14",
				"WARD NO-09",
			}
		},
		{
			"KHULNAPHULTALA",
			new List<string>
			{
				"ATRA GILATALA",
				"PHULTALA",
				"DAMODAR",
				"JAMIRA",
			}
		},
		{
			"KHULNAKHULNA SADAR",
			new List<string>
			{
				"WARD NO-21",
				"WARD NO-24",
				"WARD NO-27",
				"WARD NO-30",
				"WARD NO-22",
				"WARD NO-23",
				"WARD NO-28",
				"WARD NO-29",
				"WARD NO-31",
			}
		},
		{
			"KHULNAKOYRA",
			new List<string>
			{
				"MAHESHWARIPUR",
				"MAHARAJPUR",
				"KOYRA",
				"UTTAR BEDKASHI",
				"BAGALI",
				"DAKSHIN BEDKASHI",
				"AMADI",
			}
		},
		{
			"KHULNAPAIKGACHHA",
			new List<string>
			{
				"KAPILMUNI",
				"CHANDKHALI",
				"RARULI",
				"GADAIPUR",
				"HARIDHALI",
				"GARUIKHALI",
				"SHOLADANA",
				"DELUTI",
				"LATA",
				"LASKAR",
				"WARD NO-04",
			}
		},
		{
			"KHULNARUPSA",
			new List<string>
			{
				"DAKSHIN RUPSA",
				"UTTAR RUPSA",
				"GHATBHOGH",
				"NAIHATI",
				"AIJGANTI",
				"SREEFALTALA",
				"T. S. BAHIRDIA",
			}
		},
		{
			"KHULNASONADANGA",
			new List<string>
			{
				"WARD NO-16",
				"WARD NO-20",
				"WARD NO-19",
				"WARD NO-17",
				"WARD NO-25",
				"WARD NO-18",
				"WARD NO-26",
				"SONADANGA",
			}
		},
		{
			"KHULNATEROKHADA",
			new List<string>
			{
				"MADHUPUR",
				"BARASAT",
				"SACHIADAH",
				"AJUGARA",
				"SAGLADAH",
				"TEROKHADA",
			}
		},
		{
			"KUSHTIABHERAMARA",
			new List<string>
			{
				"WARD NO-05",
				"DHARAMPUR",
				"JUNIADAHA",
				"BAHADURPUR",
				"WARD NO-07",
				"BAHIR CHAR",
				"MOKARIMPUR",
				"CHANDGRAM",
				"WARD NO-06",
				"WARD NO-02",
			}
		},
		{
			"KUSHTIADAULATPUR",
			new List<string>
			{
				"DAULATPUR",
				"DAULATPUR (PURBA PANCHGACHHIA)",
				"CHAK MIRPUR",
				"KALIA",
				"BACHAMARA",
				"BAGHUTIA",
				"CHARKATARI",
				"DHAMSAR",
				"KHALSI",
				"JIYANPUR",
				"WARD NO-06",
				"WARD NO-05",
				"WARD NO-01",
				"WARD NO-03",
				"WARD NO-02 (PART)",
				"WARD NO-04",
				"ARANGHATA",
				"MATHURAPUR",
				"REFAYETPUR",
				"KHALISHAKUNDI",
				"CHILMARI",
				"PRAYAGPUR",
				"PHILIPNAGAR",
				"ARIA",
				"PEARPUR",
				"HOGALBARIA",
				"RAMKRISHNAPUR",
				"MARICHA",
				"BOALIA",
				"ADABARIA",
				"ROY DAULATPUR",
			}
		},
		{
			"KUSHTIAKHOKSA",
			new List<string>
			{
				"SAMASPUR",
				"WARD NO-07",
				"WARD NO-05",
				"AMBARIA",
				"JANIPUR",
				"OSMANPUR",
				"JAYANTI HAJRA",
				"BETBARIA",
				"SHIMULIA",
				"GOPAGRAM",
				"KHOKSA",
				"KHOKSABARI",
			}
		},
		{
			"KUSHTIAKUMARKHALI",
			new List<string>
			{
				"WARD NO-07",
				"WARD NO-03",
				"SADIPUR",
				"BAGULAT",
				"NANDALALPUR",
				"JADU BOYRA",
				"WARD NO-04",
				"JAGANNATHPUR",
				"SHELAIDAHA",
				"KAYA",
				"PANTI",
				"CHANDPUR",
				"SADAKI",
				"CHAPRA",
			}
		},
		{
			"KUSHTIAKUSHTIA SADAR",
			new List<string>
			{
				"WARD NO-05",
				"JAGATI",
				"ABDULPUR",
				"MANOHARDIA",
				"WARD NO-11",
				"WARD NO-04",
				"WARD NO-06",
				"BARAKHADA",
				"WARD NO-02",
				"WARD NO-08",
				"HARINARAYANPUR",
				"JIARAKHI",
				"JHAUDIA",
				"PAITKABARI",
				"UJANGRAM",
				"AILCHARA",
				"ALAMPUR",
				"HATAS HARIPUR",
				"GOSIND DURGAPUR",
				"MAZAMPUR",
				"WARD NO-01",
			}
		},
		{
			"KUSHTIAMIRPUR",
			new List<string>
			{
				"WARD NO-11",
				"WARD NO-13",
				"WARD NO-07 (PART)",
				"CHAK MIRPUR",
				"AMLA",
				"BAHALBARIA",
				"AMBARIA",
				"CHHATIAN",
				"WARD NO-02",
				"WARD NO-03",
				"FULBARIA",
				"KURSHA",
				"PORADAHA",
				"SARDARPUR",
				"CHITHULIA",
				"TALBARIA",
				"BARUI PARA",
				"MALIHAD",
				"MIRPUR",
			}
		},
		{
			"MAGURAMAGURA SADAR",
			new List<string>
			{
				"WARD NO-07",
				"WARD NO-09",
				"HAZRAPUR",
				"ATHARAKHADA",
				"BIRAIL PALITA",
				"HAZIPUR",
				"BAGIA",
				"KASUNDI",
				"KUCHIAMORA",
				"JAGDAL",
				"MAGHI",
				"GOPALGRAM",
				"WARD NO-06",
				"CHAULIA",
				"WARD NO-01",
				"SATRUJITPUR",
				"RAGHAB DAIR",
				"WARD NO-02",
				"WARD NO-04",
			}
		},
		{
			"MAGURAMOHAMMADPUR",
			new List<string>
			{
				"MOHAMMADPUR PURBA",
				"MOHAMMADPUR",
				"WARD NO-32 (45)",
				"WARD NO-31 (44)",
				"WARD NO-29 (42)",
				"WARD NO-34 (PART) (47)",
				"BINODEPUR",
				"NAHATA",
				"BABUKHALI",
				"RAJAPUR",
				"BALIDIA",
				"DIGHA",
				"PALASHBARIA",
			}
		},
		{
			"MAGURASHALIKHA",
			new List<string>
			{
				"TALKHARI",
				"GANGARAMPUR",
				"ARPARA",
				"BUNAGATI",
				"SHATAKHALI",
				"SHALIKHA",
				"DHANESHWARGATI",
			}
		},
		{
			"MAGURASREEPUR",
			new List<string>
			{
				"SREEPUR KHARANDWIP",
				"SREEPUR",
				"MAONA",
				"WARD NO-05",
				"PRAHLADPUR",
				"GOSINGA",
				"GAZIPUR",
				"RAJABARI",
				"BARMI",
				"WARD NO-08",
				"WARD NO-02",
				"KAORAID",
				"WARD NO-04",
				"TELIHATI",
				"NAKOL",
				"SREEKOL",
				"GAYESHPUR",
				"SABDALPUR",
				"KADIR PARA",
				"AMALSAR",
				"DARIAPUR",
				"DAKSHIN SREEPUR",
				"UTTAR SREEPUR",
			}
		},
		{
			"MEHERPURGANGNI",
			new List<string>
			{
				"GANGNI",
				"ROYPUR",
				"SHOLA TAKA",
				"TENTULBARIA",
				"MATMURA",
				"KAZIPUR",
				"SHAHARBATI",
				"BAMANDI",
				"KATHULI",
				"DHANKHOLA",
				"WARD NO-01",
			}
		},
		{
			"MEHERPURMUJIB NAGAR",
			new List<string>
			{
				"BAGOAN",
				"DARIAPUR",
				"MAHAJANPUR",
				"MONAKHALI",
			}
		},
		{
			"MEHERPURMEHERPUR SADAR",
			new List<string>
			{
				"PIROJPUR",
				"AMJHUPI",
				"BURIPOTA",
				"KUTUBPUR",
				"WARD NO-07",
				"AMDA",
			}
		},
		{
			"NORAILKALIA",
			new List<string>
			{
				"WARD NO-19",
				"WARD NO-17",
				"WARD NO-18",
				"KALIAIS",
				"FULBARIA",
				"BOALI",
				"DHALJORA",
				"SREEFALTALI",
				"CHAPAIR",
				"WARD NO-01",
				"MOUCHAK",
				"ATABAHA",
				"MADHYAPARA",
				"WARD NO-09",
				"SUTRAPUR",
				"KALIA",
				"KALIARA GABRAGAT",
				"SALAMABAD",
				"KALABARIA",
				"PURULIA",
				"WARD NO-07",
				"WARD NO-03",
				"WARD NO-02",
				"KHASIAL",
				"BAUISENA",
				"PAHARDANGA",
				"PERULI",
				"MAULI",
				"JOYNAGAR",
				"CHANCHARI",
				"HATURIA NAKALIA",
				"KALIA HARIPUR",
				"KALKALIA",
				"HAMIDPUR",
			}
		},
		{
			"NORAILLOHAGARA",
			new List<string>
			{
				"KALAUZAN",
				"PADUA",
				"AMIRABAD",
				"CHUNATI",
				"ADHUNAGAR",
				"PUTIBILA",
				"CHARAMBA",
				"LOHAGARA",
				"BARAHATIA",
				"JOYPUR",
				"DIGHALIA",
				"NALDI",
				"ITNA",
				"NOAGRAM",
				"LAHURIA",
				"LAKSHMIPASHA",
				"KASHIPUR",
				"KOTAKUL",
				"WARD NO-07",
				"SHALNAGAR",
				"MALLIKPUR",
				"WARD NO-03",
				"WARD NO-02",
				"WARD NO-01",
			}
		},
		{
			"NORAILNARAIL SADAR",
			new List<string>
			{
				"BICHHALI",
				"TULARAMPUR",
				"SAHABAD",
				"BHADRABILA",
				"HABAKHALI",
				"WARD NO-03",
				"KALORA",
				"WARD NO-02",
				"WARD NO-06",
				"SHAIKHATI",
				"SINGASOLPUR",
				"MAIJ PARA",
				"BANSHGRAM",
				"AURIA",
				"CHANDIBARPUR",
				"WARD NO-08",
				"MULIA",
			}
		},
		{
			"SATKHIRAASSASUNI",
			new List<string>
			{
				"ASSASUNI",
				"SREEULA",
				"KADAKATI",
				"PRATAP NAGAR",
				"KHAJRA",
				"BARADAL",
				"SOBHNALI",
				"DURGAPUR",
				"ANULIA",
				"KULLA",
				"BUDHHATA",
			}
		},
		{
			"SATKHIRADEBHATA",
			new List<string>
			{
				"DEBHATA",
				"KULIA",
				"PARULIA",
				"NOAPARA",
				"SAKHIPUR",
			}
		},
		{
			"SATKHIRAKALAROA",
			new List<string>
			{
				"SONABARIA",
				"KERALKATA",
				"HELATALA",
				"WARD NO-08",
				"JOYNAGAR",
				"KERAGACHHI",
				"WARD NO-03",
				"DIARA",
				"WARD NO-09",
				"CHANDANPUR",
				"JOGIKHALI",
				"WARD NO-04",
				"KUSHADANGA",
				"KAILA",
				"JALLABAD",
				"WARD NO-01",
				"LANGALJHARA",
			}
		},
		{
			"SATKHIRAKALIGANJ",
			new List<string>
			{
				"BAKTARPUR",
				"JAMALPUR",
				"MOKTARPUR",
				"WARD NO-05",
				"BAHADURSADI",
				"TUMULIA",
				"WARD NO-03",
				"JANGALIA",
				"WARD NO-06",
				"SUNDARPUR DURGAPUR",
				"TRILOCHANPUR",
				"NIAMATPUR",
				"RAKHALGACHHI",
				"KASHTABHANGA",
				"ROYGRAM",
				"BARA BAZAR",
				"KOLA",
				"JAMAL",
				"SIMLA ROKONPUR",
				"MALIAT",
				"KUSHLIA",
				"BHARA SIMLA",
				"CHAMPAPHUL",
				"NALTA",
				"DHALBARIA",
				"BISHNUPUR",
				"RATANPUR",
				"DAKSHIN SREEPUR",
				"KRISHNANAGAR",
				"MAUTALA",
				"TARALI",
				"MATHURESHPUR",
				"KALIGANJ",
				"TUSHBHANDAR",
				"KAKINA",
				"BHOTEMARI",
				"DALAGRAM",
				"MADATI",
				"CHANDRAPUR",
				"GORAL",
				"CHALBALA",
				"KAJAL DIGHI KALIGANJ",
				"NAGARI",
			}
		},
		{
			"SATKHIRASATKHIRA SADAR",
			new List<string>
			{
				"WARD NO-03",
				"LABSA",
				"WARD NO-05",
				"WARD NO-01",
				"WARD NO-02",
				"JHAUDANGA",
				"WARD NO-09",
				"AGARDARI",
				"BHOMRA",
				"GHONA",
				"ALIPUR",
				"FINGRI",
				"BRAHMA RAJPUR",
				"BALLI",
				"BAIKARI",
				"WARD NO-06",
				"DHULIHAR",
				"BANSHDAHA",
				"WARD NO-08",
				"SHIBPUR",
				"WARD NO-04",
				"KUSKHALI",
			}
		},
		{
			"SATKHIRASHYAMNAGAR",
			new List<string>
			{
				"BURI GOALINI",
				"SHYAMNAGAR",
				"GABURA",
				"MUNSHIGANJ",
				"PADMA PUKUR",
				"RAMJAN NAGAR",
				"NURNAGAR",
				"ATULIA",
				"ISHWARIPUR",
				"KAIKHALI",
				"KASHIMARI",
			}
		},
		{
			"SATKHIRATALA",
			new List<string>
			{
				"DAUATALA",
				"KADAMTALA UNION",
				"SARIKTALA DUMRITALA",
				"KAITALA DAKSHIN",
				"KAITALA UTTAR",
				"CHAPARTALA",
				"CHAPITALA",
				"ARJUNTALA",
				"GUNARITALA",
				"JARAITALA",
				"BAHERATALA UTTAR",
				"BAHERATALA DAKSHIN",
				"GUATALA",
				"GAMARITALA",
				"LEBUTALA",
				"AMTALA",
				"KALATALA",
				"SUNILTALA",
				"BAINTALA",
				"ATRA GILATALA",
				"PHULTALA",
				"DAMODAR",
				"JAMIRA",
				"SREEFALTALA",
				"HELATALA",
				"MAUTALA",
				"KHESRA",
				"DHANDIA",
				"MAGURA",
				"TENTULIA",
				"TALA",
				"KUMIRA",
				"KHALISHKHALI",
				"ISLAMKATI",
				"JALALPUR",
				"KHALILNAGAR",
				"SARULIA",
				"NAGARGHATA",
				"MOKAMTALA",
				"KUPTALA",
				"MATINDHAR",
				"PATNITALA",
				"WARD NO-09",
				"GHOSHNAGAR",
				"SHIHARA",
				"PATICHARA",
				"NIRMAIL",
				"AKBARPUR",
				"KRISHNAPUR",
				"AMAIR",
				"DIBAR",
				"WARD NO-05",
				"NAZIPUR",
				"GOBRATALA",
				"TALANDA",
				"TALAM",
				"DHANTALA",
				"FULTALA",
			}
		},
		{
			"BOGRAADAMDIGHI",
			new List<string>
			{
				"WARD NO-04",
				"WARD NO-01",
				"NASRATPUR",
				"WARD NO-06",
				"CHAMPAPUR",
				"CHHATIANGRAM",
				"SHANTAHAR",
				"KUNDAGRAM",
				"ADAM DIGHI",
			}
		},
		{
			"BOGRABOGRA SADAR",
			new List<string>
			{
				"FAPORE",
				"WARD NO-15",
				"WARD NO-19",
				"WARD NO-09",
				"WARD NO-02",
				"WARD NO-05",
				"WARD NO-12",
				"WARD NO-17",
				"WARD NO-03",
				"NISHINDARA",
				"WARD NO-04",
				"WARD NO-11",
				"WARD NO-07",
				"WARD NO-06",
				"WARD NO-20",
				"WARD NO-08",
				"NAMUJA",
				"GOKUL",
				"LAHIRI PARA",
				"ERULIA",
				"WARD NO-21 (PART)",
				"SHAKHARIA",
				"SEKHERKOLA",
				"WARD NO-14",
				"NOONGOLA",
			}
		},
		{
			"BOGRASHAJAHANPUR",
			new List<string>
			{
				"CHOPINAGAR",
				"MAJHIRA",
				"WARD NO-13",
				"MADLA",
				"AMROOL",
				"GOHAIL",
				"ASEKPUR",
				"ARIA BAZAR",
				"KHOTTA PARA",
				"KHARNA",
				"WARD NO-21 (PART) BOGRA PSA",
			}
		},
		{
			"BOGRADHUNAT",
			new List<string>
			{
				"GOSAINBARI",
				"WARD NO-04",
				"MATHURAPUR",
				"KALER PARA",
				"ELANGI",
				"BHANDARBARI",
				"GOPALNAGAR",
				"CHIKASHI",
				"NIMGACHHI",
				"CHAUKIBARI",
				"DHUNAT",
			}
		},
		{
			"BOGRADHUPCHANCHIA",
			new List<string>
			{
				"TALORA UNION",
				"DHUPCHANCHIA",
				"WARD NO-08",
				"GUNAHAR",
				"GOBINDAPUR",
				"ZIANAGAR",
				"CHAMRUL UNION",
			}
		},
		{
			"BOGRAGABTALI",
			new List<string>
			{
				"GABTALI",
				"DURGAHATA",
				"NASIPUR",
				"MAHISHABAN",
				"NARUAMALA",
				"SONARAI",
				"WARD NO-02",
				"KAGAIL",
				"DAKSHINPARA",
				"BALIA DIGHI",
				"NEPALTALI",
				"WARD NO-03",
				"RAMESHWARPUR",
			}
		},
		{
			"BOGRAKAHALOO",
			new List<string>
			{
				"KAHALOO",
				"WARD NO-06",
				"NARAHATTA",
				"MALANCHA",
				"JAMGAON",
				"KALAI MAJH PARA",
				"PAIKAR",
				"BIR KEDAR",
				"DURGAPUR",
				"MURAIL",
				"WARD NO-02",
			}
		},
		{
			"BOGRANANDIGRAM",
			new List<string>
			{
				"WARD NO-09",
				"BHATRA",
				"BHATGRAM",
				"NANDIGRAM",
				"THALTA MAJHGRAM",
				"BURAIL",
			}
		},
		{
			"BOGRASARIAKANDI",
			new List<string>
			{
				"KAZLA",
				"KARNIBARI",
				"WARD NO-06",
				"WARD NO-05",
				"KUTUBPUR",
				"BHELABARI",
				"HAT SHERPUR",
				"BOHAIL",
				"KAMALPUR",
				"CHANDAN BAISHA",
				"FULBARI UNION",
				"NARCHI",
				"CHALUABARI",
			}
		},
		{
			"BOGRASONATOLA",
			new List<string>
			{
				"PAKULLA",
				"DIGDAIR",
				"MADHUPUR",
				"JORGACHHA",
				"BALUA",
				"TEKANI CHUKAINA",
				"WARD NO-06",
			}
		},
		{
			"BOGRASHERPUR",
			new List<string>
			{
				"SHERPUR",
				"BALAIR CHAR",
				"BHATSALA",
				"WARD NO-04",
				"WARD NO-06",
				"WARD NO-07",
				"CHAR SHERPUR",
				"CHAR MUCHARIA",
				"KAMARIA",
				"GHAZIR KHAMAR",
				"KAMARER CHAR",
				"BAJITKHILA",
				"PAKURIA",
				"RAUHA",
				"DHALA",
				"LAKSHMANPUR",
				"BETMARI GHUGHURAKANDI",
				"WARD NO-01",
				"WARD NO-09",
				"CHAR PAKSHIMARI",
				"HAT SHERPUR",
				"BISHALPUR",
				"BHABANIPUR",
				"SHIMABARI",
				"SUGHAT",
				"KUSUMBI",
				"KHANPUR",
				"GARIDAHA",
				"WARD NO-05",
				"SHAH-BANDEGI",
				"MIRZAPUR",
				"KHAMARKANDI",
			}
		},
		{
			"BOGRASHIBGANJ",
			new List<string>
			{
				"MAJHIHATTA",
				"BURIGANJ",
				"DEULI",
				"SHIBGANJ",
				"BIHAR",
				"MAIDANHATA",
				"PIRAB",
				"KICHAK",
				"MOKAMTALA",
				"ATMUL",
				"SAIDPUR",
				"ROYNAGAR",
				"WARD NO-07",
				"WARD NO-06",
				"SATRUJITPUR",
				"DHAINAGAR",
				"UZIRPUR",
				"MOBARAKPUR",
				"SHAHBAJPUR",
				"WARD NO-02",
				"MANAKOSA",
				"WARD NO-05",
				"DURLABHPUR",
				"KANSAT",
				"CHAK KIRTI",
				"SHYAMPUR",
				"NAYA NAOBHANGA",
				"PANKA",
				"BINODPUR",
				"GHORAPAKHIA",
				"DAIPUKURIA",
				"WARD NO-08",
				"WARD NO-09",
			}
		},
		{
			"JOYPURHATAKKELPUR",
			new List<string>
			{
				"RUKINDIPUR",
				"TILAKPUR",
				"WARD NO-04",
				"WARD NO-09",
				"RAIKALI",
				"WARD NO-03",
				"GOPINATHPUR",
				"SONAMUKHI",
			}
		},
		{
			"JOYPURHATJOYPURHAT SADAR",
			new List<string>
			{
				"WARD NO-02",
				"BAMBU",
				"WARD NO-06",
				"WARD NO-01",
				"MOHAMMADABAD",
				"DHALAHAR",
				"AMDAI",
				"WARD NO-04",
				"JAMALPUR",
				"CHAK BARKAT",
				"DOGACHHI",
				"WARD NO-09",
				"PURANAPAIL",
				"BHADSA",
				"WARD NO-07",
			}
		},
		{
			"JOYPURHATKALAI",
			new List<string>
			{
				"KALAIYA",
				"KALAI MAJH PARA",
				"WARD NO-01",
				"UDAYPUR",
				"MATRAI",
				"PUNAT",
				"ZINDARPUR",
				"AHMMEDABAD",
				"WARD NO-04",
			}
		},
		{
			"JOYPURHATKHETLAL",
			new List<string>
			{
				"WARD NO-04",
				"ALAMPUR",
				"MAMUDPUR",
				"BARATARA",
				"WARD NO-05",
				"KHETLAL",
				"BARAIL",
			}
		},
		{
			"JOYPURHATPANCHBIBI",
			new List<string>
			{
				"AOLAI",
				"ATAPUR",
				"DHARANJI",
				"WARD NO-06",
				"KUSUMBA",
				"AYMARASULPUR",
				"BALIGHATA",
				"MOHAMADPUR",
				"BAGJANA",
				"WARD NO-02",
				"WARD NO-08",
			}
		},
		{
			"NAOGAONATRAI",
			new List<string>
			{
				"MATRAI",
				"AHSANGANJ",
				"SAHAGOLA",
				"PANCHUPUR",
				"HATKALU PARA",
				"BISHA",
				"KALIKAPUR",
				"MANIARI",
				"BHOPARA",
			}
		},
		{
			"NAOGAONBADALGACHHI",
			new List<string>
			{
				"BADALGACHHI",
				"BALUBHARA",
				"PAHAR PUR",
				"MATHURAPUR",
				"BILASBARI",
				"KOLA",
				"ADHAIPUR",
				"MITHAPUR",
			}
		},
		{
			"NAOGAONDHAMOIRHAT",
			new List<string>
			{
				"JAHANPUR",
				"ARANAGAR",
				"WARD NO-02",
				"AGRA DIGUN",
				"KHELNA",
				"ISABPUR",
				"DHAMOIRHAT",
				"ALAMPUR",
				"OMAR",
				"WARD NO-05",
			}
		},
		{
			"NAOGAONMANDA",
			new List<string>
			{
				"DHAR MANDAL",
				"MANDARI",
				"MEDINI MANDAL",
				"CHAR MANDALIA",
				"RAMCHANDRAKURA MANDALIA",
				"BAMANDANGA",
				"PRASADPUR",
				"PARANPUR",
				"BHALAIN",
				"KUSUMBA",
				"MANDA",
				"NURULLABAD",
				"TENTULIA",
				"KALIKAPUR",
				"BISHNUPUR",
				"BHARSO",
				"GANESHPUR",
				"KASHAB",
				"MAINANI",
				"KANSO PARA",
			}
		},
		{
			"NAOGAONMAHADEBPUR",
			new List<string>
			{
				"SAFAPUR",
				"MAHADEBPUR",
				"CHANDAS",
				"CHERAGPUR",
				"ROYGAON",
				"HATUR",
				"BHIMPUR",
				"KHAJUR",
				"UTTARGRAM",
				"ENAYETPUR",
			}
		},
		{
			"NAOGAONNAOGAON SADAR",
			new List<string>
			{
				"WARD NO-02",
				"WARD NO-05",
				"CHANDIPUR",
				"WARD NO-03",
				"WARD NO-01",
				"DUBALHATI",
				"BAKTIARPUR",
				"BARSHAIL",
				"KIRTIPUR",
				"TILAKPUR",
				"SAILGACHHI",
				"HAPANIA",
				"WARD NO-06",
				"WARD NO-08",
				"SEKHERPUR",
				"HASHAIGHARI",
				"WARD NO-07",
				"BOALIA",
				"BALIHAR",
				"WARD NO-09",
			}
		},
		{
			"NAOGAONNIAMATPUR",
			new List<string>
			{
				"NIAMATPUR",
				"RASULPUR",
				"SREEMANTAPUR",
				"PARAIL",
				"BAHADURPUR",
				"HAJINAGAR",
				"BHABICHA",
				"CHANDAN NAGAR",
			}
		},
		{
			"NAOGAONPATNITALA",
			new List<string>
			{
				"MATINDHAR",
				"PATNITALA",
				"WARD NO-09",
				"GHOSHNAGAR",
				"SHIHARA",
				"PATICHARA",
				"NIRMAIL",
				"AKBARPUR",
				"KRISHNAPUR",
				"AMAIR",
				"DIBAR",
				"WARD NO-05",
				"NAZIPUR",
			}
		},
		{
			"NAOGAONPORSHA",
			new List<string>
			{
				"TENTULIA",
				"GANGURIA",
				"GHATNAGAR",
				"CHHAOR",
				"MASIDPUR",
				"NITHPUR",
			}
		},
		{
			"NAOGAONRANINAGAR",
			new List<string>
			{
				"KALIGRAM",
				"PARAIL",
				"RANINAGAR",
				"BARGACHHA",
				"GONA",
				"MIRAT",
				"EKDALA",
				"KASHIMPUR",
			}
		},
		{
			"NAOGAONSAPAHAR",
			new List<string>
			{
				"SAPAHAR",
				"GOALA",
				"TILNA",
				"AIHAI",
				"SHIRANTI",
				"PATHARI",
			}
		},
		{
			"NATOREBAGATIPARA",
			new List<string>
			{
				"DAYARAMPUR",
				"JAMNAGAR",
				"PANKA",
				"BAGATIPARA",
				"FHAGURADIAR",
				"WARD NO-08",
				"WARD NO-06",
			}
		},
		{
			"NATOREBARAIGRAM",
			new List<string>
			{
				"GOPALPUR",
				"MAJGAON",
				"BARAIGRAM",
				"JONAIL",
				"CHANDI",
				"JOARI",
				"WARD NO-03",
				"NAGAR",
				"WARD NO-08",
				"WARD NO-02",
			}
		},
		{
			"NATOREGURUDASPUR",
			new List<string>
			{
				"CHAPILA",
				"MOSHINDA",
				"BIAGHAT",
				"WARD NO-01",
				"NAZIRPUR",
				"KHUBJIPUR",
				"DHARABARISHA",
				"WARD NO-07",
			}
		},
		{
			"NATORELALPUR",
			new List<string>
			{
				"LALPUR",
				"DULALPUR",
				"DILALPUR",
				"JALALPUR",
				"NANDALALPUR",
				"ARBAB",
				"WALIA",
				"KADAM CHILAN",
				"CHANGDHUPAIL",
				"DURDURIA",
				"BILMARIA",
				"DUARIA",
				"WARD NO-01",
				"ARJUNPUR BOROMHATI",
				"WARD NO-05",
				"ISHWARDI",
				"WARD NO-02",
			}
		},
		{
			"NATORENALDANGA",
			new List<string>
			{
				"NALDANGA",
				"MADHNAGAR",
				"BRAHMAPUR",
				"BIPRA BELGHARIA",
				"WARD NO-04",
				"KHAJURIA",
				"PIPRUL",
				"WARD NO-08",
			}
		},
		{
			"NATORENATORE SADAR",
			new List<string>
			{
				"HALSA",
				"BARA HARISHPUR",
				"DIGHAPATIA",
				"WARD NO-01",
				"TEBARIA",
				"WARD NO-09",
				"WARD NO-02",
				"KAFURIA",
				"CHHATNI",
				"LAKSHMIPUR KHOLABA",
				"WARD NO-07",
			}
		},
		{
			"NATORESINGRA",
			new List<string>
			{
				"SINGRAIL",
				"SINGRA",
				"SHERKUL",
				"ITALY",
				"CHAMARI",
				"KALAM",
				"CHHATAR DIGHI",
				"RAMANANDA KHAJURA",
				"SUKASH",
				"LALORE",
				"TAJPUR",
				"CHAUGRAM",
				"WARD NO-07",
				"DAHIA",
				"HATIANDAHA",
				"WARD NO-04",
				"WARD NO-11",
			}
		},
		{
			"NAWABGANJBHOLAHAT",
			new List<string>
			{
				"GOHALBARI",
				"BHOLAHAT",
				"DALDALI",
				"JAMBARIA",
			}
		},
		{
			"NAWABGANJGOMASTAPUR",
			new List<string>
			{
				"GOMASTAPUR",
				"WARD NO-03",
				"PARBATIPUR",
				"RADHANAGAR",
				"CHOWDALA",
				"BOALIA",
				"WARD NO-07",
				"WARD NO-09",
				"BHANGABARIA",
				"ROHANPUR",
				"ALINAGAR",
				"WARD NO-06",
				"WARD NO-08",
			}
		},
		{
			"NAWABGANJNACHOLE",
			new List<string>
			{
				"FATEHPUR",
				"WARD NO-07",
				"KASBA UNION",
				"NACHOLE",
				"NIZAMPUR",
				"WARD NO-03",
			}
		},
		{
			"NAWABGANJCHAPAI NABABGANJ SADAR",
			new List<string>
			{
				"GOBRATALA",
				"RANIHATI",
				"BALIDANGA",
				"WARD NO-02",
				"WARD NO-13",
				"WARD NO-15",
				"WARD NO-01",
				"WARD NO-04",
				"WARD NO-10",
				"WARD NO-08",
				"WARD NO-06",
				"WARD NO-05",
				"BARAGHARIA",
				"WARD NO-14",
				"DEBINAGAR",
				"ISLAMPUR",
				"SUNDARPUR",
				"MAHARAJPUR",
				"CHAR ANUPNAGAR",
				"JHILIM",
				"SHAHJAHANPUR",
				"ALATULI",
				"CHAR BAGDANGA",
				"NARAYANPUR",
				"WARD NO-03",
				"WARD NO-09",
				"WARD NO-07",
				"WARD NO-12",
			}
		},
		{
			"NAWABGANJSHIBGANJ",
			new List<string>
			{
				"MAJHIHATTA",
				"BURIGANJ",
				"DEULI",
				"SHIBGANJ",
				"BIHAR",
				"MAIDANHATA",
				"PIRAB",
				"KICHAK",
				"MOKAMTALA",
				"ATMUL",
				"SAIDPUR",
				"ROYNAGAR",
				"WARD NO-07",
				"WARD NO-06",
				"SATRUJITPUR",
				"DHAINAGAR",
				"UZIRPUR",
				"MOBARAKPUR",
				"SHAHBAJPUR",
				"WARD NO-02",
				"MANAKOSA",
				"WARD NO-05",
				"DURLABHPUR",
				"KANSAT",
				"CHAK KIRTI",
				"SHYAMPUR",
				"NAYA NAOBHANGA",
				"PANKA",
				"BINODPUR",
				"GHORAPAKHIA",
				"DAIPUKURIA",
				"WARD NO-08",
				"WARD NO-09",
			}
		},
		{
			"PABNAATGHARIA",
			new List<string>
			{
				"WARD NO-04",
				"EKDANTA",
				"MAJH PARA",
				"WARD NO-08",
				"LAKSHMIPUR",
				"DEBOTTAR",
				"CHANDBA",
				"WARD NO-01",
			}
		},
		{
			"PABNABERA",
			new List<string>
			{
				"BERAID",
				"KAOLIBERA",
				"NUTAN BHARENGA",
				"WARD NO-02",
				"WARD NO-03",
				"HATURIA NAKALIA",
				"MASUNDIA",
				"WARD NO-09",
				"RUPPUR",
				"JATSAKHNI",
				"KYTOLA",
				"DHALAR CHAR",
				"DHUKARIA BERA",
			}
		},
		{
			"PABNABHANGURA",
			new List<string>
			{
				"ASHTA MANISHA",
				"KHAN MARICH",
				"BHANGURA",
				"PARBHANGURIA",
				"DIL PASAR",
			}
		},
		{
			"PABNACHATMOHAR",
			new List<string>
			{
				"NIMAICHARA",
				"BILCHALAN",
				"FAILJANA",
				"PARSHADANGA",
				"WARD NO-05",
				"DANTHIA BAMANGRAM",
				"CHHAIKHOLA",
				"MOTHURAPUR",
				"MULGRAM",
				"HARIPUR",
				"GUNAIGACHHA",
				"HANDIAL",
			}
		},
		{
			"PABNAFARIDPUR",
			new List<string>
			{
				"FARIDPUR",
				"WARD NO-05",
				"KRISHNANAGAR",
				"WARD NO-04",
				"AMBIKAPUR",
				"WARD NO-03",
				"GREDA",
				"WARD NO-01",
				"KANAIPUR",
				"WARD NO-02",
				"WARD NO-09",
				"KAIJURI",
				"MAJCHAR",
				"CHAR MADHABDIA",
				"DECREERCHAR",
				"ISHAN GOPALPUR",
				"ALIABAD",
				"UTTAR CHANNEL",
				"WARD NO-08",
				"BANWARINAGAR",
				"DEMRA",
				"HADAL",
				"BRI-LAHIRIBARI",
				"PUNGALI",
			}
		},
		{
			"PABNAISHWARDI",
			new List<string>
			{
				"CHAR ISHWARDIA UNION",
				"ISHWARDI",
				"LAKSHMIKUNDI",
				"SAHAPUR",
				"PAKSHI",
				"WARD NO-01",
				"DASHURIA",
				"SARA",
				"WARD NO-09",
				"SILIMPUR",
				"MULADULI",
				"WARD NO-06",
				"WARD NO-04",
				"WARD NO-07",
			}
		},
		{
			"PABNAPABNA SADAR",
			new List<string>
			{
				"DOGACHHI",
				"BHARARA",
				"MALANCHI",
				"WARD NO-02",
				"WARD NO-11",
				"WARD NO-05",
				"GAYESHPUR",
				"DAPUNIA",
				"WARD NO-03",
				"HEMAYETPUR",
				"WARD NO-15",
				"WARD NO-09",
				"WARD NO-14",
				"WARD NO-06",
				"WARD NO-07",
				"WARD NO-04",
				"SADULLAHPUR",
				"MALIGACHHA",
				"WARD NO-10",
				"CHAR TARAPUR",
				"ATAIKOLA",
			}
		},
		{
			"PABNASANTHIA",
			new List<string>
			{
				"DHULAURI",
				"DHOPADAHA",
				"KHATU PARA",
				"ATAIKOLA",
				"NANDANPUR",
				"KASHINATHPUR",
				"KARANJA",
				"WARD NO-05",
				"NAGDEMRA",
				"WARD NO-01",
				"GAURIGRAM",
				"BHULBARIA",
			}
		},
		{
			"PABNASUJANAGAR",
			new List<string>
			{
				"AHAMMEDPUR",
				"DULAI",
				"WARD NO-06",
				"SAGARKANDI",
				"SATBARIA",
				"MANIKHAT",
				"NAZIRGANJ",
				"TANTIBANDA",
				"HATKHALI",
				"RANINAGAR",
				"BHAYNA  (SUJANAGAR)",
				"SUJANAGAR",
				"WARD NO-03",
			}
		},
		{
			"RAJSHAHIBAGHA",
			new List<string>
			{
				"BAGHADI",
				"WARD NO-05",
				"SARBOATALI",
				"RUPAKARI",
				"BAGHAI CHHARI",
				"KEDARMARA",
				"BANGALTALI",
				"AMTALI",
				"MARISHYA",
				"SAJEK",
				"BAGHABA",
				"ARANI",
				"WARD NO-07",
				"PAKURIA",
				"MANIGRAM",
				"BAUSA",
				"WARD NO-06",
				"GARGARI",
				"BAJUBAGHA",
				"WARD NO-02",
				"BAGHA",
			}
		},
		{
			"RAJSHAHIBAGHMARA",
			new List<string>
			{
				"BAGHMARA UTTAR",
				"AUCH PARA",
				"NARDAS",
				"BASU PARA",
				"WARD NO-01 (TAHIRPUR)",
				"GANIPUR",
				"BARA BIHANALI",
				"SUBHADANGA",
				"HAMIR KUTSHA",
				"SONADANGA",
				"JHIKRA",
				"GOBINDA PARA",
				"JOGI PARA",
				"GOALKANDI",
				"DWIPPUR",
				"MARIA",
				"KACHHARI KAYALI PARA",
				"SREEPUR",
				"WARD NO-06",
			}
		},
		{
			"RAJSHAHIBOALIA",
			new List<string>
			{
				"BOALIA",
				"WARD NO-27 (PART)",
				"WARD NO-14 (PART)",
				"WARD NO-19",
				"WARD NO-09",
				"WARD NO-11",
				"WARD NO-22",
				"WARD NO-20",
				"WARD NO-13",
				"WARD NO-10 (PART)",
				"WARD NO-21",
				"WARD NO-23",
				"WARD NO-26",
				"WARD NO-16",
			}
		},
		{
			"RAJSHAHISHAH MAKHDUM",
			new List<string>
			{
				"WARD NO-17",
			}
		},
		{
			"RAJSHAHIRAJPARA",
			new List<string>
			{
				"BETMORE RAJPARA",
				"WARD NO-10 (PART)",
				"WARD NO-07",
				"WARD NO-05",
				"WARD NO-02",
			}
		},
		{
			"RAJSHAHIMATIHAR",
			new List<string>
			{
				"WARD NO-28",
				"WARD NO-30",
			}
		},
		{
			"RAJSHAHICHARGHAT",
			new List<string>
			{
				"YUSUFPUR",
				"NIMPARA",
				"WARD NO-06",
				"BHAYA LAKSHMIPUR",
				"SALUA",
				"CHARGHAT",
				"WARD NO-03",
				"WARD NO-05",
				"SARDAH",
			}
		},
		{
			"RAJSHAHIGODAGARI",
			new List<string>
			{
				"BASUDEBPUR",
				"WARD NO-06",
				"MATIKATA",
				"RISHIKUL",
				"GODAGARI",
				"DEOPARA",
				"MOHANPUR",
				"PAKRI",
				"WARD NO-02",
				"GOGRAM",
				"WARD NO-01 (KAKANHAT)",
				"WARD NO-09",
			}
		},
		{
			"RAJSHAHIDURGAPUR",
			new List<string>
			{
				"DURGAPUR",
				"DAKSHIN ALGI DURGAPUR",
				"UTTAR ALGI DURGAPUR",
				"UTTAR DURGAPUR",
				"DAKSHIN DURGAPUR",
				"CHANDIGARH",
				"WARD NO-01",
				"WARD NO-07",
				"BAKALJORA",
				"KULLAGORA",
				"KAKAIRGARA",
				"GAOKANDIA",
				"WARD NO-08",
				"SUNDARPUR DURGAPUR",
				"GOSIND DURGAPUR",
				"JOYNAGAR",
				"DELUABARI",
				"WARD NO-09",
				"WARD NO-06",
				"KISMAT GANKAIR",
				"DHARMAPUR (PANANAGAR)",
				"JHALUKA",
				"NOAPARA",
				"MARIA",
			}
		},
		{
			"RAJSHAHIMOHANPUR",
			new List<string>
			{
				"MOHANPUR",
				"WARD NO-03",
				"WARD NO-01",
				"MAUGACHHI",
				"BAKSHIMAIL",
				"JAHANABAD",
				"GHASIGRAM",
				"DHURAIL",
				"WARD NO-05",
				"ROYGHATI",
			}
		},
		{
			"RAJSHAHIPABA",
			new List<string>
			{
				"WARD NO-01",
				"WARD NO-07",
				"DAMKUR",
				"HUJURI PARA",
				"PARILA",
				"HARIPUR",
				"HARAGRAM",
				"BARAGACHHI",
				"DARSHAN PARA",
				"WARD NO-04",
				"WARD NO-03",
				"RUPABATI",
			}
		},
		{
			"RAJSHAHIPUTHIA",
			new List<string>
			{
				"SILMARIA",
				"BELPUKURIA",
				"BANESHWAR",
				"PUTHIA",
				"JEOPARA",
				"WARD NO-07",
				"WARD NO-04",
				"BHALUKGACHHI",
			}
		},
		{
			"RAJSHAHITANORE",
			new List<string>
			{
				"CHANDURIA",
				"WARD NO-04",
				"PACHANDAR",
				"SARANJAI",
				"KAMARGAON",
				"WARD NO-01 (MUNDUMALA)",
				"TALANDA",
				"KALMA",
				"BADHAIR",
				"WARD NO-05",
				"WARD NO-09",
				"WARD NO-03",
				"WARD NO-02",
				"WARD NO-06",
			}
		},
		{
			"SIRAJGANJBELKUCHI",
			new List<string>
			{
				"RAJAPUR",
				"DHUKARIA BERA",
				"DAULATPUR",
				"BELKUCHI",
				"WARD NO-07",
				"BHANGABARI",
				"BARA DHUL",
				"WARD NO-05",
				"WARD NO-09",
			}
		},
		{
			"SIRAJGANJCHAUHALI",
			new List<string>
			{
				"BAGUTIA",
				"KHAS PUKURIA",
				"SADIA CHANDPUR",
				"KHAS KAULIA",
				"STHAL",
				"OMARPUR",
				"GHARJAN",
			}
		},
		{
			"SIRAJGANJKAMARKHANDA",
			new List<string>
			{
				"JAMTAIL",
				"BHADRAGHAT",
				"JHAWAIL",
				"ROY DAULATPUR",
			}
		},
		{
			"SIRAJGANJKAZIPUR",
			new List<string>
			{
				"KAZIPUR",
				"SUBHAGACHHA",
				"GANDAIL",
				"MANSUR NAGAR",
				"MAIJBARI",
				"CHALITADANGA",
				"WARD NO-01",
				"SONAMUKHI",
				"CHAR GIRISH",
				"NATUAR PARA",
				"KHAS RAJBARI",
				"WARD NO-04",
				"WARD NO-07",
				"TEKANI",
				"NISHCHINTAPUR",
			}
		},
		{
			"SIRAJGANJROYGANJ",
			new List<string>
			{
				"ROYGANJ",
				"CHANDAIKONA",
				"DHANGARA",
				"NALKA",
				"DHUBIL",
				"GHURKA",
				"SONAKHARA",
				"PANGASHI",
				"BRAHMAGACHHA",
				"DHAMAINAGAR",
			}
		},
		{
			"SIRAJGANJSHAHJADPUR",
			new List<string>
			{
				"NARINA",
				"WARD NO-08",
				"KAYEMPUR",
				"RUPABATI",
				"GARADAHA",
				"WARD NO-03",
				"PORJANA",
				"POTAJIA",
				"BELTAIL",
				"KAIJURI",
				"KHUKNI",
				"HABIBULLANAGAR",
				"GALA",
				"SONATANI",
			}
		},
		{
			"SIRAJGANJSIRAJGANJ SADAR",
			new List<string>
			{
				"WARD NO-04",
				"BAGHBATI",
				"MECHHRA",
				"SHIALKUL",
				"SAIDABAD",
				"BAHULI",
				"RATANKANDI",
				"WARD NO-08",
				"WARD NO-05",
				"WARD NO-03",
				"WARD NO-13",
				"WARD NO-09",
				"CHHANGACHHA",
				"WARD NO-12",
				"WARD NO-11",
				"KHOKSABARI",
				"KALIA HARIPUR",
				"WARD NO-15",
				"WARD NO-01",
				"WARD NO-07",
			}
		},
		{
			"SIRAJGANJTARASH",
			new List<string>
			{
				"BARUHAS",
				"NAOGAON",
				"TARASH",
				"MAGURA BINOD",
				"SAGUNA",
				"TALAM",
				"DESHIGRAM",
				"MADHAINAGAR",
			}
		},
		{
			"SIRAJGANJULLAH PARA",
			new List<string>
			{
				"SALAP",
				"RAMKRISHNAPUR",
				"SALANGA",
				"BARAHAR",
				"PANCHA KRUSHI",
				"ULLAH PARA",
				"MOHANPUR",
				"PURNIMAGANTI",
				"BARA PANGASHI",
				"BANGALA",
				"DURGANAGAR",
				"UDHUNIA",
				"HATIKUMRUL",
				"WARD NO-05",
				"KOYRA",
				"WARD NO-08",
			}
		},
		{
			"DINAJPURBIRAMPUR",
			new List<string>
			{
				"DEOR",
				"WARD NO-04",
				"JOTBANI",
				"BENAIL",
				"MUKUNDAPUR",
				"KATLA",
				"WARD NO-01",
				"WARD NO-06",
				"KHANPUR",
				"WARD NO-02",
				"WARD NO-07",
				"WARD NO-08",
				"PALI PRAYAGPUR",
				"WARD NO-05",
				"WARD NO-03",
			}
		},
		{
			"DINAJPURBIRGANJ",
			new List<string>
			{
				"MOHANPUR",
				"SHIBRAMPUR",
				"MARICHA",
				"BHOGNAGAR",
				"SHATAGRAM",
				"NIJPARA",
				"MOHAMMADPUR",
				"SATAIR",
				"PALTAPUR",
				"WARD NO-06",
				"WARD NO-04",
				"SUJALPUR",
				"PALASHBARI",
			}
		},
		{
			"DINAJPURBIRAL",
			new List<string>
			{
				"BIRALIA",
				"BIRAL",
				"FARAKKABAD",
				"MANGALPUR",
				"SAHARGRAM",
				"DHAMAIR",
				"BIJORA",
				"BHANDARA",
				"RANI PUKUR",
				"AZIMPUR",
				"DHARMAPUR",
				"PALASHBARI",
			}
		},
		{
			"DINAJPURBOCHAGANJ",
			new List<string>
			{
				"MUSHIDHAT",
				"WARD NO-03",
				"ATGAON",
				"CHHATAIL",
				"ISHANIA",
				"RANGAON",
				"NAFANAGAR",
				"WARD NO-01",
			}
		},
		{
			"DINAJPURCHIRIRBANDAR",
			new List<string>
			{
				"ABDULPUR",
				"SAINTARA",
				"SATNALA",
				"ALOKDIHI",
				"FATEHJANAPUR",
				"ISABPUR",
				"AULIA PUKUR",
				"BHIAIL",
				"NASRATPUR",
				"AMARPUR",
				"PUNATTI",
				"TENTULIA",
			}
		},
		{
			"DINAJPURKHANSAMA",
			new List<string>
			{
				"GOALDIHI",
				"BHERBHERI",
				"KHAMAR PARA",
				"ANGAR PARA",
				"ALOKJHARI",
				"BHABKI",
			}
		},
		{
			"DINAJPURKAHAROLE",
			new List<string>
			{
				"MUKUNDAPUR",
				"RASULPUR",
				"DABAR",
				"RAMCHANDRAPUR",
				"TARGAON",
				"SUNDARPUR",
			}
		},
		{
			"DINAJPURFULBARI",
			new List<string>
			{
				"FULBARIA",
				"RADHAKANAI",
				"RANGAMATIA",
				"WARD NO-03",
				"ACHIM PATULI",
				"DEOKHOLA",
				"BALIAN",
				"BHABANIPUR",
				"PUTIJANA",
				"KALADAHA",
				"ENAYETPUR",
				"KUSHMAIL",
				"BAKTA",
				"WARD NO-07",
				"NAOGAON",
				"FULBARI UNION",
				"ELUARY",
				"WARD NO-06",
				"BETDIGHI",
				"DAULATPUR",
				"ALADIPUR",
				"KHAYERBARI",
				"WARD NO-05",
				"SHIBNAGAR",
				"KAZIHAL",
				"FULBARI",
			}
		},
		{
			"DINAJPURGHORAGHAT",
			new List<string>
			{
				"ARD NO-09",
				"PALSA",
				"SINGRA",
				"WARD NO-05",
				"BULAKIPUR",
				"WARD NO-08",
				"WARD NO-01",
				"GHORAGHAT",
			}
		},
		{
			"DINAJPURHAKIMPUR",
			new List<string>
			{
				"HAKIMPUR",
				"KHATTA MADHAB PARA",
				"WARD NO-01",
				"ALIHAT",
				"BOALDAR",
				"WARD NO-07",
				"WARD NO-09",
			}
		},
		{
			"DINAJPURDINAJPUR SADAR",
			new List<string>
			{
				"SUNDARBAN",
				"WARD NO-03",
				"WARD NO-08",
				"AULIAPUR",
				"WARD NO-10",
				"WARD NO-11",
				"WARD NO-05",
				"WARD NO-02",
				"WARD NO-06",
				"SHASHARA",
				"KAMALPUR",
				"WARD NO-07",
				"SHANKARPUR",
				"SEKHPURA",
				"ASKARPUR",
				"UTHRAIL",
				"FAZILPUR",
				"WARD NO-09",
				"WARD NO-04",
				"WARD NO-01",
			}
		},
		{
			"DINAJPURNAWABGANJ",
			new List<string>
			{
				"CHURAIN",
				"SHIKARI PARA",
				"KAILAIL",
				"KALAKOPA",
				"NAYANSREE",
				"AGLA",
				"BARUAKHALI",
				"SHOLLA",
				"GALIMPUR",
				"BARRAH",
				"JANTRAIL",
				"BAKSHANAGAR",
				"JOYKRISHNAPUR",
				"BANDURA",
				"DAUDPUR",
				"BINODNAGAR",
				"BHADURIA",
				"MAHMUDPUR",
				"KUSHDAHA",
				"PUTIMARA",
				"GOLAPGANJ",
				"SHALKHURIA",
				"JOYPUR",
			}
		},
		{
			"DINAJPURPARBATIPUR",
			new List<string>
			{
				"WARD NO-03",
				"WARD NO-01",
				"WARD NO-09",
				"WARD NO-08",
				"RAMPUR",
				"BELAICHANDI",
				"HABRA",
				"MOMINPUR",
				"PALASHBARI",
				"MOSTAFAPUR",
				"HARIRAMPUR",
				"MANMATHAPUR",
				"WARD NO-02",
				"CHANDIPUR",
				"WARD NO-04",
				"WARD NO-05",
				"HAMIDPUR",
				"WARD NO-07",
				"PARBATIPUR",
			}
		},
		{
			"GAIBANDHAFULCHHARI",
			new List<string>
			{
				"GAZARIA",
				"KANCHI PARA",
				"URIA",
				"UDAKHALI",
				"ERENDABARI",
				"FAZLUPUR",
			}
		},
		{
			"GAIBANDHAGAIBANDHA SADAR",
			new List<string>
			{
				"WARD NO-06",
				"SAHA PARA",
				"BOALI",
				"KAMARJANI",
				"BALLAMJHAR",
				"GHAGOA",
				"BADIAKHALI",
				"KHOLAHATI",
				"GIDARI",
				"RAMCHANDRAPUR",
				"WARD NO-04",
				"LAKSHMIPUR",
				"MOLLAR CHAR",
				"MALIBARI",
				"KUPTALA",
				"WARD NO-05",
				"WARD NO-01",
			}
		},
		{
			"GAIBANDHAGOBINDAGANJ",
			new List<string>
			{
				"WARD NO-09",
				"MAHIMAGANJ",
				"WARD NO-06",
				"KAMDIA",
				"GUMANIGANJ",
				"SAPMARA",
				"NAKAI",
				"DARBASTA",
				"HARIRAMPUR",
				"KOCHASAHAR",
				"SHALMARA",
				"RAKHAL BURUZ",
				"TALUK KANUPUR",
				"RAJAHAR",
				"FULBARI",
				"KATABARI",
				"SHIBPUR",
				"WARD NO-08",
				"KAMARDAHA",
				"SHAKHAHAR",
				"WARD NO-01",
			}
		},
		{
			"GAIBANDHAPALASHBARI",
			new List<string>
			{
				"PALASHBARIA",
				"PALASHBARI",
				"BETKAPA",
				"PABNAPUR",
				"BARISAL",
				"HOSSAINPUR",
				"MANOHARPUR",
				"MOHADIPUR",
				"HARINATHPUR",
				"KISHOREGARI",
				"BARA PALASHBARI",
			}
		},
		{
			"GAIBANDHASADULLAPUR",
			new List<string>
			{
				"SADULLAPUR",
				"KHURDA KAMARPUR",
				"BANAGRAM",
				"NALDANGA",
				"FARIDPUR",
				"RASULPUR",
				"DHAPERHAT",
				"DAMODARPUR",
				"JAMALPUR",
				"IDILPUR",
				"BHATGRAM",
				"KAMAR PARA",
			}
		},
		{
			"GAIBANDHASAGHATA",
			new List<string>
			{
				"JUMMERBARI",
				"SAGHATA",
				"BHARTKHALI",
				"BONAR PARA",
				"MUKTANAGAR",
				"KAMALER PARA",
				"PADUMSAHAR",
				"KACHUA",
				"GHURIDAHA",
				"HALDIA",
			}
		},
		{
			"GAIBANDHASUNDARGANJ",
			new List<string>
			{
				"BAMANDANGA",
				"HARIPUR",
				"BELKA",
				"RAMJIBAN",
				"SONAROY",
				"KANCHIBARI",
				"CHANDIPUR",
				"WARD NO-02",
				"CHHAPARHATI",
				"SREEPUR",
				"DAHABANDA",
				"DHOPADANGA",
				"TARAPUR",
				"KAPASIA",
				"SARBANANDA",
				"SHANTIRAM",
				"WARD NO-03",
			}
		},
		{
			"KURIGRAMBHURUNGAMARI",
			new List<string>
			{
				"BHURUNGAMARI",
				"PAIKER CHHARA",
				"PATHARDUBI",
				"JOYMANIRHAT",
				"ANDHARI JHAR",
				"TILAI",
				"CHAR BHURUNGAMARI",
				"BANGASONAHAT",
				"SHILKHURI",
				"BOLDIA",
			}
		},
		{
			"KURIGRAMCHAR RAJIBPUR",
			new List<string>
			{
				"MOHANGANJ",
				"CHAR RAJIBPUR",
				"KODAILKATI",
			}
		},
		{
			"KURIGRAMCHILMARI",
			new List<string>
			{
				"CHILMARI",
				"THANAHAT",
				"RAMNA",
				"RANIGANJ",
				"ASHTAMIR CHAR",
				"NAYERHAT",
			}
		},
		{
			"KURIGRAMPHULBARI",
			new List<string>
			{
				"PHULBARI",
				"KASHIPUR",
				"BHANAGMORE",
				"BARA BHITA",
				"SHIMULBARI",
				"NAODANGA",
			}
		},
		{
			"KURIGRAMKURIGRAM SADAR",
			new List<string>
			{
				"WARD NO-01",
				"MOGALBACHHA",
				"KANTHALBARI",
				"BHOGDANGA",
				"PUNCHGACHHI",
				"GHOGADAHA",
				"HOLOKHANA",
				"JATRAPUR",
				"BELGACHHA",
				"WARD NO-03",
				"WARD NO-04",
				"WARD NO-07",
				"WARD NO-05",
				"WARD NO-08",
			}
		},
		{
			"KURIGRAMNAGESHWARI",
			new List<string>
			{
				"WARD NO-04",
				"BHITARBAND",
				"KEDAR",
				"SANTOSHPUR",
				"RAMKHANA",
				"KALIGANJ",
				"BALLABHER KHAS",
				"BERUBARI",
				"BAMANDANGA",
				"NEWASHI",
				"WARD NO-07",
				"ROYGANJ",
				"KACHAKATA",
				"HASNABAD",
				"NARAYANPUR",
				"WARD NO-05",
				"WARD NO-09",
				"NOONKHAWA",
				"WARD NO-08",
				"WARD NO-06",
			}
		},
		{
			"KURIGRAMRAJARHAT",
			new List<string>
			{
				"OMAR MAJID",
				"CHAKIRPASHAR",
				"BIDYANANDA",
				"CHHINAI",
				"RAJARHAT",
				"NAZIMKHAN",
				"GHARIALDANGA",
			}
		},
		{
			"KURIGRAMRAUMARI",
			new List<string>
			{
				"JADUR CHAR",
				"BANDABER",
				"RAUMARI",
				"SAULMARI",
				"DANTBHANGA",
			}
		},
		{
			"KURIGRAMULIPUR",
			new List<string>
			{
				"DURGAPUR",
				"THETROY",
				"BURABURI",
				"GUNAIGACHH",
				"DALDALIA",
				"WARD NO-07",
				"SAHEBER ALGA",
				"TABAKPUR",
				"BAZRA",
				"HATIA",
				"BEGUMGANJ",
				"DHARANIBARI",
				"WARD NO-01",
				"PANDUL",
				"WARD NO-06",
				"DHAMSERNI",
				"WARD NO-08",
				"WARD NO-04",
			}
		},
		{
			"LALMONIRHATADITMARI",
			new List<string>
			{
				"KAMALABARI",
				"MAHISHKHOCHA",
				"DURGAPUR",
				"SAPTIBARI",
				"SARPUKUR",
				"BHADAI",
				"PALASHI",
				"BHELABARI",
			}
		},
		{
			"LALMONIRHATHATIBANDHA",
			new List<string>
			{
				"HATIBANDHA MALIJHIKANDA",
				"HATIBANDHA",
				"TANGBHANGA",
				"GOTAMARI",
				"BARAKHATA",
				"GODDIMARI",
				"DAOABARI",
				"BHALAGURI",
				"NOWDABASH",
				"SANIAJAN",
				"SINDURNA",
				"SHINGIMARI",
				"PATIKA PARA",
			}
		},
		{
			"LALMONIRHATKALIGANJ",
			new List<string>
			{
				"BAKTARPUR",
				"JAMALPUR",
				"MOKTARPUR",
				"WARD NO-05",
				"BAHADURSADI",
				"TUMULIA",
				"WARD NO-03",
				"JANGALIA",
				"WARD NO-06",
				"SUNDARPUR DURGAPUR",
				"TRILOCHANPUR",
				"NIAMATPUR",
				"RAKHALGACHHI",
				"KASHTABHANGA",
				"ROYGRAM",
				"BARA BAZAR",
				"KOLA",
				"JAMAL",
				"SIMLA ROKONPUR",
				"MALIAT",
				"KUSHLIA",
				"BHARA SIMLA",
				"CHAMPAPHUL",
				"NALTA",
				"DHALBARIA",
				"BISHNUPUR",
				"RATANPUR",
				"DAKSHIN SREEPUR",
				"KRISHNANAGAR",
				"MAUTALA",
				"TARALI",
				"MATHURESHPUR",
				"KALIGANJ",
				"TUSHBHANDAR",
				"KAKINA",
				"BHOTEMARI",
				"DALAGRAM",
				"MADATI",
				"CHANDRAPUR",
				"GORAL",
				"CHALBALA",
				"KAJAL DIGHI KALIGANJ",
				"NAGARI",
			}
		},
		{
			"LALMONIRHATLALMONIRHAT SADAR",
			new List<string>
			{
				"WARD NO-03",
				"WARD NO-02",
				"KHUNIAGACHH",
				"GOKUNDA",
				"MAHENDRANAGAR",
				"BARABARI",
				"PANCHAGRAM",
				"HARATI",
				"MOGALHAT",
				"KULAGHAT",
				"RAJPUR",
				"WARD NO-06",
				"WARD NO-01",
			}
		},
		{
			"LALMONIRHATPATGRAM",
			new List<string>
			{
				"WARD NO-06",
				"JAGATBER",
				"SREERAMPUR",
				"BAURA",
				"JONGRA",
				"WARD NO-09",
				"KUCHLIBARI",
				"PATGRAM",
				"BURIMARI",
			}
		},
		{
			"NILPHAMARIDIMLA UPAZILA",
			new List<string>
			{
				"KHOGA KHARIBARI",
				"NAOTARA UNION",
				"PASCHIM CHHATNAI",
				"PURBA CHHATNAI",
				"JHUNAGACHH CHAPANI",
				"KHALISA CHAPANI",
				"GAYABARI",
				"DIMLA",
				"TEPA KHARIBARI",
			}
		},
		{
			"NILPHAMARIJALDHAKA UPAZILA",
			new List<string>
			{
				"KAIMARI",
				"WARD NO-06",
				"GOLMUNDA",
				"SAULMARI",
				"SHIMULBARI",
				"MIRGANJ",
				"DAOABARI",
				"GOLNA",
				"KHUTAMARA",
				"KANTHALI",
				"WARD NO-04",
				"DHARMAPAL",
				"WARD NO-02",
				"WARD NO-08",
				"BALAGRAM",
			}
		},
		{
			"NILPHAMARIDOMAR UPAZILA",
			new List<string>
			{
				"WARD NO-04",
				"DOMAR UNION",
				"KETKIBARI",
				"JORABARI",
				"BAMUNIA UNION",
				"SONAROY",
				"PANGA MATUKPUR",
				"BHOGDABARI UNION",
				"BORAGARI UNION",
				"GOMNATI UNION",
				"HARINCHARA",
			}
		},
		{
			"NILPHAMARIKISHOREGANJ UPAZILA",
			new List<string>
			{
				"KISHOREGANJ",
				"MAGURA",
				"NITAI",
				"GARAGRAM",
				"PUTIMARI",
				"CHANDKHANA",
				"BARABHITA",
				"RANACHANDI",
				"BAHAGILI",
			}
		},
		{
			"NILPHAMARINILPHAMARI SADAR UPAZ",
			new List<string>
			{
				"SANGALSHI",
				"WARD NO-04",
				"RAMNAGAR",
				"SONAROY",
				"KACHUKATA",
				"TUPAMARI",
				"GORGRAM",
				"LAKSHMI CHAP",
				"CHAPRA SARAMJANI",
				"PALASHBARI",
				"WARD NO-03",
				"CHAORA BARGACHHA",
				"CHARAIKHOLA",
				"KUNDA PUKUR",
				"KHOKSHABARI",
				"PANCH PUKUR",
				"ITAKHOLA",
				"WARD NO-09",
			}
		},
		{
			"NILPHAMARISAIDPUR UPAZILA",
			new List<string>
			{
				"WARD NO-06",
				"WARD NO-05",
				"WARD NO-13",
				"WARD NO-14",
				"WARD NO-03",
				"WARD NO-04",
				"BANGALIPUR",
				"KUSHIRAM BELPUKUR",
				"WARD NO-01",
				"BOTHLAGARI",
				"WARD NO-11",
			}
		},
		{
			"RANGPURGANGACHARA",
			new List<string>
			{
				"ALAM BIDITAR",
				"GANGACHARA",
				"KOLKANDA",
				"BETGARI",
				"KHALEYA",
				"GAJAGHANTA",
				"MARANIA",
			}
		},
		{
			"RANGPURBADARGANJ",
			new List<string>
			{
				"DAMODARPUR",
				"RAMNATHPUR",
				"BISHNUPUR",
				"RADHANAGAR",
				"GOPALPUR",
				"LOHANI PARA",
				"KUTUBPUR",
				"GOPINATHPUR",
				"WARD NO-02",
				"KALU PARA",
				"MADHUPUR",
				"WARD NO-09",
				"WARD NO-08",
			}
		},
		{
			"RANGPURPIRGACHHA",
			new List<string>
			{
				"ITAKUMARI",
				"PIRGACHHA",
				"TAMBULPUR",
				"CHHAOLA",
				"ANNADANAGAR",
				"KAIKURI",
				"PARUL",
				"KALYANI",
				"KANDI",
			}
		},
		{
			"RANGPURKAUNIA",
			new List<string>
			{
				"WARD NO-03",
				"KAUNIA BALA PARA",
				"SARAI",
				"WARD NO-04",
				"TEPA MADHUPUR",
				"WARD NO-06",
				"KURSHA",
				"WARD NO-01",
				"HARAGACHH",
				"SHAHIDBAGH",
				"WARD NO-07",
				"WARD NO-05",
			}
		},
		{
			"RANGPURRANGPUR SADAR",
			new List<string>
			{
				"MOMINPUR",
				"WARD NO-27",
				"WARD NO-18",
				"WARD NO-29 (PART)",
				"WARD NO-23",
				"WARD NO-16",
				"WARD NO-04",
				"WARD NO-24",
				"WARD NO-28",
				"WARD NO-21",
				"WARD NO-26",
				"WARD NO-19",
				"WARD NO-06",
				"HARIDEBPUR",
				"WARD NO-02",
				"WARD NO-14",
				"WARD NO-07",
				"SADYA PUSHKARNI",
				"CHANDANPAT",
				"WARD NO-01",
				"WARD NO-12",
				"WARD NO-25",
				"WARD NO-33",
				"WARD NO-20",
				"WARD NO-15",
				"WARD NO-32",
				"WARD NO-22",
				"WARD NO-08",
				"WARD NO-11",
				"WARD NO-17",
				"WARD NO-13",
				"WARD NO-10",
				"WARD NO-05",
				"WARD NO-09",
			}
		},
		{
			"RANGPURMITHA PUKUR",
			new List<string>
			{
				"LATIFPUR",
				"DURGAPUR",
				"MIRZAPUR",
				"MAYENPUR",
				"BALUA MASIMPUR",
				"RANI PUKUR",
				"BHANGNI",
				"KAFRIKHAL",
				"PAIRABAND",
				"GOPALPUR",
				"BALARHAT",
				"CHENGMARI",
				"BARABALA",
				"EMADPUR",
				"BARA HAZRATPUR",
				"MILANPUR",
				"KHORAGACHH",
			}
		},
		{
			"RANGPURPIRGANJ",
			new List<string>
			{
				"PANCHGACHHA",
				"PIRGANJ",
				"KABILPUR",
				"MADANKHALI",
				"ROYPUR",
				"BHENDABARI",
				"BARA ALAMPUR",
				"MITHAPUR",
				"CHATRA",
				"RAMNATHPUR",
				"TUKURIA",
				"BARA DARGAH",
				"CHAITRAKUL",
				"KUMEDPUR",
				"SHANERHAT",
				"WARD NO-06",
				"BHOMRADAHA",
				"JABARHAT",
				"SAIDPUR",
				"HAJIPUR",
				"BAIRCHUNA",
				"DAULATPUR",
				"KHANGAON",
				"SENGAON",
				"KUSHA RANIGANJ",
				"WARD NO-09",
				"WARD NO-03",
			}
		},
		{
			"RANGPURTARAGANJ",
			new List<string>
			{
				"SAYAR",
				"HARIARKUTI",
				"ALAMPUR",
				"EKARCHALI",
				"KURSHA",
			}
		},
		{
			"PANCHAGARHBODA",
			new List<string>
			{
				"BODA",
				"JHALAISHALSIRI",
				"KAJAL DIGHI KALIGANJ",
				"MAIDAN DIGHI",
				"CHANDANBARI",
				"SAKOA",
				"WARD NO-06",
				"BANAGRAM",
				"PANCHPIR",
				"MAREA BAMANHAT",
				"WARD NO-08",
				"BARA SHASHI",
			}
		},
		{
			"PANCHAGARHATWARI",
			new List<string>
			{
				"MIRZAPUR",
				"ALOWA KHOWA",
				"RADHANAGAR",
				"TARIA",
				"BALARAMPUR",
				"DHAMOR",
			}
		},
		{
			"PANCHAGARHDEBIGANJ",
			new List<string>
			{
				"DANDAPAL",
				"CHILAHATI",
				"MALLIKADAHA",
				"TEPRIGANJ",
				"PAMULI",
				"SUNDAR DIGHI",
				"HAZRADANGA",
				"DEBIGANJ",
				"DEBIDOBA",
				"SALDANGA",
			}
		},
		{
			"PANCHAGARHPANCHAGARH SADAR",
			new List<string>
			{
				"PANCHAGARH",
				"KAMAT KAJAL DIGHI",
				"MAGURA",
				"DHAKKAMARA",
				"HARIBHASA",
				"CHAKLARHAT",
				"HAFIZABAD",
				"WARD NO-04",
				"SATMARA",
				"WARD NO-09",
				"GARINABARI",
				"WARD NO-06",
				"AMARKHANA",
				"WARD NO-03",
			}
		},
		{
			"PANCHAGARHTENTULIA",
			new List<string>
			{
				"TENTULIA",
				"DEBNAGAR",
				"TIMAIHAT",
				"SALBAHAN",
				"BURABURI",
				"BANGLABANDHA",
				"BHOJANPUR",
			}
		},
		{
			"THAKURGAONBALIADANGI",
			new List<string>
			{
				"BARABARI",
				"BHANOR",
				"CHAROL",
				"DHANTALA",
				"BARA PALASHBARI",
				"PARIA",
				"AMJANKHORE",
				"DUOSUO",
			}
		},
		{
			"THAKURGAONHARIPUR",
			new List<string>
			{
				"HATAS HARIPUR",
				"HARIPUR",
				"KALIA HARIPUR",
				"AMGAON",
				"GEDURA",
				"BHATURIA",
				"DANGI PARA",
				"BAKUA",
			}
		},
		{
			"THAKURGAONPIRGANJ",
			new List<string>
			{
				"PANCHGACHHA",
				"PIRGANJ",
				"KABILPUR",
				"MADANKHALI",
				"ROYPUR",
				"BHENDABARI",
				"BARA ALAMPUR",
				"MITHAPUR",
				"CHATRA",
				"RAMNATHPUR",
				"TUKURIA",
				"BARA DARGAH",
				"CHAITRAKUL",
				"KUMEDPUR",
				"SHANERHAT",
				"WARD NO-06",
				"BHOMRADAHA",
				"JABARHAT",
				"SAIDPUR",
				"HAJIPUR",
				"BAIRCHUNA",
				"DAULATPUR",
				"KHANGAON",
				"SENGAON",
				"KUSHA RANIGANJ",
				"WARD NO-09",
				"WARD NO-03",
			}
		},
		{
			"THAKURGAONRANISANKAIL",
			new List<string>
			{
				"WARD NO-01",
				"HOSSAIN GAON",
				"KASHIPUR",
				"NONDUAR",
				"RATOR",
				"LEHEMBA",
				"WARD NO-08",
				"BACHOR",
				"NEKMARAD",
				"DHARMAGARH",
				"WARD NO-02",
			}
		},
		{
			"THAKURGAONTHAKURGAON SADAR",
			new List<string>
			{
				"RUHEA",
				"WARD NO-07",
				"WARD NO-12",
				"WARD NO-01",
				"WARD NO-03",
				"AULIAPUR",
				"RAHIMANPUR",
				"BALIA",
				"AKHANAGAR",
				"AKCHA",
				"GAREYA",
				"DEBIPUR",
				"BEGUNBARI",
				"SALANDAR",
				"JAGANNATHPUR",
				"ROYPUR",
				"MOHAMMADPUR",
				"JAMALPUR",
				"BARAGAON",
				"CHILARANG",
				"WARD NO-11",
				"DHOLARHAT",
				"RAJAGAON",
				"SUKHANPUKHARI",
				"NARGUN",
				"WARD NO-05",
				"WARD NO-02",
			}
		},
		{
			"HABIGANJAJMIRIGANJ",
			new List<string>
			{
				"AJMIRIGANJ",
				"JALSUKA",
				"KAKAILSEO",
				"WARD NO-01",
				"BADALPUR",
				"SHIBPASHA",
			}
		},
		{
			"HABIGANJBAHUBAL",
			new List<string>
			{
				"LAMATASHI",
				"MIRPUR",
				"SNANGHAT",
				"BAHUBAL",
				"BHADESHWAR",
				"SATKAPAN",
			}
		},
		{
			"HABIGANJBANIACHONG",
			new List<string>
			{
				"UTTAR PURBA BANIACHANG",
				"MANDARI",
				"MAKRAMPUR",
				"KHAGAURA",
				"PUKHRA",
				"DAULATPUR",
				"KAGAPASHA",
				"BARAIURI",
				"DAKSHIN PURBA BANIYACHANG",
				"SUBIDPUR",
				"PAILARKANDI",
				"SUJATPUR",
			}
		},
		{
			"HABIGANJCHUNARUGHAT",
			new List<string>
			{
				"CHUNARUGHAT",
				"SHATIAJURI",
				"WARD NO-03",
				"SANKHOLA",
				"AHMADABAD",
				"DEORGACHH",
				"MIRAHI",
				"UBAHATA",
				"PAIK PARA",
				"GAZIPUR",
				"RANIGAON",
			}
		},
		{
			"HABIGANJHABIGANJ SADAR",
			new List<string>
			{
				"NIZAMPUR",
				"WARD NO-09",
				"WARD NO-05",
				"SAISTAGANJ",
				"POIL",
				"LUKHRA",
				"NURPUR",
				"RAZIURA",
				"LASKARPUR",
				"RICHI",
				"GOPAYA",
				"TEGHARIA",
				"WARD NO-01 (SHAYESTAGANG)",
			}
		},
		{
			"HABIGANJLAKHAI",
			new List<string>
			{
				"LAKHAI",
				"KARAB",
				"BAMAI",
				"MURAKARI",
				"BULLA",
				"MURIAUK",
			}
		},
		{
			"HABIGANJMADHABPUR",
			new List<string>
			{
				"MADHABPUR",
				"WARD NO-07",
				"BAGASURA",
				"BAHARA",
				"ADAIR",
				"CHHATIAIN",
				"ANDIURAUK",
				"DHARMAGHAR",
				"SHAHJAHANPUR",
				"BULLA",
			}
		},
		{
			"HABIGANJNABIGANJ",
			new List<string>
			{
				"KURSHI",
				"DIGHALBAK",
				"NABIGANJ",
				"WARD NO-02",
				"GAZNAPUR",
				"PURBA BARA BAKHAIR",
				"INATHGANJ",
				"DEBPARA",
				"WARD NO-07",
				"BAUSHA",
			}
		},
		{
			"MAULVIBAZARBARLEKHA",
			new List<string>
			{
				"NIJ BAHADURPUR",
				"DAKSHIN DAKSHINBHAGH",
				"DASHER BAZAR",
				"SUJANAGAR",
				"TALIMPUR",
				"DAKSHIN SHAHABAJPUR",
				"BARLEKHA",
				"BARNI",
				"UTTAR DAKSHINBHAG",
				"WARD NO-02",
			}
		},
		{
			"MAULVIBAZARJURI",
			new List<string>
			{
				"DARI CHAR KHAJURIA",
				"AMRAJURI",
				"BINAJURI",
				"KAIJURI",
				"PINJURI",
				"BALIJURI",
				"ELONGJURI",
				"LOHAJURI",
				"SINGJURI",
				"BANIAJURI",
				"CHAKUA",
				"KRISHNAPUR",
				"KHALIAJURI",
				"MENDIPUR",
				"NAGAR",
				"ATJURI",
				"KHAJURIA",
				"HUJURI PARA",
				"SHATIAJURI",
				"PASCHIM JURI",
				"PURBA JURI",
				"JAIFARNAGAR",
				"FULTALA",
				"GOALBARI",
				"SAGARNAL",
				"GAZIPUR",
			}
		},
		{
			"MAULVIBAZARKAMALGANJ",
			new List<string>
			{
				"ADAMPUR",
				"SHAMSHERNAGAR",
				"RAHIMPUR",
				"KAMALGANJ",
				"MUNSHI BAZAR",
				"MADHABPUR",
				"PATANUSHAR",
				"ALINAGAR",
				"ISLAMPUR",
				"WARD NO-01",
			}
		},
		{
			"MAULVIBAZARKULAURA",
			new List<string>
			{
				"KULAURA",
				"BRAHMAN BAZAR",
				"PRITHIM PASHA",
				"WARD NO-07",
				"WARD NO-05",
				"HAJIPUR",
				"ROUTHGAON",
				"JOYCHANDI",
				"SHARIFPUR",
				"KARMADHA",
				"TILAGAON",
				"KADIRPUR",
				"BHUKSHIMAIL",
				"BARAMCHAL",
			}
		},
		{
			"MAULVIBAZARMAULVIBAZAR SADAR",
			new List<string>
			{
				"GIASNAGAR",
				"MANUMUKH",
				"WARD NO-03",
				"MOSTAFAPUR",
				"WARD NO-02",
				"WARD NO-09",
				"WARD NO-01",
				"KAMALPUR",
				"KHALILPUR",
				"NAZIRABAD",
				"EKATUNA",
				"UPPER KAGABALA",
				"AMTAIL",
				"AKHAILKURA",
				"KANAKPUR",
				"WARD NO-05",
			}
		},
		{
			"MAULVIBAZARRAJNAGAR",
			new List<string>
			{
				"RAJNAGAR",
				"TENGRA",
				"MUNSHI BAZAR",
				"UTTARBHAG",
				"MANSURNAGAR",
				"FATEHPUR",
				"PANCHGAON",
				"KAMAR CHAK",
			}
		},
		{
			"MAULVIBAZARSREEMANGAL",
			new List<string>
			{
				"SREEMANGAL",
				"BHUNABIR",
				"ASHIDRON",
				"KALAPUR",
				"SINDURKHAN",
				"MIRZAPUR",
				"SATGOAN",
				"WARD NO-01",
			}
		},
		{
			"SUNAMGANJBISHWAMBARPUR",
			new List<string>
			{
				"FATEHPUR",
				"PALASH",
				"SHOLUKABAD",
				"DHONPUR",
				"DAKSHIN BADAGHAT",
			}
		},
		{
			"SUNAMGANJCHHATAK",
			new List<string>
			{
				"DAKSHIN KHURMA",
				"SING CHAPAIR",
				"DULAR BAZAR",
				"SAIDERGAON",
				"BHATGAON",
				"SAILA AFZALABAD",
				"WARD NO-07",
				"DAKSHIN ISLAMPUR",
				"WARD NO-05",
				"JAWAR BAZAR",
				"KALARUKA",
				"CHARMOHALLA",
			}
		},
		{
			"SUNAMGANJJAGANNATHPUR",
			new List<string>
			{
				"JAGANNATHPUR",
				"HALDIPUR",
				"KALKALIA",
				"PAILGAON",
				"SYED PUR",
				"RANIGANJ",
				"PATALI",
				"WARD NO-01",
			}
		},
		{
			"SUNAMGANJDERAI",
			new List<string>
			{
				"KULANJ",
				"JAGADDAL",
				"DERAI SARMANGAL",
				"RAJANAGAR",
				"CHARNAR CHAR",
				"KARIMPUR",
				"TARAL",
				"RAFINAGAR",
				"BHATI PARA",
			}
		},
		{
			"SUNAMGANJDHARAMPASHA",
			new List<string>
			{
				"UTTAR SUKHAIR RAJAPUR",
				"DHARMAPASHA",
				"PAIKURATI",
				"DAKSHIN BONGSHIKUNDA",
				"JOYSREE",
				"MADHYANAGAR",
				"CHAMARDANI",
				"UTTAR BANGSHIKUNDA",
			}
		},
		{
			"SUNAMGANJDOWARABAZAR",
			new List<string>
			{
				"SURMA",
				"DUHALIA",
				"LAKSHMIPUR",
				"MANNARGAON",
				"BOUGLA BAZAR",
				"PANDERGAON",
				"NARSING PUR",
			}
		},
		{
			"SUNAMGANJJAMALGANJ",
			new List<string>
			{
				"JAMALGANJ",
				"VIMKHALI",
				"FENARBAK",
				"SACHNA BAZAR",
				"BEHELI",
			}
		},
		{
			"SUNAMGANJSULLA",
			new List<string>
			{
				"RASULLABAD",
				"BAHARA",
				"ATGAON",
				"HABIBPUR",
				"SULLA",
			}
		},
		{
			"SUNAMGANJDAKSHIN SUNAMGANJ",
			new List<string>
			{
				"SHIMULBAK",
				"PATHARIA",
				"PASCHIM BIRGAON",
				"PURBA BIRGOAN",
				"PURBA PAGLA",
				"JOYKALAS",
				"DURGAPASHA",
			}
		},
		{
			"SUNAMGANJSUNAMGANJ SADAR",
			new List<string>
			{
				"MOLLAH PARA",
				"MOHANPUR",
				"LAKSHMANSREE",
				"WARD NO-04",
				"WARD NO-05",
				"RANGAR CHAR",
				"SURMA",
				"JAHANGIRNAGAR",
				"GOURARARANG",
				"KATAIR",
			}
		},
		{
			"SUNAMGANJTAHIRPUR",
			new List<string>
			{
				"WARD NO-01 (TAHIRPUR)",
				"UTTAR SREEPUR",
				"BARADAL",
				"DAKSHIN BARADAL",
				"UTTAR BADAGHAT",
				"DAKSHIN SREEPUR",
				"BALIJURI",
			}
		},
		{
			"SYLHETBALAGANJ",
			new List<string>
			{
				"SADIPUR",
				"TAJPUR",
				"BALAGANJ",
				"GOULA BAZAR",
				"DAYAMIR",
				"OSMANPUR",
				"DEWAN BAZAR",
				"OMARPUR",
				"BOALJUR BAZAR",
				"PURBA GAURIPUR",
				"PASCHIM GAURIPUR",
				"PURBA PAILANPUR",
				"PASCHIM PAILANPUR",
			}
		},
		{
			"SYLHETBEANI BAZAR",
			new List<string>
			{
				"MATHIURA",
				"SHEOLA",
				"CHARKHAI",
				"MOLLAHPUR",
				"ALINAGAR",
				"WARD NO-02",
				"WARD NO-06",
				"KURAR BAZAR",
				"TILPARA",
				"LAUTA",
				"MURIA",
				"DOBHAG",
			}
		},
		{
			"SYLHETBISHWANATH",
			new List<string>
			{
				"RAMPASHA",
				"ALANKARI",
				"BISHWANATH",
				"DASGHAR",
				"LAMA KAZI",
				"DEOKALAS",
				"DAULATPUR",
				"KHAZANCHIGAON",
			}
		},
		{
			"SYLHETCOMPANIGANJ",
			new List<string>
			{
				"SIRAJPUR",
				"CHAR PARBATI",
				"MUSAPUR",
				"CHAR FAKIRA",
				"CHAR ELAHI",
				"WARD NO-08",
				"RAMPUR",
				"CHAR KAKRA",
				"CHAR HAZARI",
				"WARD NO-06",
				"ISLAMPUR PASCHIM",
				"RANIKHAI UTTAR",
				"ISLAMPUR PURBA",
				"TELIKHAL",
				"ISHAKALAS",
				"RANIKHAI DAKSHIN",
			}
		},
		{
			"SYLHETFENCHUGANJ",
			new List<string>
			{
				"FENCHUGANJ",
				"GHILACHHARA",
				"MAIJGAON",
				"UTTAR KUSHIARA",
			}
		},
		{
			"SYLHETGOLAPGANJ",
			new List<string>
			{
				"GOLAPGANJ",
				"DHAKA DAKSHIN",
				"LAKSHANABAND",
				"UTTAR BADE PASHA",
				"LAKSHMI PASHA",
				"BHADESHWAR",
				"WARD NO-07",
				"SHORIFGONJ",
				"FULBARI",
				"AMURA",
				"BAGHA",
				"BUDBARI BAZAR",
			}
		},
		{
			"SYLHETGOWAINGHAT",
			new List<string>
			{
				"ALIRGAON",
				"FATEHPUR",
				"TOWAKUL",
				"PASCHIM JAFLONG",
				"PURBA JAFLONG",
				"RUSTAMPUR",
				"NANDIRGAON",
				"DAUBARI",
			}
		},
		{
			"SYLHETJAINTIAPUR",
			new List<string>
			{
				"DARBASTA",
				"FATEHPUR",
				"NIJPAT",
				"CHIKNAGUL",
				"JAINTAPUR",
				"CHARIKATA",
			}
		},
		{
			"SYLHETKANAIGHAT",
			new List<string>
			{
				"WARD NO-03",
				"KANAIGHAT",
				"PURBA DIGHIRPAR",
				"JHINGRABARI",
				"DAKSHIN BANIGRAM",
				"RAJAGANJ",
				"SATBAK (PASCHIM DIGHIRPAR)",
				"PURBA LAKSHMI PRASAD",
				"PASCHIM LAKSHMIP RASAD",
				"BARA CHATUL",
			}
		},
		{
			"SYLHETSYLHET SADAR",
			new List<string>
			{
				"WARD NO-16",
				"WARD NO-09",
				"KHADIMNAGAR",
				"SYLHET CANTONMENT",
				"WARD NO-14",
				"WARD NO-02",
				"WARD NO-17",
				"WARD NO-03",
				"TUKER BAZAR",
				"WARD NO-20",
				"KHADIM PARA",
				"WARD NO-13",
				"HATKHOLA",
				"WARD NO-10",
				"JALALABAD",
				"WARD NO-01",
				"WARD NO-26",
				"WARD NO-25",
				"WARD NO-27",
				"MOGALGAON",
			}
		},
		{
			"SYLHETDAKSHIN SURMA",
			new List<string>
			{
				"MOLLARGAON",
				"KAMAL BAZAR",
				"JALALPUR",
				"LALA BAZAR",
				"KUCHAI",
				"TETLI",
				"DAUDPUR",
				"MOGLA BAZAR",
				"SILAM",
			}
		},
		{
			"SYLHETZAKIGANJ",
			new List<string>
			{
				"BARAHAL",
				"SULTANPUR",
				"MANIKPUR",
				"KASHKANAKPUR",
				"ZAKIGANJ",
				"KHOLACHHARA",
				"BIRASREE",
				"KAJALSHAR",
			}
		},
	};
}
