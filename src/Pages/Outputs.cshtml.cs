using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using KonSchool.Models;

namespace KonSchool.Pages
{
    public class OutputsModel : PageModel
    {
        [BindProperty] public List<string> Criteria { get; set; }
        [BindProperty] public double StdDev { get; set; }
        [BindProperty] public string ConfLevel { get; set; }

        public void OnGet()
        {
            Criteria = new List<string>
            {
                "Teacher-Student Ratio", "Male-Female Ratio",
                "Socio-Economic Status", "Location of School",
                "Age of School", "Average Age of Students"
            };

            StdDev = Stat.StdDev(Program.Query.Weights);
            ConfLevel = new string[] { "Low", "Medium", "High" }[Program.Query.ConfLevel];

            double[] w = Program.Query.Weights;
            foreach (School s in Program.Query.Alternatives)
                s.FinalScore = s.TSR * w[0] + s.MFR * w[1] + s.SES * w[2] + s.LOC * w[3] + s.OLD * w[4] + s.AGE * w[6];
                   
            Program.Query.Alternatives = Program.Query.Alternatives.OrderByDescending(x => x.FinalScore).ToList();
                
        }

    }
}