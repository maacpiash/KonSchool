using System;
using System.Collections.Generic;
using System.Linq;

using static System.Math;
using static System.Convert;
using static KonSchool.Models.Stat;
using static KonSchool.Models.SerialNumbers;

namespace KonSchool.Models
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
        private int[] _fuzzyValues;
        private double[] _critWeights;
        private int _confLevel;
        private ValueTuple<double, double, double>[,] _comparisonMatrix;
#endregion
        
#region Public Properties
        public int Class { get => _class; set => _class = value; }
        public double Social { get => _social; set => _social = value; }
        public bool IsMale { get => _isMale; set => _isMale = value; }
        public int Age { get => _age; set => _age = value; }
        public string Occupation { get => _occupation; set => _occupation = GetOccupations().Contains(value) ? value : "Other"; }
        public Address Location { get => _location; set => _location = value; }
        public int[] FuzzyValues { get => _fuzzyValues; set => _fuzzyValues = value; }
        public double[] CritWeights { get => _critWeights ?? (new FAHP(ComparisonMatrix)).CriteriaWeights; set => _critWeights = value; }
        public int ConfLevel { get => _confLevel; set => _confLevel = value < 0 ? 0 : (value > 2 ? 2 : value); }
        public ValueTuple<double, double, double>[,] ComparisonMatrix => _comparisonMatrix ?? CreateComparisonMatrix();
#endregion

        private static List<string> Occupations;
        int numberOfSchools;

        public List<School> Alternatives; // Serial numbers (not EIINs) of schools selected by user
        public int CriteriaCount;
        public School[] Schools; // ALL 14,274 schools from csv

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

        internal Query() { }    // Only for using in test cases
        public Query(int NumberofCriteria, string filePath)
        {
            CriteriaCount = NumberofCriteria;
            _fuzzyValues = new int[(NumberofCriteria * (NumberofCriteria - 1)) / 2];
            Schools = (new SchoolFactory(filePath)).AllSchools;
            numberOfSchools = Schools.Length;
            //SetValues();
        }

        public ValueTuple<double, double, double>[,] CreateComparisonMatrix()
        {
            int NumberofDegrees = 4;
            _comparisonMatrix = new ValueTuple<double, double, double>[CriteriaCount,CriteriaCount];
            var TFNs = new ValueTuple<double, double, double>[3, 9]
            {
                {
                    (1.0 / 7.0, 1.0 / 7.0, 1.0 / 7.0),
                    (1.0 / 7.0, 1.0 / 6.0, 1.0 / 4.5),
                    (1.0 / 5.5, 1.0 / 4.0, 1.0 / 2.5),
                    (1.0 / 3.5, 1.0 / 2.0, 1.0),
                    (1.0, 1.0, 1.0),
                    (1.0, 2.0, 3.5),
                    (2.5, 4.0, 5.5),
                    (4.5, 6.0, 7.0),
                    (7.0, 7.0, 7.0)
                },
                {
                    (1.0 / 7.0, 1.0 / 7.0, 1.0 / 7.0),
                    (1.0 / 7.0, 1.0 / 6.0, 1.0 / 5.0),
                    (0.2, 0.25, 1.0 / 3.0),
                    (1.0 / 3.0, 0.5, 1.0),
                    (1.0, 1.0, 1.0),
                    (1.0, 2.0, 3.0),
                    (3.0, 4.0, 5.0),
                    (5.0, 6.0, 7.0),
                    (7.0, 7.0, 7.0)
                },
                {
                    (1.0 / 7.0, 1.0 / 7.0, 1.0 / 7.0),
                    (1.0 / 6.5, 1.0 / 6.0, 1.0 / 5.5),
                    (1.0 / 4.5, 1.0 / 4.0, 1.0 / 3.5),
                    (1.0 / 2.5, 1.0 / 2.0, 1.0 / 1.5),
                    (1.0, 1.0, 1.0),
                    (1.5, 2.0, 2.5),
                    (3.5, 4.0, 4.5),
                    (5.5, 6.0, 6.5),
                    (7.0, 7.0, 7.0)
                }
            };
            
            int n = 0, lim = CriteriaCount - 1;
            for (int i = 0; i < lim; i++)
                for (int j = i + 1; j < CriteriaCount; j++)
                {
                    try
                    {
                        _comparisonMatrix[i, j] = TFNs[_confLevel, NumberofDegrees + _fuzzyValues[n]];
                        _comparisonMatrix[j, i] = TFNs[_confLevel, NumberofDegrees - _fuzzyValues[n]];
                        n++;
                    }
                    catch (Exception x)
                    {
                        Console.WriteLine(x.ToString());
                        Console.WriteLine($"i = {i}, j = {j}, n = {n}");
                    }
                }

            for (int k = 0; k < CriteriaCount; k++)                    
                _comparisonMatrix[k, k] = (1.0, 1.0, 1.0);
            return _comparisonMatrix;
        }

        public void SetValues()
        {
            School s;
            Alternatives = new List<School>();

            for (int i = 0; i < numberOfSchools; i++)
            {
                if (!IsEligible(Schools[i])) continue;

                // MFR
                s = Schools[i];
                if (_isMale) s.MFRatio = 1 - s.MFRatio;

                // DIST
                if (_location.Division != default(string))
                    GetDIST(s);

                // SES
                if (_social > 0)
                    s.SES = (s.SEScore[(int)(_social / 2.5) - 1] * 2 + s.SES) / 3;

                Alternatives.Add(s);
            }

            // ADS
            GetADS(Alternatives);
            NormalizeAllValues(Alternatives);
            Finish();
        }

