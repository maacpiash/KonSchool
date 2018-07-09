using System;
using System.Collections.Generic;

using static System.Math;
using static System.Convert;
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

        public int CriteriaCount;

        public ValueTuple<double, double, double>[,] ComparisonMatrix;
        #endregion
        
        public School[] Schools;

        public CSVreader fileReader;
        private static List<string> Occupations;
        private SchoolFactory sf;

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
            CriteriaCount = NumberofCriteria;
            criteria = new string[NumberofCriteria];
            fuzzyValues = new int[(NumberofCriteria * (NumberofCriteria - 1)) / 2];
            fileReader = new CSVreader(filePath);
            sf = new SchoolFactory(fileReader);
            Schools = sf.AllSchools;
            numberOfSchools = Schools.Length;
        }

        public void CreateComparisonMatrix()
        {
            ComparisonMatrix = new ValueTuple<double, double, double>[CriteriaCount,CriteriaCount];
            ValueTuple<double, double, double>[] TFNs = new ValueTuple<double, double, double>[]
            {
                (1/7, 1/7, 1/7), (1/7, 1/6, 1/5),
                (1/6, 1/5, 1/4), (1/5, 1/4, 1/3),
                (1/4, 1/3, 1/2), (1/3, 1/2, 1),
                (1, 1, 1),
                (1, 2, 3), (2, 3, 4),
                (3, 4, 5), (4, 5, 6),
                (5, 6, 7), (7, 7, 7)
            };
            int n = 0;

            for (int i = 0; i < CriteriaCount; i++)
                for (int j = i; j < CriteriaCount; j++)
                {
                    ComparisonMatrix[i, j] = TFNs[CriteriaCount + fuzzyValues[n]];
                    ComparisonMatrix[j, i] = TFNs[CriteriaCount - fuzzyValues[n]];
                    n++;
                }

            for (int k = 0; k < CriteriaCount; k++)                    
                ComparisonMatrix[k, k] = (1.0, 1.0, 1.0);
        }

        public void SetValues()
        {
            GetMFR();
            if (_location.Division != default(string))
                GetDIST();
            if (_class >= 6 && _class <= 10)
                GetADS();
            if (_social > 0)
                GetSES();
        }

        internal void GetMFR()
        {
            double mfr;
            School s;
            for (int i = 0; i < numberOfSchools; i++)
            {
                s = Schools[i];
                mfr = ToDouble(fileReader[s.EIIN, "FEM_STD_RATIO"]);
                s.Students_MFRatio = _isMale ? 1 - mfr : mfr;
            }

        }

        internal void GetDIST()
        {
            School s;
            for (int i = 0; i < numberOfSchools; i++)
            {
                s = Schools[i];
                s.Distance = 10;
                if (_location.Division == s.Location.Division)
                {
                    s.Distance -= 4;
                    if (_location.District == s.Location.District)
                    {
                        s.Distance -= 3;
                        if (_location.Thana == s.Location.Thana)
                        {
                            s.Distance -= 2;
                            if (_location.Union_Ward == s.Location.Union_Ward)
                            {
                                s.Distance -= 1;
                            }

                        }
                    }
                }

                s.Distance = 1 - s.Distance / 10;
            }

        }

        internal void GetADS()
        {
            double[] averAge = new double[numberOfSchools];
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

            double[] ageDiffs = new double[numberOfSchools];
            string val;
            for (int i = 0; i < numberOfSchools; i++)
            {
                val = fileReader[Schools[i].EIIN, whichClass];
                ageDiffs[i] = Abs(ToDouble(val) - _age);
            }

            double mean, sd, sum = 0, dev = 0;
            for (int i = 0; i < numberOfSchools; i++)
                sum += ageDiffs[i];
            mean = sum / numberOfSchools;
            for (int i = 0; i < numberOfSchools; i++)
                dev += Pow((ageDiffs[i] - mean), 2);
            sd = Sqrt(dev / numberOfSchools);

            for (int i = 0; i < numberOfSchools; i++)
                Schools[i].AverAge = NORMDIST(ageDiffs[i], mean, sd, true);
        }

        internal void GetSES()
        {
            School s;
            int eiin;
            for (int i = 0; i < numberOfSchools; i++)
            {
                s = Schools[i];
                eiin = s.EIIN;
                double locaScore = ToDouble(fileReader[eiin, "AScore"]) / 10;
                switch (_social)
                {
                    case 10.0:
                        s.SEScore = (ToDouble(fileReader[eiin, "SESscore_UP"]) * 2 + locaScore) / 3;
                        break;
                    case 7.5:
                        s.SEScore = (ToDouble(fileReader[eiin, "SESscore_UM"]) * 2 + locaScore) / 3;
                        break;
                    case 5.0:
                        s.SEScore = (ToDouble(fileReader[eiin, "SESscore_LM"]) * 2 + locaScore) / 3;
                        break;
                    case 2.5:
                        s.SEScore = (ToDouble(fileReader[eiin, "SESscore_LO"]) * 2 + locaScore) / 3;
                        break;
                    default:
                        s.SEScore = locaScore;
                        break;
                }

            }
        }

        public void WriteEverything(string filePath)
        {
            sf.WriteEverything(filePath);
        }
    }
}
 