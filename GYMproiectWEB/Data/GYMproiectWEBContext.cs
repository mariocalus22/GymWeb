using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GYMproiectWEB.Models;

namespace GYMproiectWEB.Data
{
    public class GYMproiectWEBContext : DbContext
    {
        public GYMproiectWEBContext (DbContextOptions<GYMproiectWEBContext> options)
            : base(options)
        {
        }

        public DbSet<GYMproiectWEB.Models.Gym> Gym { get; set; }
    }
}
