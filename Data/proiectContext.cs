using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proiect.models;

namespace proiect.Data
{
    public class proiectContext : DbContext
    {
        public proiectContext (DbContextOptions<proiectContext> options)
            : base(options)
        {
        }

        public DbSet<proiect.models.masina> masina { get; set; }

        public DbSet<proiect.models.Dealer> Dealer { get; set; }

        public DbSet<proiect.models.moto> moto { get; set; }
    }
}
