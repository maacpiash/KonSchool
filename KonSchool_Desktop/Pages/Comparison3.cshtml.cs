using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KonSchool_Desktop.Pages
{
    public class Comparison3Model : PageModel
    {
        [BindProperty]
        public string TS_AA { get; set; }
        [BindProperty]
        public string TS_LA { get; set; }
        [BindProperty]
        public string TS_SA { get; set; }
        [BindProperty]
        public string TS_SE { get; set; }
        [BindProperty]
        public string AA_LA { get; set; }
        
        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();
            return RedirectToPage("/Comparison3");
        }

    }
}
