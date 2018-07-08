using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

using KonSchool_Models;

namespace KonSchool_Desktop.Pages
{
    public class IndexModel : PageModel
    {
        public List<SelectListItem> Classes, Occupations, Divisions, Districts, Thanas, Unions_Wards;
        [BindProperty]
        public string Class { get; set; }
        [BindProperty]
        public string Occupation { get; set; }
        [BindProperty]
        public int Sex { get; set; }
        [BindProperty]
        public int Age { get; set; }
        
        [BindProperty]
        public string Division { get; set; }

        [BindProperty]
        public string District { get; set; }

        [BindProperty]
        public string Thana { get; set; }    

        [BindProperty]
        public string UW { get; set; }  

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
            Program.MyQuery.Occupation = Occupation;
            switch (Occupation)
            {
                case "Worker": case "Tati": case "Fisherman": case "Kamar/Kumar":
                    Program.MyQuery.Social = 2.5;
                    break;
                case "Cultivation": case "Expatriate": case "Small business":
                    Program.MyQuery.Social = 5.0;
                    break;
                case "Govt. job": case "Private job": case "Teacher":
                    Program.MyQuery.Social = 7.5;
                    break;
                case "Lawyer": case "Doctor": case "Engineer": case "Businessman":
                    Program.MyQuery.Social = 10.0;
                    break;
                default:
                    Program.MyQuery.Social = 1.0;
                    break;
            }
            Program.MyQuery.IsMale = Sex == 1;
            Program.MyQuery.Age = Age;
            Program.MyQuery.Location = new Address(Division, District, Thana, UW.Split('[')[0].Trim());
            Program.MyQuery.SetValues();
            Program.MyQuery.WriteEverything("NormDataset.csv");
            return RedirectToPage("/Comparison1");
        }
    }
}
