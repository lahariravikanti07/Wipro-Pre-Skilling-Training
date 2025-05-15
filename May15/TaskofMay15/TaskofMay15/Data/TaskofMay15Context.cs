using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskofMay15.Models;

namespace TaskofMay15.Data
{
    public class TaskofMay15Context : DbContext
    {
        public TaskofMay15Context (DbContextOptions<TaskofMay15Context> options)
            : base(options)
        {
        }

        public DbSet<TaskofMay15.Models.Employee> Employee { get; set; } = default!;
    }
}
