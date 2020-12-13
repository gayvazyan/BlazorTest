using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesTest.Pages
{
    public class MultipleModel : PageModel
    {
        public MultipleModel()
        {

        }
        [BindProperty]
        public string[] SelectedCountryValues { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            var country = SelectedCountryValues;
        }
    }
}
