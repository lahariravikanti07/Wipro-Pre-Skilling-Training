using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskOfJune3.Models;

namespace TaskOfJune3.Data
{
    public class TaskOfJune3Context : DbContext
    {
        public TaskOfJune3Context (DbContextOptions<TaskOfJune3Context> options)
            : base(options)
        {
        }

        public DbSet<TaskOfJune3.Models.Product> Product { get; set; } = default!;
    }
}
