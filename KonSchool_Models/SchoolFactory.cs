using System;
using static System.Math;
using static System.Convert;

using static KonSchool_Models.Stat;

namespace KonSchool_Models
{
    public class SchoolFactory
    {
        private School[] allSchools;
        private CSVreader myReader;
        int numberOfSchools;

        public School[] AllSchools
         => allSchools == null ? GetAllallSchools() : allSchools;

        private School[] GetAllallSchools()
        {
            numberOfSchools = myReader.Height;
            allSchools = new School[numberOfSchools];

            int eiin;
            for (int i = 0; i < numberOfSchools; i++)
            {
                eiin = myReader.EIINs[i];
                allSchools[i] = new School(eiin)
                {
                    Name = myReader[eiin, "INSTITUTE NAME"],
                    Age = ToDouble(myReader[eiin, "AS_SCORE"]),
                    Location = new Address()
                    {
                        Division = myReader[eiin, "DIVISION"],
                        District = myReader[eiin, "DISTRICT"],
                        Thana = myReader[eiin, "THANA"],
                        Union_Ward = myReader[eiin, "UNION_NAME"],
                    },
                    StreetAddr = myReader[eiin, "ADDRESS"],
                    MobileNum = myReader[eiin, "MOBILE"],
                    Type = myReader[eiin, "STUDENT_TYPE"],
                    Level = myReader[eiin, "EDUCATION_LEVEL"]
                };
                CalcValues(allSchools[i]);
            }
            return allSchools;
        }

        public void CalcValues(School s)
        {
            int eiin = s.EIIN;

            // TSR

            s.TeacherStudentRatio = ToDouble(myReader[eiin, "TSR_SCORE"]);

            // SES : Calculated in Query class

            // MFR : Calculated in Query class

            // AS

            s.Age = ToDouble(myReader[eiin, "AS_SCORE"]);

            // DIST : Calculated in Query class

            // ADS : Calculated in Query class
        }

        public SchoolFactory(CSVreader fileReader)
            => myReader = fileReader;
    }
}