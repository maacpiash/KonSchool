using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KonSchool.App.Pages
{
    public class ComparisonModel : PageModel
    {

        //[BindProperty]
        //public double[] 
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();
            return RedirectToPage("/SelectAlts");
        }
    }
}