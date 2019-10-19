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
        
        [BindProperty] public int[] Values { get; set; }

        public void OnGet() => Values = new int[6];
        
        public IActionResult OnPost()
        {
            var compmat = Inference.ComparisonMatrix(Values);
            var weights = new FAHP(compmat).CriteriaWeights;
            for (int i = 0; i < 6; i++)
            {
                HttpContext.Session.SetString("_Weight" + i, weights[i].ToString());
            }
            return RedirectToPage("/Outputs");
        }
    }
}