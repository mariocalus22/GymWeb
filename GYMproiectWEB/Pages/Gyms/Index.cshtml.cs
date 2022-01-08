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
    public class IndexModel : PageModel
    {
        private readonly GYMproiectWEB.Data.GYMproiectWEBContext _context;

        public IndexModel(GYMproiectWEB.Data.GYMproiectWEBContext context)
        {
            _context = context;
        }

        public IList<Gym> Gym { get;set; }

        public async Task OnGetAsync()
        {
            Gym = await _context.Gym.ToListAsync();
        }
    }
}
