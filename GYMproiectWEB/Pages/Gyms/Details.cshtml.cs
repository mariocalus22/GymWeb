using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GYMproiectWEB.Data;
using GYMproiectWEB.Models;

namespace GYMproiectWEB.Pages.Gyms
{
    public class DetailsModel : PageModel
    {
        private readonly GYMproiectWEB.Data.GYMproiectWEBContext _context;

        public DetailsModel(GYMproiectWEB.Data.GYMproiectWEBContext context)
        {
            _context = context;
        }

        public Gym Gym { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gym = await _context.Gym.FirstOrDefaultAsync(m => m.ID == id);

            if (Gym == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
