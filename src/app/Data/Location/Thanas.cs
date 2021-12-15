using System.Collections.Generic;

namespace KonSchool.App.Data;

public partial class LocationDataService
{
	Dictionary<string, List<string>> GetAllThanas() => new()
	{
		{
			"default",
			new List<string> { "Please select a District" }
		},
		{
			"BARGUNA",
			new()
			{
				"TALTALI",
				"AMTALI",
				"BAMNA",
				"BARGUNA SADAR",
				"BETAGI",
				"PATHARGHATA",
			}
		},
		{
			"BARISAL",
			new()
			{
				"AGAILJHARA",
				"BABUGANJ",
				"BAKERGANJ",
				"BANARI PARA",
				"GAURNADI",
				"HIZLA",
				"BARISAL SADAR (KOTWALI)",
				"MEHENDIGANJ",
				"MULADI",
				"WAZIRPUR",
			}
		},
		{
			"BHOLA",
			new()
			{
				"BHOLA SADAR",
				"BURHANUDDIN",
				"CHAR FASSON",
				"LALMOHAN",
				"DAULAT KHAN",
				"MANPURA",
				"TAZUMUDDIN",
			}
		},
		{
			"JHALOKATI",
			new()
			{
				"JHALOKATI SADAR",
				"KANTHALIA",
				"NALCHITY",
				"RAJAPUR",
			}
		},
		{
			"PATUAKHALI",
			new()
			{
				"BAUPHAL",
				"DASHMINA",
				"DUMKI UPAZILA",
				"GALACHIPA",
				"RANGABALI",
				"KALA PARA",
				"MIRZAGANJ UPAZILA",
				"PATUAKHALI SADAR",
			}
		},
		{
			"PIROJPUR",
			new()
			{
				"BHANDARIA",
				"KAWKHALI",
				"MATHBARIA",
				"NAZIRPUR UPAZILA",
				"PIROJPUR SADAR",
				"INDURKANI",
				"NESARABAD (SWARUPKATI)",
			}
		},
		{
			"BANDARBAN",
			new()
			{
				"ALIKADAM",
				"BANDARBAN SADAR",
				"LAMA",
				"NAIKHONGCHHARI",
				"THANCHI",
			}
		},
		{
			"BRAHAMANBARIA",
			new()
			{
				"AKHAURA",
				"BANCHHARAMPUR",
				"BRAHMANBARIA SADAR",
				"BIJOYNAGAR",
				"ASHUGANJ",
				"NABINAGAR",
				"KASBA",
				"NASIRNAGAR",
				"SARAIL",
			}
		},
		{
			"CHANDPUR",
			new()
			{
				"CHANDPUR SADAR",
				"SHAHRASTI",
				"FARIDGANJ",
				"HAIM CHAR",
				"HAJIGANJ",
				"KACHUA",
				"MATLAB DAKSHIN",
				"MATLAB UTTAR",
			}
		},
		{
			"CHITTAGONG",
			new()
			{
				"ANOWARA",
				"HATHAZARI",
				"BAYEJID BOSTAMI",
				"BANSHKHALI",
				"CHANDGAON",
				"BAKALIA",
				"BOALKHALI",
				"CHANDANAISH",
				"PATENGA",
				"CHITTAGONG PORT",
				"DOUBLE MOORING",
				"KHULSHI",
				"FATIKCHHARI",
				"PATIYA",
				"KOTWALI",
				"PANCHLAISH",
				"LOHAGARA",
				"MIRSHARAI",
				"PAHARTALI",
				"HALISHAHAR",
				"RANGUNIA",
				"RAOZAN",
				"SANDWIP",
				"SATKANIA",
				"SITAKUNDA",
			}
		},
		{
			"COMILLA",
			new()
			{
				"BARURA",
				"BRAHMAN PARA",
				"BURICHANG",
				"CHANDINA",
				"DAUDKANDI",
				"CHAUDDAGRAM",
				"TITAS",
				"DEBIDWAR",
				"HOMNA",
				"COMILLA SADAR DAKSHIN",
				"COMILLA ADARSHA SADAR",
				"MANOHARGANJ",
				"LAKSAM",
				"MEGHNA",
				"MURADNAGAR",
				"NANGALKOT",
			}
		},
		{
			"COXS BAZAR",
			new()
			{
				"CHAKARIA",
				"PEKUA",
				"COX'S BAZAR SADAR",
				"KUTUBDIA",
				"MAHESHKHALI",
				"RAMU",
				"TEKNAF",
				"UKHIA UPAZILA",
			}
		},
		{
			"FENI",
			new()
			{
				"CHHAGALNAIYA",
				"DAGANBHUIYAN",
				"FENI SADAR",
				"FULGAZI",
				"PARSHURAM",
				"SONAGAZI",
			}
		},
		{
			"KHAGRACHHARI",
			new()
			{
				"DIGHINALA",
				"KHAGRACHHARI SADAR",
				"LAKSHMICHHARI",
				"MAHALCHHARI",
				"MANIKCHHARI",
				"MATIRANGA",
				"PANCHHARI",
				"RAMGARH",
			}
		},
		{
			"LAKSHMIPUR",
			new()
			{
				"LAKSHMIPUR SADAR",
				"ROYPUR",
				"RAMGANJ",
				"RAMGATI",
				"KAMALNAGAR",
			}
		},
		{
			"NOAKHALI",
			new()
			{
				"BEGUMGANJ",
				"SONAIMURI",
				"CHATKHIL",
				"COMPANIGANJ",
				"HATIYA",
				"SENBAGH",
				"NOAKHALI SADAR",
				"SUBARNACHAR",
				"KABIRHAT",
			}
		},
		{
			"RANGAMATI",
			new()
			{
				"BAGHAICHHARI",
				"BARKAL UPAZILA",
				"KAWKHALI (BETBUNIA)",
				"BELAI CHHARI  UPAZI",
				"KAPTAI  UPAZILA",
				"JURAI CHHARI UPAZIL",
				"LANGADU  UPAZILA",
				"NANIARCHAR  UPAZILA",
				"RAJASTHALI  UPAZILA",
				"RANGAMATI SADAR  UP",
			}
		},
		{
			"DHAKA",
			new()
			{
				"KHILKHET",
				"BADDA",
				"CANTONMENT",
				"UTTAR KHAN",
				"KAFRUL",
				"DEMRA",
				"JATRABARI",
				"KADAMTALI",
				"NAWABGANJ",
				"SABUJBAGH",
				"KHILGAON",
				"DHAMRAI",
				"DHANMONDI",
				"DOHAR",
				"BHATARA",
				"RAMPURA",
				"GULSHAN",
				"ADABOR",
				"HAZARIBAGH",
				"SHER-E-BANGLA NAGAR",
				"BHANSAN TEK",
				"KAMRANGIR CHAR",
				"KERANIGANJ",
				"KOTWALI",
				"BANGSHAL",
				"CHAK BAZAR",
				"LALBAGH",
				"PALLABI",
				"DARUS SALAM",
				"MIRPUR",
				"SHAH ALI",
				"TURAG",
				"MOHAMMADPUR",
				"MOTIJHEEL",
				"PALTAN",
				"RAMNA",
				"SHAHBAGH",
				"SHAHJAHANPUR",
				"MUGDA PARA",
				"SAVAR",
				"SHYAMPUR",
				"GENDARIA",
				"SUTRAPUR",
				"WARI",
				"TEJGAON",
				"TEJGAON IND AREA",
				"BIMAN BANDAR",
				"DAKSHINKHAN",
				"UTTARA",
				"RUPNAGAR",
			}
		},
		{
			"FARIDPUR",
			new()
			{
				"ALFADANGA",
				"BHANGA",
				"BOALMARI",
				"CHAR BHADRASAN",
				"FARIDPUR SADAR",
				"MADHUKHALI",
				"SHALTHA",
				"NAGARKANDA",
				"SADARPUR",
			}
		},
		{
			"GAZIPUR",
			new()
			{
				"GAZIPUR SADAR",
				"KALIAKAIR",
				"KALIGANJ",
				"KAPASIA",
				"SREEPUR",
			}
		},
		{
			"GOPALGANJ",
			new()
			{
				"GOPALGANJ SADAR",
				"KASHIANI",
				"KOTALIPARA",
				"MUKSUDPUR",
				"TUNGIPARA",
			}
		},
		{
			"KISHOREGANJ",
			new()
			{
				"AUSTAGRAM",
				"BAJITPUR",
				"BHAIRAB",
				"HOSSAINPUR",
				"ITNA",
				"KARIMGANJ",
				"KATIADI",
				"KISHOREGANJ SADAR",
				"KULIAR CHAR",
				"MITHAMAIN",
				"NIKLI",
				"PAKUNDIA",
				"TARAIL",
			}
		},
		{
			"MADARIPUR",
			new()
			{
				"KALKINI",
				"MADARIPUR SADAR",
				"RAJOIR",
				"SHIB CHAR",
			}
		},
		{
			"MANIKGANJ",
			new()
			{
				"DAULATPUR",
				"GHIOR",
				"HARIRAMPUR",
				"MANIKGANJ SADAR",
				"SATURIA",
				"SHIBALAYA",
				"SINGAIR",
			}
		},
		{
			"MUNSHIGANJ",
			new()
			{
				"GAZARIA",
				"LOHAJANG",
				"MUNSHIGANJ SADAR",
				"SERAJDIKHAN",
				"SREENAGAR",
				"TONGIBARI",
			}
		},
		{
			"NARAYANGANJ",
			new()
			{
				"ARAIHAZAR",
				"SONARGAON",
				"BANDAR",
				"NARAYANGANJ SADAR",
				"RUPGANJ",
			}
		},
		{
			"NARSINGDI",
			new()
			{
				"BELABO",
				"MANOHARDI",
				"NARSINGDI SADAR",
				"PALASH",
				"ROYPURA",
				"SHIBPUR",
			}
		},
		{
			"RAJBARI",
			new()
			{
				"BALIAKANDI",
				"GOALANDA",
				"PANGSHA",
				"KALUKHALI",
				"RAJBARI SADAR",
			}
		},
		{
			"SHARIATPUR",
			new()
			{
				"BHEDARGANJ",
				"DAMUDYA",
				"GOSAIRHAT",
				"NARIA",
				"SHARIATPUR SADAR",
				"ZANJIRA",
			}
		},
		{
			"TANGAIL",
			new()
			{
				"BASAIL",
				"BHUAPUR",
				"DELDUAR",
				"GHATAIL",
				"GOPALPUR",
				"DHANBARI",
				"KALIHATI",
				"MADHUPUR",
				"MIRZAPUR",
				"NAGARPUR",
				"SAKHIPUR",
				"TANGAIL SADAR",
			}
		},
		{
			"JAMALPUR",
			new()
			{
				"BAKSHIGANJ",
				"DEWANGANJ",
				"ISLAMPUR",
				"JAMALPUR SADAR",
				"MADARGANJ",
				"MELANDAHA",
				"SARISHABARI UPAZILA",
			}
		},
		{
			"MYMENSINGH",
			new()
			{
				"BHALUKA",
				"DHOBAURA",
				"FULBARIA",
				"GAFFARGAON",
				"GAURIPUR",
				"HALUAGHAT",
				"ISHWARGANJ",
				"MYMENSINGH SADAR",
				"MUKTAGACHHA",
				"NANDAIL",
				"PHULPUR",
				"TARAKANDA",
				"TRISHAL",
			}
		},
		{
			"NETRAKONA",
			new()
			{
				"ATPARA",
				"BARHATTA",
				"DURGAPUR",
				"KHALIAJURI",
				"KALMAKANDA",
				"KENDUA",
				"MADAN",
				"MOHANGANJ",
				"NETROKONA SADAR",
				"PURBADHALA",
			}
		},
		{
			"SHERPUR",
			new()
			{
				"JHENAIGATI",
				"NAKLA",
				"NALITABARI",
				"SHERPUR SADAR",
				"SREEBARDI",
			}
		},
		{
			"BAGERHAT",
			new()
			{
				"BAGERHAT SADAR",
				"CHITALMARI",
				"FAKIRHAT",
				"KACHUA",
				"MOLLAHAT",
				"MONGLA",
				"MORRELGANJ",
				"RAMPAL",
				"SARANKHOLA",
			}
		},
		{
			"CHUADANGA",
			new()
			{
				"ALAMDANGA",
				"CHUADANGA SADAR",
				"DAMURHUDA",
				"JIBAN NAGAR",
			}
		},
		{
			"JESSORE",
			new()
			{
				"ABHAYNAGAR",
				"BAGHER PARA",
				"CHAUGACHHA",
				"JHIKARGACHHA",
				"KESHABPUR",
				"KOTWALI",
				"MANIRAMPUR",
				"SHARSHA",
			}
		},
		{
			"JHENAIDAH",
			new()
			{
				"HORINAKUNDA",
				"JHENAIDAH SADAR",
				"KALIGANJ",
				"KOTCHANDPUR",
				"MAHESHPUR",
				"SHAILKUPA",
			}
		},
		{
			"KHULNA",
			new()
			{
				"BATIAGHATA",
				"DACOPE",
				"DAULATPUR",
				"KHAN JAHAN ALI",
				"DUMURIA",
				"DIGHALIA",
				"KHALISHPUR",
				"PHULTALA",
				"KHULNA SADAR",
				"KOYRA",
				"PAIKGACHHA",
				"RUPSA",
				"SONADANGA",
				"TEROKHADA",
			}
		},
		{
			"KUSHTIA",
			new()
			{
				"BHERAMARA",
				"DAULATPUR",
				"KHOKSA",
				"KUMARKHALI",
				"KUSHTIA SADAR",
				"MIRPUR",
			}
		},
		{
			"MAGURA",
			new()
			{
				"MAGURA SADAR",
				"MOHAMMADPUR",
				"SHALIKHA",
				"SREEPUR",
			}
		},
		{
			"MEHERPUR",
			new()
			{
				"GANGNI",
				"MUJIB NAGAR",
				"MEHERPUR SADAR",
			}
		},
		{
			"NORAIL",
			new()
			{
				"KALIA",
				"LOHAGARA",
				"NARAIL SADAR",
			}
		},
		{
			"SATKHIRA",
			new()
			{
				"ASSASUNI",
				"DEBHATA",
				"KALAROA",
				"KALIGANJ",
				"SATKHIRA SADAR",
				"SHYAMNAGAR",
				"TALA",
			}
		},
		{
			"BOGRA",
			new()
			{
				"ADAMDIGHI",
				"BOGRA SADAR",
				"SHAJAHANPUR",
				"DHUNAT",
				"DHUPCHANCHIA",
				"GABTALI",
				"KAHALOO",
				"NANDIGRAM",
				"SARIAKANDI",
				"SONATOLA",
				"SHERPUR",
				"SHIBGANJ",
			}
		},
		{
			"JOYPURHAT",
			new()
			{
				"AKKELPUR",
				"JOYPURHAT SADAR",
				"KALAI",
				"KHETLAL",
				"PANCHBIBI",
			}
		},
		{
			"NAOGAON",
			new()
			{
				"ATRAI",
				"BADALGACHHI",
				"DHAMOIRHAT",
				"MANDA",
				"MAHADEBPUR",
				"NAOGAON SADAR",
				"NIAMATPUR",
				"PATNITALA",
				"PORSHA",
				"RANINAGAR",
				"SAPAHAR",
			}
		},
		{
			"NATORE",
			new()
			{
				"BAGATIPARA",
				"BARAIGRAM",
				"GURUDASPUR",
				"LALPUR",
				"NALDANGA",
				"NATORE SADAR",
				"SINGRA",
			}
		},
		{
			"NAWABGANJ",
			new()
			{
				"BHOLAHAT",
				"GOMASTAPUR",
				"NACHOLE",
				"CHAPAI NABABGANJ SADAR",
				"SHIBGANJ",
			}
		},
		{
			"PABNA",
			new()
			{
				"ATGHARIA",
				"BERA",
				"BHANGURA",
				"CHATMOHAR",
				"FARIDPUR",
				"ISHWARDI",
				"PABNA SADAR",
				"SANTHIA",
				"SUJANAGAR",
			}
		},
		{
			"RAJSHAHI",
			new()
			{
				"BAGHA",
				"BAGHMARA",
				"BOALIA",
				"SHAH MAKHDUM",
				"RAJPARA",
				"MATIHAR",
				"CHARGHAT",
				"GODAGARI",
				"DURGAPUR",
				"MOHANPUR",
				"PABA",
				"PUTHIA",
				"TANORE",
			}
		},
		{
			"SIRAJGANJ",
			new()
			{
				"BELKUCHI",
				"CHAUHALI",
				"KAMARKHANDA",
				"KAZIPUR",
				"ROYGANJ",
				"SHAHJADPUR",
				"SIRAJGANJ SADAR",
				"TARASH",
				"ULLAH PARA",
			}
		},
		{
			"DINAJPUR",
			new()
			{
				"BIRAMPUR",
				"BIRGANJ",
				"BIRAL",
				"BOCHAGANJ",
				"CHIRIRBANDAR",
				"KHANSAMA",
				"KAHAROLE",
				"FULBARI",
				"GHORAGHAT",
				"HAKIMPUR",
				"DINAJPUR SADAR",
				"NAWABGANJ",
				"PARBATIPUR",
			}
		},
		{
			"GAIBANDHA",
			new()
			{
				"FULCHHARI",
				"GAIBANDHA SADAR",
				"GOBINDAGANJ",
				"PALASHBARI",
				"SADULLAPUR",
				"SAGHATA",
				"SUNDARGANJ",
			}
		},
		{
			"KURIGRAM",
			new()
			{
				"BHURUNGAMARI",
				"CHAR RAJIBPUR",
				"CHILMARI",
				"PHULBARI",
				"KURIGRAM SADAR",
				"NAGESHWARI",
				"RAJARHAT",
				"RAUMARI",
				"ULIPUR",
			}
		},
		{
			"LALMONIRHAT",
			new()
			{
				"ADITMARI",
				"HATIBANDHA",
				"KALIGANJ",
				"LALMONIRHAT SADAR",
				"PATGRAM",
			}
		},
		{
			"NILPHAMARI",
			new()
			{
				"DIMLA UPAZILA",
				"JALDHAKA UPAZILA",
				"DOMAR UPAZILA",
				"KISHOREGANJ UPAZILA",
				"NILPHAMARI SADAR UPAZ",
				"SAIDPUR UPAZILA",
			}
		},
		{
			"RANGPUR",
			new()
			{
				"GANGACHARA",
				"BADARGANJ",
				"PIRGACHHA",
				"KAUNIA",
				"RANGPUR SADAR",
				"MITHA PUKUR",
				"PIRGANJ",
				"TARAGANJ",
			}
		},
		{
			"PANCHAGARH",
			new()
			{
				"BODA",
				"ATWARI",
				"DEBIGANJ",
				"PANCHAGARH SADAR",
				"TENTULIA",
			}
		},
		{
			"THAKURGAON",
			new()
			{
				"BALIADANGI",
				"HARIPUR",
				"PIRGANJ",
				"RANISANKAIL",
				"THAKURGAON SADAR",
			}
		},
		{
			"HABIGANJ",
			new()
			{
				"AJMIRIGANJ",
				"BAHUBAL",
				"BANIACHONG",
				"CHUNARUGHAT",
				"HABIGANJ SADAR",
				"LAKHAI",
				"MADHABPUR",
				"NABIGANJ",
			}
		},
		{
			"MAULVIBAZAR",
			new()
			{
				"BARLEKHA",
				"JURI",
				"KAMALGANJ",
				"KULAURA",
				"MAULVIBAZAR SADAR",
				"RAJNAGAR",
				"SREEMANGAL",
			}
		},
		{
			"SUNAMGANJ",
			new()
			{
				"BISHWAMBARPUR",
				"CHHATAK",
				"JAGANNATHPUR",
				"DERAI",
				"DHARAMPASHA",
				"DOWARABAZAR",
				"JAMALGANJ",
				"SULLA",
				"DAKSHIN SUNAMGANJ",
				"SUNAMGANJ SADAR",
				"TAHIRPUR",
			}
		},
		{
			"SYLHET",
			new()
			{
				"BALAGANJ",
				"BEANI BAZAR",
				"BISHWANATH",
				"COMPANIGANJ",
				"FENCHUGANJ",
				"GOLAPGANJ",
				"GOWAINGHAT",
				"JAINTIAPUR",
				"KANAIGHAT",
				"SYLHET SADAR",
				"DAKSHIN SURMA",
				"ZAKIGANJ",
			}
		},
	};
}
