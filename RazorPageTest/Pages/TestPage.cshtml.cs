using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageTest.Pages
{
    public class TestPageModel : PageModel
    {
        public void OnGet(int id, string id2)
        {
            ViewData["id"] = id;
            ViewData["id2"] = id2;
            this.Field1 = "aaaaa3";
        }

        public string Field1 { get; set; }

        //public async Task<IActionResult> OnGetAsync(int id)
        //{

        //    return Page();
        //}
    }
}