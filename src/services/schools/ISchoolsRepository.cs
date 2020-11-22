using KonSchool.Shared;

namespace KonSchool.Schools
{
	public interface ISchoolsRepository
	{
		System.Collections.Generic.List<School> GetAllSchools();
	}
}
