using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using static KonSchool.Models.SerialNumbers;

namespace KonSchool.App.Pages
{
    public class Comparison2Model : PageModel
    {
        [BindProperty]
        public string AASA { get; set; }
        [BindProperty]
        public string AASE { get; set; }
        [BindProperty]
        public string LASA { get; set; }
        [BindProperty]
        public string LASE { get; set; }
        [BindProperty]
        public string SASE { get; set; }
        
        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();
            Program.MyQuery.FuzzyValues[SA_AA] = Convert.ToInt32(AASA) * (-1);
            Program.MyQuery.FuzzyValues[SE_AA] = Convert.ToInt32(AASE) * (-1);
            Program.MyQuery.FuzzyValues[SA_LA] = Convert.ToInt32(LASA) * (-1);
            Program.MyQuery.FuzzyValues[SE_LA] = Convert.ToInt32(LASE) * (-1);
            Program.MyQuery.FuzzyValues[SE_SA] = Convert.ToInt32(SASE) * (-1);
            
            return RedirectToPage("/Comparison3");
        }

    }
}
