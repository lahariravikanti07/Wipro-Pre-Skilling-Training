using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskofMay19.Models;

namespace TaskofMay19.Data
{
    public class TaskofMay19Context : DbContext
    {
        public TaskofMay19Context (DbContextOptions<TaskofMay19Context> options)
            : base(options)
        {
        }

        public DbSet<TaskofMay19.Models.Product> Product { get; set; } = default!;
    }
}
