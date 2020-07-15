using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using KonSchool.Models;
using KonSchool.Services;

namespace KonSchool.Pages
{
    public class OutputsModel : PageModel
    {
		private ISession session;

        public OutputsModel(ISchoolService schoolService, IHttpContextAccessor httpCtxAccessor)
        {
            SchoolService = schoolService;
			session = httpCtxAccessor.HttpContext.Session;
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
                Class = session.GetInt32("_Class") ?? 10,
                Age = session.GetInt32("_Age") ?? 16,
                Social = Convert.ToDouble(session.GetString("_Social")),
                IsMale = session.GetString("_Sex") == "Male",
                Occupation = session.GetString("_Occupation"),
                Division = session.GetString("_Division"),
                District = session.GetString("_District"),
                Thana = session.GetString("_Thana"),
                Union_Ward = session.GetString("_UW"),
                LimitByDivision = session.GetString("_ByDiv") == "True",
                LimitByDistrict = session.GetString("_ByDist") == "True"
            };

            Criteria = new string[]
            {
                "Teacher-Student Ratio", "Male-Female Ratio",
                "Socio-Economic Status", "Location of School",
                "Age of School", "Average Age of Students"
            };

            for (int i = 0; i < 6; i++)
            {
                _Query.Weights[i] = Convert.ToDouble(session.GetString("_Weight" + i));
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
