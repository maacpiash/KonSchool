using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using static KonSchool_Models.SerialNumbers;

namespace KonSchool_Desktop.Pages
{
    public class Comparison1Model : PageModel
    {
        [BindProperty]
        public string MFTS { get; set; }
        [BindProperty]
        public string MFAA { get; set; }
        [BindProperty]
        public string MFLA { get; set; }
        [BindProperty]
        public string MFSA { get; set; }
        [BindProperty]
        public string MFSE { get; set; }

        [BindProperty]
        public string UW { get; set; }
        
        public void OnGet()
        {
            UW = Program.MyQuery.Location.Union_Ward;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();
            Program.MyQuery.FuzzyValues[TS_MF] = Convert.ToInt32(MFTS) * (-1);
            Program.MyQuery.FuzzyValues[MF_AA] = Convert.ToInt32(MFAA);
            Program.MyQuery.FuzzyValues[MF_LA] = Convert.ToInt32(MFLA);
            Program.MyQuery.FuzzyValues[MF_SA] = Convert.ToInt32(MFSA);
            Program.MyQuery.FuzzyValues[SE_MF] = Convert.ToInt32(MFSE) * (-1);
            
            return RedirectToPage("/Comparison2");
        }

    }
}
