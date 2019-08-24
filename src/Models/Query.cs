using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KonSchool.Services;
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
        private string _occupation;
        public string Occupation { get => _occupation ?? "Other" ; set => _occupation = Occupations.Contains(value) ? value : "Other"; }
        public (double, double, double)[,] CompMat { get; set; }
        public double[] Weights { get; set; }
        #endregion

        private static readonly object key = new object();
        private static List<string> occupations;
        public List<School> Alternatives
        {
            get => _SchoolService?.GetSchools()?.ToList() ?? alternatives ?? new List<School>();
            set => alternatives = value;
        }
        private List<School> alternatives;

        public ISchoolService _SchoolService { get; set; }

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
        #region Limitation by area
        public bool LimitByDivision { get; set; }
        public bool LimitByDistrict { get; set; }
        #endregion

        public void SetLocation(string div, string dist, string thana, string UW)
        {
            Division = div;
            District = dist;
            Thana = thana;
            Union_Ward = UW;
        }

        public void SetValues()
        {
            List<School> eligibleSchools = new List<School>();
            foreach (School s in Alternatives)
                if (IsEligible(s)) eligibleSchools.Add(s);
            
            foreach (School s in eligibleSchools)
            { 
                // MFR
                if (IsMale) s.MFR = 1 - s.MFR;

                // LOC
                if (Division != default(string))
                    s.LOC = Division == s.Division ? (District == s.District ? (Thana == s.Thana ?
                        (Union_Ward == s.Union_Ward ? 1.0 : 0.9) : 0.7) : 0.4) : 0.0;
                else
                    Console.Error.WriteLine("LOC not set!");

                // SES
                if (Social > 1.0)
                    s.SES = (s.SEScore[(int)(Social / 2.5) - 1] * 2 + s.SES) / 3;
            }

            // AGE
            GetAGE(eligibleSchools);

            Alternatives = eligibleSchools;
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
                    Console.Error.WriteLine(x.GetType().ToString());
                    Console.Error.WriteLine($"i = {i}, max = {max}");
                }

            }

            double mean = ageDiffs.Average(), sd = Stat.StdDev(ageDiffs);

            for (int i = 0; i < max; i++)
                EligibleSchools[i].ADS = 1 - Stat.NORMDIST(ageDiffs[i], mean, sd, true);
        }

        public bool IsEligible(School s)
        {
            if (IsMale && s.Type == "GIRLS")
                return false;
            if (!IsMale && s.Type == "BOYS")
                return false;
            if (Class > 8 && s.Level == "Junior Secondary")
                return false;
            if (LimitByDivision && s.Division != Division)
                return false;
            if (LimitByDistrict && s.District != District)
                return false;
            return true;
        }
    }
}
