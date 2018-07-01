using System;

namespace KonSchool_Models
{
    public class SchoolFactory
    {
        private School[] allSchools;
        private CSVreader myReader;

        private string[] lines;

        public School[] AllSchools
         => allSchools == null ? GetAllSchools() : allSchools;
          

        private School[] GetAllSchools()
        {
            myReader = new CSVreader(lines);
            allSchools = new School[myReader.Height];
            return allSchools;
        }

        public SchoolFactory(string csvPath)
            => lines = System.IO.File.ReadAllLines(csvPath);
        
    }
}