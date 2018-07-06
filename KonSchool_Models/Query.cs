using System;
using System.Collections.Generic;

namespace KonSchool_Models
{
    public class Query
    {
        #region private backing variables
        private int _class;
        private double _social;
        private bool _isMale;
        private int _age;
        private string _occupation;
        private Address _location;
        private int[] fuzzyValues;
        private string[] criteria;
        #endregion
        
        #region Public Properties
        public int Class { get => _class; set => _class = value; }
        public double Social { get => _social; set => _social = value; }
        public bool IsMale { get => _isMale; set => _isMale = value; }
        public int Age { get => _age; set => _age = value; }
        public string Occupation { get => _occupation; set => _occupation = GetOccupations().Contains(value) ? value : "Other"; }
        public Address Location { get => _location; set => _location = value; }
        public int[] FuzzyValues { get => fuzzyValues; set => fuzzyValues = value; }
        public string[] Criteria { get => criteria; set => criteria = value; }
        #endregion
        
        public School[] Schools;

        private string dbFile;
        private CSVreader fileReader;
        private static List<string> Occupations;


        public static List<string> GetOccupations()
        {
            if (Occupations == null)
                Occupations = new List<string>()
                {
                    "Worker", "Fisherman", "Tati", "Kamar/Kumar",
                    "Cultivation", "Expatriate", "Small business",
                    "Govt. job", "Private job", "Teacher",
                    "Lawyer", "Doctor", "Engineer", "Businessman"
                };
            return Occupations;
        }

        public Query(int NumberofCriteria, string filePath)
        {
            criteria = new string[NumberofCriteria];
            fuzzyValues = new int[(NumberofCriteria * (NumberofCriteria - 1)) / 2];
            fileReader = new CSVreader(System.IO.File.ReadAllLines(filePath));
            Schools = new School[fileReader.Height];
            
        }
        
    }
}
 