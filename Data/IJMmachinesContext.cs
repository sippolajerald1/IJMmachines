using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IJMmachines.Models;

namespace IJMmachines.Data
{
    public class IJMmachinesContext : DbContext
    {
        public IJMmachinesContext (DbContextOptions<IJMmachinesContext> options)
            : base(options)
        {
        }

        public DbSet<IJMmachines.Models.Machine> Machine { get; set; } = default!;
    }
}
