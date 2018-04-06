using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageTest.Pages
{
    public class TestPage2Model : PageModel
    {
        public string Field1 { get; set; }

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string testaaa3 { get; set; }


        public void OnGet()
        {
            this.Field1 = "Unknown";
        }

        public void OnPost()
        {
            string name = this.Name;
            name = this.Request.Form["testaaa3"];
            this.Name = string.Empty;
            this.Field1 = name;
        }
    }
}