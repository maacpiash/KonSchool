using System.Collections.Generic;

namespace KonSchool.Lib
{
    public interface ISchoolService
    {
        School Get(string eiin);
        IEnumerable<School> GetSchools();
    }
}    