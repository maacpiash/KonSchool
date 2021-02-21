using System.Collections.Generic;

namespace KonSchool.Client.Data
{
	public partial class LocationDataService : ILocationDataService
	{
		public List<string> Divisions { get; }
		public Dictionary<string, List<string>> Districts { get; }
		public Dictionary<string, List<string>> Thanas { get; }
		public Dictionary<string, List<string>> Unions_Wards { get; }
		public Dictionary<string, List<string>> LocalAreas { get; }

		public LocationDataService()
		{
			Divisions = new()
			{
				"BARISAL",
				"CHITTAGONG",
				"DHAKA",
				"MYMENSINGH",
				"KHULNA",
				"RAJSHAHI",
				"RANGPUR",
				"SYLHET"
			};

			Districts = GetAllDistricts();
			Thanas = GetAllThanas();
			Unions_Wards = GetAllUnionsWards();
			LocalAreas = GetAllLocalAreas();
		}
	}
}
