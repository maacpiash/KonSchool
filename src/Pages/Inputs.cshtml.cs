using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KonSchool.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace KonSchool.Pages
{
    public class InputsModel : PageModel
    {
		private ISession session;
		[BindProperty] public int[] Values { get; set; }

        public static string[] Criteria = new string[]
        {
            "Teacher-Student Ratio",
            "Male-Female Ratio",
            "Socio-Economic Status",
            "Location of School",
            "Age of School",
            "Average Age of Students",
        };

		public InputsModel(IHttpContextAccessor httpCtxAccessor) => session = httpCtxAccessor.HttpContext.Session;

        public void OnGet() => Values = new int[6];

        public IActionResult OnPost()
        {
            var compmat = Inference.ComparisonMatrix(Values);
            var weights = new FAHP(compmat).CriteriaWeights;
            for (int i = 0; i < 6; i++)
            {
                session.SetString("_Weight" + i, weights[i].ToString());
            }
            return RedirectToPage("/Outputs");
        }
    }
}
