using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace KonSchool.Schools
{
	public class SchoolsService : ISchoolsService
	{
		private readonly List<School> allSchools;
		public SchoolsService(IServiceProvider serviceProvider)
		{
			var repository = serviceProvider.GetRequiredService<ISchoolsRepository>();
			allSchools = repository.GetAllSchools().ToList();
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
	}
}
