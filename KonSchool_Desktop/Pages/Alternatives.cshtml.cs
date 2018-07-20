using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KonSchool_Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KonSchool_Desktop.Pages
{
    public class AlternativesModel : PageModel
    {
        public Query query { get; set; }
        public FAHP fahp { get; set; }

        public void OnGet()
        {
            query = Program.MyQuery;
            fahp = new FAHP(query.ComparisonMatrix);
        }


    }
}