using System;
using System.Collections.Generic;
using System.Linq;

using static System.Math;

namespace KonSchool.Models
{
    public class Query
    {
        #region Properties
        public int Class { get; set; }
        public double Social { get; set; }
        public bool IsMale { get; set; }
        public int Age { get; set; }
        public string Division { get; set; }
        public string District { get; set; }
        public string Thana { get; set; }
        public string Union_Ward { get; set; }
        public double SES { get; set; }
        private string _occupation;
        public string Occupation { get => _occupation ?? "Other" ; set => _occupation = Occupations.Contains(value) ? value : "Other"; }
        public (double, double, double)[,] CompMat { get; set; }
        public double[] Weights { get; set; }
        public int ConfLevel { get; set; }
        #endregion

        private static readonly object key = new object();
        private static List<string> occupations;
        public List<School> Alternatives;

        public static List<string> Occupations
        {
            get
            {
                if (occupations == null) 
                {
                    lock (key)
                    {
                        if (occupations == null)
                        {
                            occupations = new List<string>()
                            {
                                "Worker", "Fisherman", "Tati", "Kamar/Kumar",
                                "Cultivation", "Expatriate", "Small business",
                                "Govt. job", "Private job", "Teacher",
                                "Lawyer", "Doctor", "Engineer", "Businessman"
                            };
                        }
                    }
                }
                return occupations;
            }
        }

        public int numberOfSchools { get; private set; }

        public void SetLocation(string div, string dist, string thana, string UW)
        {
            Division = div;
            District = dist;
            Thana = thana;
            Union_Ward = UW;

        }

        public Query(string csvPath)
        {
            //Alternatives = new SchoolFactory(csvPath).Schools;
        }

        public void SetValues()
        {
            foreach (School s in Alternatives)
            {
                if (!IsEligible(s))
                {
                    Alternatives.Remove(s);
                    continue;
                }

                // MFR
                if (IsMale) s.MFR = 1 - s.MFR;

                // LOC
                if (Division != default(string))
                    s.LOC = Division == s.Division ? (District == s.District ? (Thana == s.Thana ?
                            (Union_Ward == s.Union_Ward ? 10.0 : 9.0) : 7.0) : 4.0) : 0.0;

                // SES
                if (Social > 0)
                    s.SES = (s.SEScore[(int)(Social / 2.5) - 1] * 2 + s.SES) / 3;
            }

            // AGE
            GetAGE(Alternatives);
        }

        public void GetAGE(List<School> EligibleSchools)
        {
            int max = EligibleSchools.Count;

            double[] ageDiffs = new double[max];
            for (int i = 0; i < max; i++)
            {
                try
                {
                    ageDiffs[i] = Abs(EligibleSchools[i].AverAge[Class - 6] - (double)Age);
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.GetType().ToString());
                    Console.WriteLine($"i = {i}, max = {max}");
                }

            }

            double mean = ageDiffs.Average(), sd = Stat.StdDev(ageDiffs);

            for (int i = 0; i < max; i++)
                EligibleSchools[i].AGE = 1 - Stat.NORMDIST(ageDiffs[i], mean, sd, true);
        }        

        public bool IsEligible(School s)
            => !((IsMale && s.Type == "GIRLS") || (Class > 8 && s.Level == "Junior Secondary"));
    }
}
