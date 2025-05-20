using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskofMay20.Models;

namespace TaskofMay20.Data
{
    public class TaskofMay20Context : DbContext
    {
        public TaskofMay20Context (DbContextOptions<TaskofMay20Context> options)
            : base(options)
        {
        }

        public DbSet<TaskofMay20.Models.Employee> Employee { get; set; } = default!;
    }
}
