using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageUI.DataContext;
using RazorPageUI.Models;

namespace RazorPageUI.Pages.BoardGames
{
    public class AddModel : PageModel
    {
        private readonly BoardGamesDbContext _context;

        public AddModel (BoardGamesDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BoardGame BoardGame {get; set;}
        
        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BoardGames.Add(BoardGame);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
