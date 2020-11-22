using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace KonSchool.Schools
{
	public class SchoolsService : ISchoolsService
	{
		private readonly List<School> allSchools;
		public SchoolsService(ISchoolsRepository repository)
		{
			allSchools = repository.GetAllSchools();
		}

		public List<School> GetAllSchools()
		{
			return allSchools;
		}

		public School GetSchool(int EIIN)
		{
			return allSchools.Where(s => s.EIIN == EIIN).FirstOrDefault();
		}

		public School GetSchool(string EIIN)
		{
			int eiin;
			return int.TryParse(EIIN, out eiin) ? GetSchool(eiin) : null;
		}

		public List<School> GetSchoolsByDivision(string div)
		{
			string division = div.ToUpper();
			return allSchools.Where(s => s.Division == division).ToList();
		}

		public List<School> GetSchoolsByDistrict(string dis)
		{
			string district = dis.ToUpper();
			return allSchools.Where(s => s.District == district).ToList();
		}

		public static List<School> FilterBySex(List<School> schools, string sex = "")
		{
			var s = sex.ToUpper();
			if (s == "B" || s == "BOYS" || s == "M" || s == "MALE")
				return schools.Where(s => s.Type == "BOYS").ToList();
			else if (s == "G" || sex == "GIRLS" || s == "F" || s == "FEMALE")
				return schools.Where(s => s.Type == "GIRLS").ToList();
			return schools;
		}
	}
}
