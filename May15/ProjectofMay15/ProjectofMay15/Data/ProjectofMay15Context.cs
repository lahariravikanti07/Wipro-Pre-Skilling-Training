using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectofMay15.Models;

namespace ProjectofMay15.Data
{
    public class ProjectofMay15Context : DbContext
    {
        public ProjectofMay15Context (DbContextOptions<ProjectofMay15Context> options)
            : base(options)
        {
        }

        public DbSet<ProjectofMay15.Models.Student> Student { get; set; } = default!;
    }
}
