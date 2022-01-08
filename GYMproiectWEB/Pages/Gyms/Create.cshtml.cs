using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GYMproiectWEB.Data;
using GYMproiectWEB.Models;

namespace GYMproiectWEB.Pages.Gyms
{
    public class CreateModel : PageModel
    {
        private readonly GYMproiectWEB.Data.GYMproiectWEBContext _context;

        public CreateModel(GYMproiectWEB.Data.GYMproiectWEBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Gym Gym { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Gym.Add(Gym);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
