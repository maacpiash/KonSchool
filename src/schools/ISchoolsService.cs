using System.Collections.Generic;

namespace KonSchool.Schools
{
	public interface ISchoolsService
	{
		public List<School> GetAllSchools();
		public School GetSchool(string EIIN);
		public List<School> GetSchoolsByDivision(string div);
		public List<School> GetSchoolsByDistrict(string dis);
	}
}
