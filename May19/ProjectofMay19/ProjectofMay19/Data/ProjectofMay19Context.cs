using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectofMay19.Models;

namespace ProjectofMay19.Data
{
    public class ProjectofMay19Context : DbContext
    {
        public ProjectofMay19Context (DbContextOptions<ProjectofMay19Context> options)
            : base(options)
        {
        }

        public DbSet<ProjectofMay19.Models.Student> Student { get; set; } = default!;
    }
}
