using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectOfJune2.Models;

namespace ProjectOfJune2.Data
{
    public class ProjectOfJune2Context : DbContext
    {
        public ProjectOfJune2Context (DbContextOptions<ProjectOfJune2Context> options)
            : base(options)
        {
        }

        public DbSet<ProjectOfJune2.Models.Student> Student { get; set; } = default!;
    }
}
