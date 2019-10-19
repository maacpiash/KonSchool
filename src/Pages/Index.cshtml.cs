using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

using KonSchool.Models;
using System.ComponentModel.DataAnnotations;

namespace KonSchool.Pages
{
    public class IndexModel : PageModel
    {
        public List<SelectListItem> Classes, Occupations, Divisions, Districts, Thanas, Unions_Wards;

        [BindProperty] [Required] public string Class { get; set; }
        [BindProperty] [Required] public string Occupation { get; set; }
        [BindProperty] [Required] public int Sex { get; set; }
        [BindProperty] [Required] public int Age { get; set; }
        [BindProperty] [Required] public string Division { get; set; }
        [BindProperty] [Required] public string District { get; set; }
        [BindProperty] [Required] public string Thana { get; set; }
        [BindProperty] [Required] public string UW { get; set; }
        [BindProperty] [Required] public bool ByDiv { get; set; }
        [BindProperty] [Required] public bool ByDist { get; set; }

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
            "Govt. job", "Private job", "Teacher", "Lawyer", "Doctor", "Engineer", "Businessman" };
            foreach (var item in collection)
                Occupations.Add(new SelectListItem { Value = item, Text = item });
            Occupations.Add(new SelectListItem() { Value = "Other", Text = "(Other)" });
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            HttpContext.Session.SetInt32("_Class", Convert.ToInt32(Class));
            HttpContext.Session.SetInt32("_Age", Age);
            HttpContext.Session.SetString("_Sex", Sex == 1 ? "Male" : "Female");
            HttpContext.Session.SetString("_Occupation", Occupation);

            switch (Occupation)
            {
                case "Worker":
                case "Tati":
                case "Fisherman":
                case "Kamar/Kumar":
                    HttpContext.Session.SetString("_Social", "2.5");
                    break;
                case "Cultivation":
                case "Expatriate":
                case "Small business":
                    HttpContext.Session.SetString("_Social", "5.0");
                    break;
                case "Govt. job":
                case "Private job":
                case "Teacher":
                    HttpContext.Session.SetString("_Social", "7.5");
                    break;
                case "Lawyer":
                case "Doctor":
                case "Engineer":
                case "Businessman":
                    HttpContext.Session.SetString("_Social", "10.0");
                    break;
                default:
                    HttpContext.Session.SetString("_Social", "1.0");
                    break;
            }
            
            HttpContext.Session.SetString("_Division", Division);
            HttpContext.Session.SetString("_District", District);
            HttpContext.Session.SetString("_Thana", Thana);
            HttpContext.Session.SetString("_UW", UW.Split('[')[0].Trim());
            HttpContext.Session.SetString("_ByDiv", ByDiv.ToString());
            HttpContext.Session.SetString("_ByDist", ByDist.ToString());
            return RedirectToPage("/Inputs");
        }
    }
}