#region ValueSetters
        
        internal void GetDIST(School s)
        {
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

        public void GetADS(List<School> EligibleSchools)
        {
            int max = EligibleSchools.Count;

            double[] ageDiffs = new double[max];
            for (int i = 0; i < max; i++)
            {
                try
                {
                    ageDiffs[i] = Abs(EligibleSchools[i].AverAge[_class - 6] - (double)_age);
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.GetType().ToString());
                    Console.WriteLine($"i = {i}, max = {max}");
                }

            }
            double mean, sd, sum = 0, dev = 0;
            for (int i = 0; i < max; i++)
                sum += ageDiffs[i];
            mean = sum / max;
            for (int i = 0; i < max; i++)
                dev += Pow((ageDiffs[i] - mean), 2);
            sd = Sqrt(dev / numberOfSchools);

            for (int i = 0; i < max; i++)
                EligibleSchools[i].ADS = 1 - NORMDIST(ageDiffs[i], mean, sd, true);
        }

#endregion

        public bool IsEligible(School s)
            => !((_isMale && s.Type == "GIRLS") || (_class > 8 && s.Level == "Junior Secondary"));
    
    
        public void NormalizeAllValues(List<School> Schools)
        {
            double MFR = 0, TSR = 0, SES = 0, ADS = 0, AS = 0, DIST = 0;
            int max = Schools.Count;
            double[] maxNow = new double[]
            {
                Schools[0].MFRatio, Schools[0].TSRatio, Schools[0].SES,
                Schools[0].ADS, Schools[0].Age, Schools[0].SES
            };
            double[] minNow = new double[]
            {
                Schools[0].MFRatio, Schools[0].TSRatio, Schools[0].SES,
                Schools[0].ADS, Schools[0].Age, Schools[0].SES
            };
            
            for (int i = 0; i < max; i++)
            {
                MFR += Schools[i].MFRatio;
                //if (Schools[i].MFRatio > maxNow[0]) maxNow[0] = Schools[i].MFRatio;
                //if (Schools[i].MFRatio < minNow[0]) minNow[0] = Schools[i].MFRatio;

                TSR += Schools[i].TSRatio;
                // if (Schools[i].MFRatio > maxNow[1]) maxNow[1] = Schools[i].MFRatio;
                // if (Schools[i].MFRatio < minNow[1]) minNow[1] = Schools[i].MFRatio;

                SES += Schools[i].SES;
                // if (Schools[i].MFRatio > maxNow[2]) maxNow[2] = Schools[i].MFRatio;
                // if (Schools[i].MFRatio < minNow[2]) minNow[2] = Schools[i].MFRatio;

                ADS += Schools[i].ADS;
                // if (Schools[i].MFRatio > maxNow[3]) maxNow[3] = Schools[i].MFRatio;
                // if (Schools[i].MFRatio < minNow[3]) minNow[3] = Schools[i].MFRatio;

                AS += Schools[i].Age;
                // if (Schools[i].MFRatio > maxNow[4]) maxNow[4] = Schools[i].MFRatio;
                // if (Schools[i].MFRatio < minNow[4]) minNow[4] = Schools[i].MFRatio;

                DIST += Schools[i].Distance;
                // if (Schools[i].MFRatio > maxNow[5]) maxNow[5] = Schools[i].MFRatio;
                // if (Schools[i].MFRatio < minNow[5]) minNow[5] = Schools[i].MFRatio;

            }
            for (int i = 0; i < max; i++)
            {
                Schools[i].MFRatio /= MFR;
                Schools[i].TSRatio /= TSR;
                Schools[i].SES /= SES;
                Schools[i].ADS /= ADS;
                Schools[i].Age /= AS;
                Schools[i].Distance /= DIST;
            }
        }

        public void Finish()
        {
            double[] Score;
            foreach (var item in Alternatives)
            {
                item.FinalScore = 0;
                Score = new double[]
                {
                    item.TSRatio, item.SES, item.MFRatio,
                    item.Age, item.Distance, item.ADS
                }; // According to the serial described in SerialNumbers class
                item.WeightedScores = new double[6];
                for (int i = 0; i < CriteriaCount; i++)
                {
                    item.WeightedScores[i] = Score[i] * CritWeights[i];
                    item.FinalScore += Sqrt(item.WeightedScores[i]);
                }
                item.FinalScore /= CriteriaCount;
            }
            
            Alternatives = Alternatives.OrderBy(x => x.FinalScore).ToList();
        }

        public void Refine(bool ByDistrict = false, bool ByThana = false)
        {
            var Choices = new List<School>();
            foreach (var s in Alternatives)
            {
                if (ByDistrict && s.Location.District == _location.District)
                {
                    Choices.Add(s);
                    if (ByThana && s.Location.Thana == _location.Thana)
                        Choices.Add(s);
                }
            }
            Alternatives = Choices;
        }
    }
}