using System.Collections.Generic;

namespace KonSchool.Client.Data
{
	public partial interface ILocationDataService
	{
		public List<string> Divisions { get; }
		public Dictionary<string, List<string>> Districts { get; }
		public Dictionary<string, List<string>> Thanas { get; }
		public Dictionary<string, List<string>> Unions_Wards { get; }
		public Dictionary<string, List<string>> LocalAreas { get; }
	}
}
