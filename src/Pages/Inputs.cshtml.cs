using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KonSchool.Pages
{
    public class InputsModel : PageModel
    {
        [BindProperty] public int[] Values { get; set; }

        [BindProperty] public int ConfLevel { get; set; }

        public void OnGet() => Values = new int[6];
        
        public IActionResult OnPost()
        {
            Program.Query.ConfLevel = ConfLevel;
            var compmat = Models.Inference.ComparisonMatrix(Values, ConfLevel);
            Program.Query.CompMat = compmat;
            Program.Query.Weights = new Models.FAHP(compmat).CriteriaWeights;
            return RedirectToPage("/Outputs");
        }
    }
}