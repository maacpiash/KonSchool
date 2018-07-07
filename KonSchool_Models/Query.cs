using System;
using System.Collections.Generic;

using static System.Math;
using static KonSchool_Models.Stat;

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
        private double[] averAge;
        int numberOfSchools;
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
        public double[] AverAge => averAge;
        #endregion
        
        public School[] Schools;

        private string dbFile;
        public CSVreader fileReader;
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
            numberOfSchools = fileReader.Height;
            Schools = new School[numberOfSchools];
            averAge = new double[numberOfSchools];
            string whichClass = "";
            switch (_class)
            {
                case 6: whichClass = "SIX_AVG"; break;
                case 7: whichClass = "SEVEN_AVG"; break;
                case 8: whichClass = "EIGHT_AVG"; break;
                case 9: whichClass = "NINE_AVG"; break;
                case 10: whichClass = "TEN_AVG"; break;
                default: break;
            }

            Normalize(whichClass);

        }
        private void Normalize(string whichClass)
        {
            double[] ageDiffs = new double[numberOfSchools];
            string val;
            for (int i = 0; i < numberOfSchools; i++)
            {
                val = fileReader[Schools[i].EIIN, whichClass];
                ageDiffs[i] = Abs(Convert.ToDouble(val) - _age);
            }

            double mean, sd, sum = 0, dev = 0;
            for (int i = 0; i < numberOfSchools; i++)
                sum += ageDiffs[i];
            mean = sum / numberOfSchools;
            for (int i = 0; i < numberOfSchools; i++)
                dev += Pow((ageDiffs[i] - mean), 2);
            sd = Sqrt(dev / numberOfSchools);

            for (int i = 0; i < numberOfSchools; i++)
                Schools[i].ADS = NORMDIST(ageDiffs[i], mean, sd, true);
        }
        
    }
}
 