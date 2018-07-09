using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using static KonSchool_Models.SerialNumbers;

namespace KonSchool_Desktop.Pages
{
    public class Comparison3Model : PageModel
    {
        [BindProperty]
        public string TSAA { get; set; }
        [BindProperty]
        public string TSLA { get; set; }
        [BindProperty]
        public string TSSA { get; set; }
        [BindProperty]
        public string TSSE { get; set; }
        [BindProperty]
        public string AALA { get; set; }
        
        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();
            Program.MyQuery.FuzzyValues[TS_AA] = Convert.ToInt32(TSAA);
            Program.MyQuery.FuzzyValues[TS_LA] = Convert.ToInt32(TSLA);
            Program.MyQuery.FuzzyValues[TS_SA] = Convert.ToInt32(TSSA);
            Program.MyQuery.FuzzyValues[TS_SE] = Convert.ToInt32(TSSE);
            Program.MyQuery.FuzzyValues[LA_AA] = Convert.ToInt32(AALA);
            
            return RedirectToPage("/Comparison3");
        }

    }
}
