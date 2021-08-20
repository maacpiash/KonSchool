using System.Collections.Generic;
using System.Linq;
using KonSchool.Shared;

namespace KonSchool.Schools
{
	public static class SchoolsRepositoryHelpers
	{
		public static School? GetSchool(this IEnumerable<School> schools, int EIIN) =>
			schools.Where(s => s.EIIN == EIIN).FirstOrDefault();

		public static IEnumerable<School> FilterByDivision(this IEnumerable<School> schools, string div)
		{
			if (string.IsNullOrWhiteSpace(div))
				return schools;

			string Div = div.ToUpper();
			return schools.Where(s => s.Division == Div);
		}

		public static IEnumerable<School> FilterByDistrict(this IEnumerable<School> schools, string dis)
		{
			if (string.IsNullOrWhiteSpace(dis))
				return schools;

			string Dis = dis.ToUpper();
			return schools.Where(s => s.District == Dis);
		}

		public static IEnumerable<School> FilterBySex(this IEnumerable<School> schools, string sex = "")
		{
			if (string.IsNullOrWhiteSpace(sex))
				return schools;

			var Sex = sex.ToUpper();
			if (Sex is "B" or "BOYS" or "M" or "MALE")
				return schools.Where(school => school.Type is not "GIRLS");
			else if (Sex is "G" or "GIRLS" or "F" or "FEMALE")
				return schools.Where(school => school.Type is not "BOYS");

			return schools;
		}

		public static IEnumerable<School> FilterBySegregated(this IEnumerable<School> schools, string? sex = "")
		{
			if (string.IsNullOrWhiteSpace(sex))
				return schools;

			var Sex = sex.ToUpper();
			if (Sex is "B" or "BOYS" or "M" or "MALE")
				return schools.Where(school => school.Type is "BOYS");
			else if (Sex is "G" or "GIRLS" or "F" or "FEMALE")
				return schools.Where(school => school.Type is "GIRLS");
			return schools;
		}

		public static IEnumerable<School> FilterByClass(this IEnumerable<School> schools, int Class)
		{
			if (Class is 9 or 10)
				return schools.Where(s => s.Level is not "Junior Secondary");
			return schools;
		}
	}
}
