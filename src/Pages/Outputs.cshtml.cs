using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using KonSchool.Models;
using KonSchool.Services;

namespace KonSchool.Pages
{
    public class OutputsModel : PageModel
    {
        public OutputsModel(ISchoolService schoolService)
        {
            SchoolService = schoolService;
        }

        [BindProperty] public string[] Criteria { get; set; }
        [BindProperty] public double StdDev { get; set; }
        [BindProperty] public string[] Numbers { get; set; }
        [BindProperty] public Query _Query { get; set; }

        public ISchoolService SchoolService { get; set; }

        public void OnGet()
        {
            _Query = new Query(SchoolService)
            {
                Class = HttpContext.Session.GetInt32("_Class") ?? 10,
                Age = HttpContext.Session.GetInt32("_Age") ?? 16,
                Social = Convert.ToDouble(HttpContext.Session.GetString("_Social")),
                IsMale = HttpContext.Session.GetString("_Sex") == "Male",
                Occupation = HttpContext.Session.GetString("_Occupation"),
                Division = HttpContext.Session.GetString("_Division"),
                District = HttpContext.Session.GetString("_District"),
                Thana = HttpContext.Session.GetString("_Thana"),
                Union_Ward = HttpContext.Session.GetString("_UW"),
                LimitByDivision = HttpContext.Session.GetString("_ByDiv") == "True",
                LimitByDistrict = HttpContext.Session.GetString("_ByDist") == "True"
            };

            Criteria = new string[]
            {
                "Teacher-Student Ratio", "Male-Female Ratio",
                "Socio-Economic Status", "Location of School",
                "Age of School", "Average Age of Students"
            };

            for (int i = 0; i < 6; i++)
            {
                _Query.Weights[i] = Convert.ToDouble(HttpContext.Session.GetString("_Weight" + i));
            }

            StdDev = Stat.StdDev(_Query.Weights);

            double[] w = _Query.Weights;
            _Query.SetValues();
            
            foreach (School s in _Query.Alternatives)
                s.FinalScore = s.TSR * w[0] + s.MFR * w[1] + s.SES * w[2] + s.LOC * w[3] + s.OLD * w[4] + s.ADS * w[5];
                   
            _Query.Alternatives = _Query.Alternatives.OrderByDescending(x => x.FinalScore).ToList();
        }

        public string ToShortNumber(double number) => string.Format("{0:0.00}%", number * 100);
    }
}