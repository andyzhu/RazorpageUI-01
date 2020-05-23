using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageUI.Models;

namespace RazorPageUI.Pages
{
    public class AddAddressModel : PageModel
    {


        [BindProperty]
        public Address Address {get; set;}
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/Index", new {Address.City});
        }
    }
}
