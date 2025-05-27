using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskOfMay27.Models;

namespace TaskOfMay27.Data
{
    public class TaskOfMay27Context : DbContext
    {
        public TaskOfMay27Context (DbContextOptions<TaskOfMay27Context> options)
            : base(options)
        {
        }

        public DbSet<TaskOfMay27.Models.Products> Products { get; set; } = default!;
    }
}
