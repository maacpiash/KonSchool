using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KonSchool.Pages
{
    public class IndexModel : PageModel
    {
        public List<SelectListItem> Classes, Occupations, Divisions, Districts, Thanas, Unions_Wards;

        [BindProperty] public string Class { get; set; }

        [BindProperty] public string Occupation { get; set; }

        [BindProperty] public int Sex { get; set; }

        [BindProperty] public int Age { get; set; }

        [BindProperty] public string Division { get; set; }

        [BindProperty] public string District { get; set; }

        [BindProperty] public string Thana { get; set; }

        [BindProperty] public string UW { get; set; }

        public void OnGet()
        {
            Classes = new List<SelectListItem>();
            string temp;
            for (int i = 6; i <= 10; i++)
            {
                temp = i.ToString();
                Classes.Add(new SelectListItem { Value = temp, Text = temp });
            }

            Occupations = new List<SelectListItem>();
            string[] collection = { "Worker", "Tati", "Fisherman", "Kamar/Kumar", "Cultivation", "Expatriate", "Small business",
            "Govt. job", "Private job", "Teacher", "lawyer", "Doctor", "Engineer", "Businessman" };
            foreach (var item in collection)
                Occupations.Add(new SelectListItem { Value = item, Text = item });
            Occupations.Add(new SelectListItem() { Value = "Other", Text = "(Other)" });
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            Program.Query = new Models.Query("Schools.csv");
            Program.Query.Class = Convert.ToInt32(Class);
            Program.Query.Occupation = Occupation;
            switch (Occupation)
            {
                case "Worker":
                case "Tati":
                case "Fisherman":
                case "Kamar/Kumar":
                    Program.Query.SES = 2.5;
                    break;
                case "Cultivation":
                case "Expatriate":
                case "Small business":
                    Program.Query.SES = 5.0;
                    break;
                case "Govt. job":
                case "Private job":
                case "Teacher":
                    Program.Query.SES = 7.5;
                    break;
                case "Lawyer":
                case "Doctor":
                case "Engineer":
                case "Businessman":
                    Program.Query.SES = 10.0;
                    break;
                default:
                    Program.Query.SES = 1.0;
                    break;
            }
            Program.Query.IsMale = Sex == 1;
            Program.Query.Age = Age;
            string uw = UW == null ? "BHATARA" : UW.Split('[')[0].Trim();
            Program.Query.SetLocation(Division ?? "DHAKA", District ?? "DHAKA", Thana ?? "BHATARA", uw);
            return RedirectToPage("/Inputs");
        }
    }
}
