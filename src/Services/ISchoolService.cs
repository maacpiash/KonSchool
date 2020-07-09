namespace KonSchool.Services
{
	public interface ISchoolService
	{
		System.Collections.Generic.IEnumerable<KonSchool.Models.School> GetSchools();
	}
}
