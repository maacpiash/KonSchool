using KonSchool.Shared;

namespace KonSchool.Schools;

public interface ISchoolsRepository
{
	System.Collections.Generic.IEnumerable<School> GetAllSchools();
}
