using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

using KonSchool_Desktop.Models;

namespace KonSchool_Desktop.Pages
{
    public class IndexModel : PageModel
    {
        public List<SelectListItem> Classes, Occupations;
        [BindProperty]
        public string Class { get; set; }
        [BindProperty]
        public string Occupation { get; set; }
        [BindProperty]
        public int Sex { get; set; }

        public IndexModel() => Populate();

        public void OnGet()
        {

        }
        public void Populate()
        {
            Classes = new List<SelectListItem>();
            string temp;
            for (int i = 6; i <= 10; i++)
            {
                temp = i.ToString();
                Classes.Add(new SelectListItem { Value = temp, Text = temp });
            }
            Occupations = new List<SelectListItem>();
            var collection = Query.GetOccupations();
            foreach (var item in collection)
                Occupations.Add(new SelectListItem { Value = item, Text = item });
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();
            Program.MyQuery.Class = Convert.ToInt32(Class);
            switch (Occupation)
            {
                case "Worker":
                case "Tati":
                case "Fisherman":
                case "Kamar/Kumar":
                    Program.MyQuery.Social = 0;
                    break;
                case "Cultivation": case "Expatriate": case "Small business":
                    Program.MyQuery.Social = 1;
                    break;
                case "Govt. job": case "Private job": case "Teacher":
                    Program.MyQuery.Social = 2;
                    break;
                case "Lawyer": case "Doctor": case "Engineer": case "Businessman":
                    Program.MyQuery.Social = 3;
                    break;
                default:
                    Program.MyQuery.Social = -1;
                    break;
            }
            Program.MyQuery.IsMale = Sex == 1;
            return RedirectToPage("/About");
        }
    }
}
