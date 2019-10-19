using System.Collections.Generic;
using KonSchool.Models;
using KonSchool.Services;

namespace KonSchool.Services
{
    public class SchoolServiceMock : ISchoolService
    {
        public List<School> Schools { get; }

        public SchoolServiceMock()
        {
            Schools = new List<School>
            {
                new School(1212)
                {
                    Type = "BOYS",
                    Level = "Junior secondary",
                    Division = "Comilla"
                },
                new School(3434)
                {
                    Type = "BOYS",
                    Level = "Junior secondary",
                    Division = "Dhaka",
                    District = "Faridpur"
                },
                new School(5656)
                {
                    Type = "BOYS",
                    Level = "Secondary",
                    Division = "Dhaka"
                },
                new School(7878)
                {
                    Type = "GIRLS",
                    Level = "Secondary",
                    Division = "Dhaka",
                    District = "Gazipur"
                },
                new School(9090)
                {
                    Type = "GIRLS",
                    Level = "Secondary",
                    Division = "Dhaka",
                    District = "Dhaka"
                },
                new School(1010)
                {
                    Type = "BOYS",
                    Level = "Junior secondary",
                    Division = default(string)
                }
            };
        }

        public IEnumerable<School> GetSchools() => Schools;

        public School Get(string eiin) => Schools.Find(school => school.EIIN.Equals(eiin));
    }
}