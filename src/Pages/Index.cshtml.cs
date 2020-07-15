using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
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

		private ISession session;

		public IndexModel(IHttpContextAccessor httpCtxAccessor) => session = httpCtxAccessor.HttpContext.Session;

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
            session.SetInt32("_Class", Convert.ToInt32(Class));
            session.SetInt32("_Age", Age);
            session.SetString("_Sex", Sex == 1 ? "Male" : "Female");
            session.SetString("_Occupation", Occupation);

            switch (Occupation)
            {
                case "Worker":
                case "Tati":
                case "Fisherman":
                case "Kamar/Kumar":
                    session.SetString("_Social", "2.5");
                    break;
                case "Cultivation":
                case "Expatriate":
                case "Small business":
                    session.SetString("_Social", "5.0");
                    break;
                case "Govt. job":
                case "Private job":
                case "Teacher":
                    session.SetString("_Social", "7.5");
                    break;
                case "Lawyer":
                case "Doctor":
                case "Engineer":
                case "Businessman":
                    session.SetString("_Social", "10.0");
                    break;
                default:
                    session.SetString("_Social", "1.0");
                    break;
            }

            session.SetString("_Division", Division);
            session.SetString("_District", District);
            session.SetString("_Thana", Thana);
            session.SetString("_UW", UW.Split('[')[0].Trim());
            session.SetString("_ByDiv", ByDiv.ToString());
            session.SetString("_ByDist", ByDist.ToString());
            return RedirectToPage("/Inputs");
        }
    }
}
