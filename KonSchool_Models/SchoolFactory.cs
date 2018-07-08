using System;

namespace KonSchool_Models
{
    public static class SchoolFactory
    {
        private static School[] allSchools;
        private static CSVreader myReader;

        private static string csvPath;

        public static School[] AllSchools
         => allSchools == null ? GetAllSchools() : allSchools;
          

        private static School[] GetAllSchools()
        {
            myReader = new CSVreader(csvPath);
            allSchools = new School[myReader.Height];
            return allSchools;
        }
    }
}