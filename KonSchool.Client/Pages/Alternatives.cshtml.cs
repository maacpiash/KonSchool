using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KonSchool.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.Net.Http;
using System.Net.Http.Headers;

namespace KonSchool.Client.Pages
{
    public class AlternativesModel : PageModel
    {
        public Query query { get; set; }
        public FAHP fahp { get; set; }

        public void OnGet()
        {
            query = Program.MyQuery;
            
        }


    }
}