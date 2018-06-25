using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KonSchool_Desktop.Pages
{
    public class Comparison2Model : PageModel
    {
        [BindProperty]
        public string AA_SA { get; set; }
        [BindProperty]
        public string AA_SE { get; set; }
        [BindProperty]
        public string LA_SA { get; set; }
        [BindProperty]
        public string LA_SE { get; set; }
        [BindProperty]
        public string SA_SE { get; set; }
        
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
