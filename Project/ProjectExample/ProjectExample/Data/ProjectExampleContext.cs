using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectExample.Models;

namespace ProjectExample.Data
{
    public class ProjectExampleContext : DbContext
    {
        public ProjectExampleContext (DbContextOptions<ProjectExampleContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectExample.Models.Book> Book { get; set; } = default!;
    }
}
