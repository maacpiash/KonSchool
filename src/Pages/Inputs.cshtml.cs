using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KonSchool.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace KonSchool.Pages
{
    public class InputsModel : PageModel
    {
        public Query _Query;

        public InputsModel(Query query) => _Query = query;
        
        [BindProperty] public int[] Values { get; set; }

        public void OnGet() => Values = new int[6];
        
        public IActionResult OnPost()
        {
            var compmat = Inference.ComparisonMatrix(Values);
            _Query.CompMat = compmat;
            _Query.Weights = new FAHP(compmat).CriteriaWeights;
            return RedirectToPage("/Outputs");
        }
    }
}