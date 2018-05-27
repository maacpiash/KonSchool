using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KonSchool_Desktop.Pages
{
    public class MF_RatioModel : PageModel
    {
        public string SexMessage { get; set; }

        [BindProperty]
        public object MyProperty
        {
            get;
            set;
        }

        public void OnGet()
        {
            SexMessage = Program.MyQuery.IsMale ? "boys' school for your son" : "girls' school for your daughter";
        }
    }
}
