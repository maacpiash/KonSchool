using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using KonSchool.Models;
using KonSchool.Services;

namespace KonSchool.Pages
{
    public class OutputsModel : PageModel
    {
        public Query _Query { get; set; }
        public ISchoolService _SchoolService;

        public OutputsModel(Query query, ISchoolService schoolService)
        {
            _Query = query;
            _SchoolService = schoolService;
        }

        [BindProperty] public string[] Criteria { get; set; }
        [BindProperty] public double StdDev { get; set; }
        [BindProperty] public string[] Numbers { get; set; }

        public void OnGet()
        {
            Criteria = new string[]
            {
                "Teacher-Student Ratio", "Male-Female Ratio",
                "Socio-Economic Status", "Location of School",
                "Age of School", "Average Age of Students"
            };

            StdDev = Stat.StdDev(_Query.Weights);

            double[] w = _Query.Weights;
            _Query.SetValues();

            _Query._SchoolService = _SchoolService;
            
            foreach (School s in _Query.Alternatives)
                s.FinalScore = s.TSR * w[0] + s.MFR * w[1] + s.SES * w[2] + s.LOC * w[3] + s.OLD * w[4] + s.ADS * w[5];
                   
            _Query.Alternatives = _Query.Alternatives.OrderByDescending(x => x.FinalScore).ToList();
        }

        public string ToShortNumber(double number) => string.Format("{0:0.00}%", number * 100);
    }
}