using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MMaciejewski_64262_mvc_restauracja.Models;

namespace MMaciejewski_64262_mvc_restauracja.Data
{
    public class ProjectContext : DbContext
    {
        public ProjectContext (DbContextOptions<ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<MMaciejewski_64262_mvc_restauracja.Models.Danie> Danie { get; set; } = default!;
    }
}
